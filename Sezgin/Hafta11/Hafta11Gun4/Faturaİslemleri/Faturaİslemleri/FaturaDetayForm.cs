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

        public FaturaDetayForm(HashSet<FaturaDetay> faturaDetays)
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _db = new FaturaContext();
        }
    }
}
