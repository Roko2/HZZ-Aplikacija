using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HZZ_Kategorije
{
    public partial class FormBrisanjeKategorije : Form
    {
        private int id;
        private BindingSource _tableBindingSource = new BindingSource();
        private MainRepository _categoryRepository = new MainRepository();
        private HZZ _hzzRepository = new HZZ();
        private Form oKategorija =new Form();
        public FormBrisanjeKategorije(int categoryID,Form Obrisani)
        {
            id = categoryID;
            oKategorija = Obrisani as HZZ;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _categoryRepository.DeleteCategoryFromDB(id);
            DataGridView tablica = (DataGridView)this.oKategorija.Controls[4].Controls[1].Controls[15];
            _tableBindingSource.DataSource = _categoryRepository.GetDBCategories();
            tablica.DataSource = _tableBindingSource;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
