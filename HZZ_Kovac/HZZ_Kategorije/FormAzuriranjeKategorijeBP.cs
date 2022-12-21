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
    public partial class FormAzuriranjeKategorijeBP : Form
    {
        private Category kategorija=new Category();
        private MainRepository _categoryRepository = new MainRepository();
        private Form kategorijaForm = new Form();
        public FormAzuriranjeKategorijeBP(Category Kategorija,Form Azurirani)
        {
            kategorija = Kategorija;
            kategorijaForm = Azurirani as HZZ;
            InitializeComponent();
        }

        private void FormAzuriranjeKategorijeBP_Load(object sender, EventArgs e)
        {
            txtBoxID.Text = kategorija.ID.ToString();
            inptNazivKategorije.Text = kategorija.Description;
            inptUrlKategorije.Text = kategorija.Url;
            DateTime datum = DateTime.Now;
            dateTimePickerObjava.Value=datum;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Category objektKategorije = new Category();
            objektKategorije.ID = Convert.ToInt32(txtBoxID.Text);
            objektKategorije.Description = inptNazivKategorije.Text;
            objektKategorije.Url = inptUrlKategorije.Text;
            objektKategorije.DatumSpremanjaUBazu = dateTimePickerObjava.Value;
            if (objektKategorije.Description == "" || objektKategorije.Url == "")
            {
                MessageBox.Show("Popunite sva polja kako bi uspješno ažurirali kategoriju.", "Greška");
            }
            else
            {
                FormPotvrda potvrda = new FormPotvrda(objektKategorije, kategorijaForm);
                potvrda.ShowDialog(this);
            }
        }
    }
}
