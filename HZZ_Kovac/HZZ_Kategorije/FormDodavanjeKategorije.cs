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
    public partial class FormDodavanjeKategorije : Form
    {
        private List<CheckBox> odabraneKategorije = new List<CheckBox>();
        private BindingSource _tableBindingSource = new BindingSource();
        private MainRepository _categoryRepository = new MainRepository();
        private Form oKategorija = new Form();
        public FormDodavanjeKategorije(List<CheckBox> kategorija,Form DodanaKategorija)
        {
            odabraneKategorije = kategorija;
            oKategorija = DodanaKategorija as HZZ;
            InitializeComponent();
        }
        
        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonDodaj_Click(object sender, EventArgs e)
        {
            List<Category> CategorySelect = new List<Category>();
            List<Category> kategorije = new List<Category>();
            List<Category> kategorijeDB = new List<Category>();
            kategorijeDB = await _categoryRepository.GetDBCategories();
            var pronadeni = (from c in odabraneKategorije
                             from d in kategorijeDB
                             where Convert.ToInt32(c.Name) == d.ID
                             select c).Any();
            if (pronadeni == true)
            {
                MessageBox.Show("Odabrali ste već postojeću kategoriju u bazi podataka.", "Obavijest");
            }
            else
            {
                kategorije = await _categoryRepository.GetCategories();
                foreach (CheckBox item in odabraneKategorije)
                {
                    CategorySelect = kategorije.Where(x => x.ID == Convert.ToInt32(item.Name)).ToList();
                    _categoryRepository.AddCategory(CategorySelect);
                }
                DataGridView tablica = (DataGridView)this.oKategorija.Controls[4].Controls[1].Controls[15];
                _tableBindingSource.DataSource = _categoryRepository.GetDBCategories();
                tablica.DataSource = _tableBindingSource;
            }
            this.Close();
        }
    }
}
