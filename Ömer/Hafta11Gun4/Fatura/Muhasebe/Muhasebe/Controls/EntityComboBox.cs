using Muhasebe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.Controls
{
    class EntityComboBox : ComboBox
    {
        public void LoadEntities<T>() where T: DatabaseObject
        {
            Items.Clear();
            var dbSet = AccountingModel.DatabaseModel.Set<T>();
            Items.AddRange(dbSet.ToArray());
            if (Items.Count > 0)
            {
                SelectedIndex = 0;
            }
        }
        public void LoadEntities<T>(Predicate<T> filter) where T : DatabaseObject
        {
            Items.Clear();
            var dbSet = AccountingModel.DatabaseModel.Set<T>();

            foreach (var entityObject in dbSet)
            {
                if (filter(entityObject) == true)
                {
                    Items.Add(entityObject);
                }
            }
            if (Items.Count > 0)
            {
                SelectedIndex = 0;
            }
        }
        public T GetSelected<T>() where T : DatabaseObject
        {
            if (SelectedIndex != -1)
            {
                return (T)SelectedItem;
            }
            return default(T);
        }
        public int SelectedEntityId => ((DatabaseObject)SelectedItem).Id;
        public void SetSelected(DatabaseObject entityObject)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                var eObj = (DatabaseObject)Items[i];
                if (eObj.Id == entityObject.Id)
                {
                    SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
