using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace HZZ_Kategorije
{
    public partial class FormPotvrda : Form
    {
        private Category objektKategorija = new Category();
        private BindingSource _tableBindingSource = new BindingSource();
        private MainRepository _categoryRepository = new MainRepository();
        private Form kategorijaForm = new Form();
        public FormPotvrda(Category oKategorija,Form azurirani)
        {
            kategorijaForm = azurirani as HZZ;
            objektKategorija = oKategorija;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<Category> kategorije = new List<Category>();
            _categoryRepository.AzurirajKategorijuBP(objektKategorija);
            DataGridView tablica = (DataGridView)this.kategorijaForm.Controls[4].Controls[1].Controls[15];
            _tableBindingSource.DataSource = _categoryRepository.GetDBCategories();
            tablica.DataSource = _tableBindingSource;
            this.Close();
            ((FormAzuriranjeKategorijeBP)Owner).Close();
        }
    }
}
