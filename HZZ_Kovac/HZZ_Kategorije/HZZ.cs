using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace HZZ_Kategorije
{

    public partial class HZZ : Form
    {
        //privatne globalne funkcije
        private MainRepository _MainRepository = new MainRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        private BindingSource _tableBindingSourceBPCategory = new BindingSource();
        private List<CheckBox> odabraniBoxovi = new List<CheckBox>();
        private List<CheckBox> sviBoxovi = new List<CheckBox>();
        private List<CheckBox> neOdabraniBoxovi = new List<CheckBox>();
        private bool gumbOsvjeziJeKliknut = false;
        private int klikOsvjezi = 0;
        public HZZ()
        {
            InitializeComponent();
            _tableBindingSourceBPCategory.DataSource = _MainRepository.GetDBCategories();
        }
        //Učitavanje ikona,datuma,tablica i labela
        private void Kategorije_Load(object sender, EventArgs e)
        {
            lblNaslovnaStatistika.BackColor = Color.FromArgb(23, 23, 23);
            DateTime datum = DateTime.Now;
            datePickerDatum.MaxDate=datum;
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
            DataGridViewImageColumn buttonObrisi = new DataGridViewImageColumn();
            var path1 = new DirectoryInfo(Application.StartupPath).Parent.Parent.Parent.FullName;
            buttonObrisi.Image = Bitmap.FromFile(path1 + "\\Slike\\bin.png");
            buttonObrisi.Width = 20;
            buttonObrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBPCategory.Columns.Add(buttonObrisi);

            DataGridViewImageColumn buttonAzuriraj = new DataGridViewImageColumn();
            var path2 = new DirectoryInfo(Application.StartupPath).Parent.Parent.Parent.FullName;
            buttonAzuriraj.Image = Bitmap.FromFile(path2 + "\\Slike\\updateNew.png");
            buttonAzuriraj.Width = 20;
            buttonAzuriraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBPCategory.Columns.Add(buttonAzuriraj);
            dataGridViewBPCategory.AutoGenerateColumns = false;
            dataGridViewBPCategory.DataSource = _tableBindingSourceBPCategory;

            Statistika();
        }
        //popunjavanje labela za statistiku
        public void Statistika() 
        {
            List<RadnaMjesta> sviPoslovi = new List<RadnaMjesta>();
            List<RadnaMjesta> sviPosloviDB = new List<RadnaMjesta>();
            List<Category> kategorije = new List<Category>();
            List<Category> kategorijeDB = new List<Category>();
            kategorije = _MainRepository.GetCategories();
            sviPoslovi = _MainRepository.GetSvaRadnMjesta();
            kategorijeDB = _MainRepository.GetDBCategories();
            sviPosloviDB = _MainRepository.GetDBFreeJobs();
            lblspremljeneKategorije.Text = kategorijeDB.Count.ToString();
            lblUkupanBrKategorija.Text = kategorije.Count.ToString();
            lblUkupanBrojPoslova.Text = sviPoslovi.Count.ToString();
            lblSpremljeniPoslovi.Text = sviPosloviDB.Count.ToString();
        }
        //Izmjena tabova i prikaz drugih panela
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (gumbOsvjeziJeKliknut)
                {
                    panelOpcije.Visible = true;
                    panelBP.Visible = false;
                }
                else
                {
                    panelOpcije.Visible = false;
                    panelBP.Visible = true;
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                panelOpcije.Visible = false;
                panelBP.Visible = true;
            }
            if (tabControl1.SelectedIndex == 2)
            {
                panelOpcije.Visible = false;
                panelBP.Visible = true;
                
            }
        }
        //gumbza otvaranje forme slobodna radna mjesta 
        public void btnButton_Click(object varijabla, EventArgs e, string broj)
        {
            string URL = _MainRepository.DohvatiUrl(broj);
            FormSlobodnaRadnaMjesta f2 = new FormSlobodnaRadnaMjesta(URL);
            f2.ShowDialog();
        }
        //izlaz iz aplikacije
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //gumb osvjezi koji brise stare nacrtane gumbove kategorija i crta nove,ucitava check boxove
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (klikOsvjezi >= 1)
            {
                for (int x = tabPageKategorije.Controls.Count - 1; x >= 0; x--)
                {
                    if (tabPageKategorije.Controls[x] is Button)
                    {
                        tabPageKategorije.Controls[x].Dispose();
                    }
                }
                sviBoxovi.Clear();
            }
            
            gumbOsvjeziJeKliknut = true;
            panelOpcije.Visible = true;
            panelBP.Visible = false;
            int top1 = 70, left1 = 5, top2 = 6, left2 = 150, counter = 0, broj = 1;
            List<Category> kategorije = new List<Category>();
            kategorije = _MainRepository.GetCategories();
            for (int i = 0; i < kategorije.Count(); i++)
            {
                    Button button = new Button();
                    CheckBox dynamicCheckBox = new CheckBox();
                    sviBoxovi.Add(dynamicCheckBox);
                    dynamicCheckBox.Left = left2;
                    dynamicCheckBox.Top = top2;
                    dynamicCheckBox.Width = 15;
                    dynamicCheckBox.Height = 15;
                    dynamicCheckBox.Name = broj.ToString();
                    button.BackColor = Color.FromArgb(38, 70, 122);
                    button.ForeColor = Color.FromArgb(255, 255, 255);
                    button.Font = new Font("Microsoft Sans Serif", 10);
                    button.Left = left1;
                    button.Top = top1;
                    button.Width = 170;
                    button.Height = 95;
                    tabPageKategorije.Controls.Add(button);
                    button.Controls.Add(dynamicCheckBox);
                    dynamicCheckBox.CheckStateChanged += dynamicCheckBox_CheckStateChanged;
                    if (counter < 3)
                    {
                        left1 += button.Height + 130;
                        left2 += dynamicCheckBox.Height - 15;
                    }
                    counter++;
                    if (counter == 3)
                    {
                        left1 = 5;
                        left2 = 135;
                        top1 += 120;
                        top2 += 0;
                        left1 += button.Height - 95;
                        left2 += dynamicCheckBox.Height;
                        counter = 0;
                    }
                    button.Text = kategorije[i].Description;
                    button.Name = broj.ToString();
                    button.Click += (varijabla, EventArgs) => { btnButton_Click(sender, EventArgs, button.Name); };
                    broj++;
            }
            klikOsvjezi++;
        }
        //mijenja stanje check boxova
        private void dynamicCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            odabraniBoxovi = sviBoxovi.Where(cbx => cbx.Checked).ToList();
            neOdabraniBoxovi = sviBoxovi.Where(cbx => !cbx.Checked).ToList();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (odabraniBoxovi.Count == 0)
            {
                MessageBox.Show("Odaberite kategoriju koju želite spremiti", "Obavijest");
            }
            else
            {
                FormDodavanjeKategorije formaDodajKategoriju = new FormDodavanjeKategorije(odabraniBoxovi, this);
                formaDodajKategoriju.ShowDialog();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormLokacije f3 = new FormLokacije();
            f3.ShowDialog();
        }
        //izvode se radnje na klik gumba
        private void dataGridViewBPCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridViewBPCategory.Rows[e.RowIndex].Selected = true;
            if (dataGridViewBPCategory.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                int IDkategorije = Convert.ToInt32(dataGridViewBPCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormBrisanjeKategorije brisanjeForm = new FormBrisanjeKategorije(IDkategorije, this);
                brisanjeForm.ShowDialog();
            }
            if (dataGridViewBPCategory.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                Category oKategorija = new Category();
                oKategorija.ID = Convert.ToInt32(dataGridViewBPCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
                oKategorija.Description = dataGridViewBPCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                oKategorija.Url= dataGridViewBPCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormAzuriranjeKategorijeBP azuriranjeForm = new FormAzuriranjeKategorijeBP(oKategorija, this);
                azuriranjeForm.ShowDialog();
            }
        }
        //gumb koji oznacava svr check boxove
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (var x in sviBoxovi)
            {
                x.CheckState = (CheckState)1;
            }
            odabraniBoxovi = sviBoxovi;
        }
        //gumb koji odznačava sve gumbove
        private void btnResetChecked_Click(object sender, EventArgs e)
        {
            foreach (CheckBox x in odabraniBoxovi)
            {
                x.CheckState = 0;
            }
        }
        //sortiranje po datumu od A do Ž
        private void btnDatumAZ_Click(object sender, EventArgs e)
        {
            List<Category> SortiraneKategorije = new List<Category>();
            SortiraneKategorije = _MainRepository.GetDBCategories();
            SortiraneKategorije = SortiraneKategorije.OrderBy(i => i.DatumSpremanjaUBazu).ToList();

            _tableBindingSourceBPCategory.DataSource = SortiraneKategorije;
            dataGridViewBPCategory.DataSource = _tableBindingSourceBPCategory;
        }
        //sortiranje po nazivu od A do Ž
        private void btnSortNazivAZ_Click(object sender, EventArgs e)
        {
            List<Category> SortiraneKategorije = new List<Category>();
            SortiraneKategorije = _MainRepository.GetDBCategories();
            SortiraneKategorije = SortiraneKategorije.OrderBy(i => i.Description).ToList();

            _tableBindingSourceBPCategory.DataSource = SortiraneKategorije;
            dataGridViewBPCategory.DataSource = _tableBindingSourceBPCategory;
        }
        //sortiranje po nazivu od Ž do A
        private void btnSortNazivZA_Click(object sender, EventArgs e)
        {
            List<Category> SortiraneKategorije = new List<Category>();
            SortiraneKategorije = _MainRepository.GetDBCategories();
            SortiraneKategorije = SortiraneKategorije.OrderByDescending(i => i.Description).ToList();

            _tableBindingSourceBPCategory.DataSource = SortiraneKategorije;
            dataGridViewBPCategory.DataSource = _tableBindingSourceBPCategory;
        }

        //sortiranje po datumu od Ž do A
        private void btnDatumZA_Click(object sender, EventArgs e)
        {
            List<Category> SortiraneKategorije = new List<Category>();
            SortiraneKategorije = _MainRepository.GetDBCategories();
            SortiraneKategorije = SortiraneKategorije.OrderByDescending(i => i.DatumSpremanjaUBazu).ToList();

            _tableBindingSourceBPCategory.DataSource = SortiraneKategorije;
            dataGridViewBPCategory.DataSource = _tableBindingSourceBPCategory;
        }
        //pretraživanje naziva
        private void btnSearchNaziv_Click(object sender, EventArgs e)
        {
            bool Ispis = true;
            List<Category> kategorije = new List<Category>();
            List<Category> pretrazeneKategorije = new List<Category>();
            kategorije = _MainRepository.GetDBCategories();
            string sNaziv = txtBoxNaziv.Text;
            sNaziv = sNaziv.ToLower();
            pretrazeneKategorije = kategorije.Where(x => x.Description.ToLower().Contains(sNaziv)).ToList();
            if (sNaziv == "")
            {
                MessageBox.Show("Unesite naziv kategorije po kojoj želite pretražiti.", "Greška");
                Ispis = false;
            }
            if (pretrazeneKategorije.Count() == 0)
            {
                Ispis = false;
                MessageBox.Show("Vašem pojmu ne odgovara niti jedan naziv kategorije!", "Obavijest");
            }
            if (Ispis == true)
            {
                _tableBindingSourceBPCategory.DataSource = pretrazeneKategorije;
                dataGridViewBPCategory.DataSource = _tableBindingSourceBPCategory;
            }
        }
        //pretraživanje po datumu
        private void btnSrchDate_Click(object sender, EventArgs e)
        {
            bool Ispis = true;
            List<Category> kategorije = new List<Category>();
            List<Category> pretrazeneKategorije = new List<Category>();
            kategorije = _MainRepository.GetDBCategories();
            string sDatum = datePickerDatum.Text;
            pretrazeneKategorije = kategorije.Where(x => x.DatumSpremanjaUBazu.ToShortDateString() == sDatum).ToList();
            if (pretrazeneKategorije.Count == 0)
            {
                MessageBox.Show("Niti jedan datum ne odgovara vašoj pretrazi.", "Obavijest");
                Ispis = false;
            }
            if (Ispis == true)
            {
                _tableBindingSourceBPCategory.DataSource = pretrazeneKategorije;
                dataGridViewBPCategory.DataSource = _tableBindingSourceBPCategory;
            }
        }
        //resetiranje tablice
        private void btnReset_Click(object sender, EventArgs e)
        {
            List<Category> kategorije = new List<Category>();
            kategorije = _MainRepository.GetDBCategories();
            _tableBindingSourceBPCategory.DataSource = kategorije;
            dataGridViewBPCategory.DataSource = _tableBindingSourceBPCategory;
        }
        //otvaranje tablice nezaposlenih
        private void btnNezaposleni_Click(object sender, EventArgs e)
        {
            FormStatistikaNezaposleni formaStatistika = new FormStatistikaNezaposleni();
            formaStatistika.ShowDialog();
        }
        //otvaranje tablice slobodnih radnih mjesta
        private void btnSlobodnaRadnaMjesta_Click(object sender, EventArgs e)
        {
            FormStatistikaRadnaMjesta formStatistikaPoslovi = new FormStatistikaRadnaMjesta();
            formStatistikaPoslovi.ShowDialog();
        }
        //gumb za osvježavanje statistike
        private void btnOsvjeziStatistiku_Click(object sender, EventArgs e)
        {
            Statistika();
        }
    }
}
