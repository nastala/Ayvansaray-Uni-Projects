using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faturaİslemleri
{
    public partial class FaturaDetayForm : Form
    {
        private FaturaContext _db;
        private List<FaturaDetay> _faturaDetays;

        public FaturaDetayForm(ICollection<FaturaDetay> faturaDetays)
        {
            InitializeComponent();

            _faturaDetays = faturaDetays.ToList();
            Initialize();
        }

        private void Initialize()
        {
            _db = new FaturaContext();
            dgvFaturaDetaylari.DataSource = _faturaDetays;
        }
    }
}
