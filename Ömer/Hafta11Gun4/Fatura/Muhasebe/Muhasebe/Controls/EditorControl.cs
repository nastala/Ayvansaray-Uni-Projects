using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muhasebe.Entities;
using System.Data.Entity;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Muhasebe
{
    public partial class EditorControl<T> : UserControl where T : DatabaseObject
    {
        public event Func<DatabaseUpsertType,T> UpsertClick;
        public event Action<T> SelectedItemChanged;
        public bool Filter { get; set; }

        private DbSet<T> _dbSet;
        private Predicate<T> _lastFilter;
        private DbContextTransaction _transaction;
        private ColumnHide _columnHide;

        public EditorControl(ColumnHide columnHide = ColumnHide.Key, EditorButtons editorButtons = EditorButtons.Add|EditorButtons.Update|EditorButtons.Delete)
        {
            _columnHide = columnHide;

            InitializeComponent();
            AssignTable();
            AdjustButtons(editorButtons);
            _transaction = AccountingModel.DatabaseModel.Database.BeginTransaction();
        }

        private void AdjustButtons(EditorButtons editorButtons)
        {
            if (editorButtons.HasFlag(EditorButtons.Add) == false)
            {
                bAdd.Visible = false;
            }
            if (editorButtons.HasFlag(EditorButtons.Update) == false)
            {
                bUpdate.Visible = false;
            }
            if (editorButtons.HasFlag(EditorButtons.Delete) == false)
            {
                bDelete.Visible = false;
            }
        }

        ~EditorControl()
        {
            _transaction.Dispose();
        }
        private void RenameAndHideColumns()
        {
            var properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var displayAttribute = property.GetCustomAttributes();
                foreach (var attribute in displayAttribute)
                {
                    if (_columnHide.HasFlag(ColumnHide.Key) && attribute is KeyAttribute)
                    {
                        dGVEntity.Columns[property.Name].Visible = false;
                    }
                    else if (_columnHide.HasFlag(ColumnHide.ForeignKey) && attribute is System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute)
                    {
                        dGVEntity.Columns[property.Name].Visible = false;
                    }
                    else if (attribute is DisplayAttribute dA)
                    {
                        dGVEntity.Columns[property.Name].HeaderText = dA.Name;
                    }
                }
            }
        }
        public void ApplyFilter(Predicate<T> filter)
        {
            if (filter == null) return;
            List<T> filtered = new List<T>();
            foreach (var entity in _dbSet)
            {
                if (filter(entity) == true)
                {
                    filtered.Add(entity);
                }
            }
            dGVEntity.DataSource = filtered;
            _lastFilter = filter;
        }
        public void RemoveFilter()
        {
            _lastFilter = null;
            dGVEntity.DataSource = _dbSet.ToList();
        }
        public void AssignTable()
        {
            _dbSet = AccountingModel.DatabaseModel.Set<T>();
            dGVEntity.DataSource = _dbSet.ToList();
            RenameAndHideColumns();
        }
        public void AddTo(Control control)
        {
            Dock = DockStyle.Bottom;
            control.Controls.Add(this);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            var tObject = UpsertClick(DatabaseUpsertType.Add);
            _dbSet.Add(tObject);

            UpdateDatabaseAndView();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var tObject = UpsertClick(DatabaseUpsertType.Update);
            if (tObject != null)
            {
                var selectedId = GetSelectedId();

                var dbObject = _dbSet.First(x => x.Id == selectedId);
                tObject.CloneToExceptId(dbObject);

                UpdateDatabaseAndView();
            }
        }

        private int GetSelectedId()
        {
            return (int)dGVEntity.SelectedCells[0].OwningRow.Cells["Id"].Value;
        }

        private void Entity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedId = GetSelectedId();
            var selectedObject = _dbSet.Local.First(x => x.Id == selectedId);
            SelectedItemChanged(selectedObject);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var selectedId = GetSelectedId();

            _dbSet.Remove(_dbSet.First(x => x.Id == selectedId));

            UpdateDatabaseAndView();
        }
        public void SaveChanges()
        {
            AccountingModel.DatabaseModel.SaveChanges();

        }
        public void CommitChanges()
        {
            AccountingModel.DatabaseModel.SaveChanges();

            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction = AccountingModel.DatabaseModel.Database.BeginTransaction();
            }
        }
        public void RevertChanges()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
            }
            UpdateDatabaseAndView();
        }
        private void UpdateDatabaseAndView()
        {
            SaveChanges();
            if (Filter == false || _lastFilter == null)
            {
                dGVEntity.DataSource = _dbSet.Local.ToList();
            }
            else
            {
                ApplyFilter(_lastFilter);
            }
        }
    }
}
