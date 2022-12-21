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
    public partial class FormSlobodnaRadnaMjesta : Form
    {
        private string url;
        private BindingSource _tableBindingSource = new BindingSource();
        private MainRepository _itemRepository = new MainRepository();
        private BindingSource _tableBindingSourceBPRadnaMjesta = new BindingSource();
        //slanje u urla u funkcije za CRUD i popunjavanje tablica
        public FormSlobodnaRadnaMjesta(string URL)
        {
            InitializeComponent();
            url = URL;
            btnAZ.Click += (sender, EventArgs) => { btnAZ_Click(sender, EventArgs, URL); };
            btnZA.Click += (sender, EventArgs) => { btnZA_Click(sender, EventArgs, URL); };
            button2.Click += (sender, EventArgs) => { button2_Click(sender, EventArgs, URL); };
            button3.Click += (sender, EventArgs) => { button3_Click(sender, EventArgs, URL); };
            button1.Click += (sender, EventArgs) => { button1_Click(sender, EventArgs, URL); };
            btnSearch.Click += (sender, EventArgs) => { btnSearch_Click(sender, EventArgs, URL); };
            button4.Click += (sender, EventArgs) => { button4_Click(sender, EventArgs, URL); };
            buttonSrchDate.Click += (sender, EventArgs) => { buttonSrchDate_Click(sender, EventArgs, URL); };

            _tableBindingSource.DataSource = _itemRepository.GetRadnaMjestaKategorije(URL);
            _tableBindingSourceBPRadnaMjesta.DataSource = _itemRepository.GetDBFreeJobs();
        }
        //učitavanje ikonica za ažuriranje,brisanje i dodavanje te 
        private void FormKategorije_Load(object sender, EventArgs e)
        {
            panelOpis.Hide();
            panelBPOpis.Hide();
            dataGridViewFreeJobs.ShowCellToolTips = true;
            DateTime datum = DateTime.Now;
            dateTimePickerDate.MaxDate = datum;
            btnReturn.BackColor = Color.FromArgb(41, 161, 211);
            DataGridViewImageColumn buttonDodaj = new DataGridViewImageColumn();
            var path3 = new DirectoryInfo(Application.StartupPath).Parent.Parent.Parent.FullName;
            buttonDodaj.Image = Image.FromFile(path3+ @"\Slike\plus.png");
            buttonDodaj.Width = 20;
            buttonDodaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFreeJobs.Columns.Add(buttonDodaj);
            dataGridViewFreeJobs.AutoGenerateColumns = false;

            DataGridViewImageColumn buttonObrisi = new DataGridViewImageColumn();
            var path4 = new DirectoryInfo(Application.StartupPath).Parent.Parent.Parent.FullName;
            buttonObrisi.Image = Image.FromFile(path4 + @"\Slike\bin.png");
            buttonObrisi.Width = 20;
            buttonObrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRadnaMjestaBP.Columns.Add(buttonObrisi);

            DataGridViewImageColumn buttonAzuriraj = new DataGridViewImageColumn();
            var path5 = new DirectoryInfo(Application.StartupPath).Parent.Parent.Parent.FullName;
            buttonAzuriraj.Image = Image.FromFile(path5 + @"\Slike\updateNew.png");
            buttonAzuriraj.Width = 20;
            buttonAzuriraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRadnaMjestaBP.Columns.Add(buttonAzuriraj);
            dataGridViewRadnaMjestaBP.AutoGenerateColumns = false;

            dataGridViewFreeJobs.DataSource = _tableBindingSource;
            dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private async void btnAZ_Click(object sender, EventArgs e,string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1)
            {
                List<RadnaMjesta> SortiraneKategorije = new List<RadnaMjesta>();
                SortiraneKategorije = _itemRepository.GetRadnaMjestaKategorije(URL);
                SortiraneKategorije = SortiraneKategorije.OrderBy(i => i.NazivPosao).ToList();

                _tableBindingSource.DataSource = SortiraneKategorije;
                dataGridViewFreeJobs.DataSource = _tableBindingSource;
            }
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                List<RadnaMjesta> SortiraneKategorijeBP = new List<RadnaMjesta>();
                SortiraneKategorijeBP = await _itemRepository.GetDBFreeJobs();
                SortiraneKategorijeBP = SortiraneKategorijeBP.OrderBy(i => i.NazivPosao).ToList();

                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private async void btnZA_Click(object sender, EventArgs e, string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1) 
            { 
                List<RadnaMjesta> SortiraneKategorije = new List<RadnaMjesta>();
                SortiraneKategorije = _itemRepository.GetRadnaMjestaKategorije(URL);
                SortiraneKategorije = SortiraneKategorije.OrderByDescending(i => i.NazivPosao).ToList();

                _tableBindingSource.DataSource = SortiraneKategorije;
                dataGridViewFreeJobs.DataSource = _tableBindingSource;
             }
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                List<RadnaMjesta> SortiraneKategorijeBP = new List<RadnaMjesta>();
                SortiraneKategorijeBP = await _itemRepository.GetDBFreeJobs();
                SortiraneKategorijeBP = SortiraneKategorijeBP.OrderByDescending(i => i.NazivPosao).ToList();

                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button2_Click(object sender, EventArgs e, string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1)
            {
                List<RadnaMjesta> SortiraneKategorije = new List<RadnaMjesta>();
                SortiraneKategorije = _itemRepository.GetRadnaMjestaKategorije(URL);
                SortiraneKategorije = SortiraneKategorije.OrderBy(i => i.Datum).ToList();

                _tableBindingSource.DataSource = SortiraneKategorije;
                dataGridViewFreeJobs.DataSource = _tableBindingSource;
            }
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                List<RadnaMjesta> SortiraneKategorijeBP = new List<RadnaMjesta>();
                SortiraneKategorijeBP = await _itemRepository.GetDBFreeJobs();
                SortiraneKategorijeBP = SortiraneKategorijeBP.OrderBy(i => i.Datum).ToList();

                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private async void button3_Click(object sender, EventArgs e,string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1)
            {
                List<RadnaMjesta> SortiraneKategorije = new List<RadnaMjesta>();
                SortiraneKategorije = _itemRepository.GetRadnaMjestaKategorije(URL);
                SortiraneKategorije = SortiraneKategorije.OrderByDescending(i => i.Datum).ToList();

                _tableBindingSource.DataSource = SortiraneKategorije;
                dataGridViewFreeJobs.DataSource = _tableBindingSource;
            }
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                List<RadnaMjesta> SortiraneKategorijeBP = new List<RadnaMjesta>();
                SortiraneKategorijeBP = await _itemRepository.GetDBFreeJobs();
                SortiraneKategorijeBP = SortiraneKategorijeBP.OrderByDescending(i => i.Datum).ToList();

                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private async void button1_Click(object sender, EventArgs e,string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1)
            {
                List<RadnaMjesta> SortiraneKategorije = new List<RadnaMjesta>();
                SortiraneKategorije = _itemRepository.GetRadnaMjestaKategorije(URL);
                _tableBindingSource.DataSource = SortiraneKategorije;
                dataGridViewFreeJobs.DataSource = _tableBindingSource;
            }
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {

                List<RadnaMjesta> SortiraneKategorijeBP = new List<RadnaMjesta>();
                SortiraneKategorijeBP = await _itemRepository.GetDBFreeJobs();
                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e,string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1)
            {
                bool Ispis = true;
                List<RadnaMjesta> radnaMjesta = new List<RadnaMjesta>();
                List<RadnaMjesta> pretrazenaRadnaMjesta = new List<RadnaMjesta>();
                radnaMjesta = _itemRepository.GetRadnaMjestaKategorije(URL);
                string sNaziv = inptNaziv.Text;
                sNaziv = sNaziv.ToLower();
                pretrazenaRadnaMjesta = radnaMjesta.Where(x => x.NazivPosao.ToLower().Contains(sNaziv)).ToList();
                if (sNaziv == "")
                {
                    MessageBox.Show("Unesite naziv posla po kojemu želite pretražiti.", "Greška");
                    Ispis = false;
                }
                if (pretrazenaRadnaMjesta.Count() == 0)
                {
                    Ispis = false;
                    MessageBox.Show("Vašem pojmu ne odgovara niti jedan naziv posla!", "Obavijest");
                }
                if (Ispis == true)
                {
                    _tableBindingSource.DataSource = pretrazenaRadnaMjesta;
                    dataGridViewFreeJobs.DataSource = _tableBindingSource;
                }
            }
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                bool IspisBP = true;
                List<RadnaMjesta> radnaMjestaBP = new List<RadnaMjesta>();
                List<RadnaMjesta> pretrazenaRadnaMjestaBP = new List<RadnaMjesta>();
                radnaMjestaBP = await _itemRepository.GetDBFreeJobs();
                string sNazivBP = inptNaziv.Text;
                sNazivBP = sNazivBP.ToLower();
                pretrazenaRadnaMjestaBP = radnaMjestaBP.Where(x => x.NazivPosao.ToLower().Contains(sNazivBP)).ToList();
                if (sNazivBP == "")
                {
                    MessageBox.Show("Unesite naziv posla po kojemu želite pretražiti.", "Greška");
                    IspisBP = false;
                }
                if (pretrazenaRadnaMjestaBP.Count() == 0)
                {
                    IspisBP = false;
                    MessageBox.Show("Vašem pojmu ne odgovara niti jedan naziv posla!", "Obavijest");
                }
                if (IspisBP == true)
                {
                    _tableBindingSourceBPRadnaMjesta.DataSource = pretrazenaRadnaMjestaBP;
                    dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
                }
            }     
        }
        private void button4_Click(object sender, EventArgs e,string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1)
            {
                bool Ispis = true;
                List<RadnaMjesta> radnaMjesta = new List<RadnaMjesta>();
                List<RadnaMjesta> pretrazenaRadnaMjesta = new List<RadnaMjesta>();
                radnaMjesta = _itemRepository.GetRadnaMjestaKategorije(URL);
                string sOpis = inptOpis.Text;
                sOpis = sOpis.ToLower();
                pretrazenaRadnaMjesta = radnaMjesta.Where(x => x.OpisPosla.ToLower().Contains(sOpis)).ToList();
                if (sOpis == "")
                {
                    MessageBox.Show("Unesite opis posla po kojemu želite pretražiti.", "Greška");
                    Ispis = false;
                }
                if (pretrazenaRadnaMjesta.Count() == 0)
                {
                    Ispis = false;
                    MessageBox.Show("Vašem pojmu ne odgovara niti jedan opis posla!", "Obavijest");
                }
                if (Ispis == true)
                {
                    _tableBindingSource.DataSource = pretrazenaRadnaMjesta;
                    dataGridViewFreeJobs.DataSource = _tableBindingSource;
                }
            }
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                bool IspisBP = true;
                List<RadnaMjesta> radnaMjestaBP = new List<RadnaMjesta>();
                List<RadnaMjesta> pretrazenaRadnaMjestaBP = new List<RadnaMjesta>();
                radnaMjestaBP = _itemRepository.GetRadnaMjestaKategorije(URL);
                string sOpisBP = inptOpis.Text;
                sOpisBP = sOpisBP.ToLower();
                pretrazenaRadnaMjestaBP = radnaMjestaBP.Where(x => x.OpisPosla.ToLower().Contains(sOpisBP)).ToList();
                if (sOpisBP == "")
                {
                    MessageBox.Show("Unesite opis posla po kojemu želite pretražiti.", "Greška");
                    IspisBP = false;
                }
                if (pretrazenaRadnaMjestaBP.Count() == 0)
                {
                    IspisBP = false;
                    MessageBox.Show("Vašem pojmu ne odgovara niti jedan opis posla!", "Obavijest");
                }
                if (IspisBP == true)
                {
                    _tableBindingSourceBPRadnaMjesta.DataSource = pretrazenaRadnaMjestaBP;
                    dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
                }
            }
        }

        private void dataGridViewFreeJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1)
            {
                RadnaMjesta objekt = new RadnaMjesta();
                dataGridViewFreeJobs.Rows[e.RowIndex].Selected = true;
                if (dataGridViewFreeJobs.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
                {
                    int IDPosla = Convert.ToInt32(dataGridViewFreeJobs.Rows[e.RowIndex].Cells[0].Value.ToString());
                    List<RadnaMjesta> lRadnaMjesta = new List<RadnaMjesta>();
                    lRadnaMjesta = _itemRepository.GetRadnaMjestaKategorije(url);
                    foreach (RadnaMjesta x in lRadnaMjesta)
                    {
                        if (x.IdPosao == IDPosla)
                        {
                            objekt.IdPosao = x.IdPosao;
                            objekt.NazivPosao = x.NazivPosao;
                            objekt.Datum = x.Datum;
                            objekt.OpisPosla = x.OpisPosla;
                            objekt.Link = x.Link;
                            FormDodavanjePosla dodavanjeForm = new FormDodavanjePosla(objekt, this);
                            dodavanjeForm.ShowDialog();
                        }
                    }

                }
                if (dataGridViewFreeJobs.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
                {
                    string OpisPosla = dataGridViewFreeJobs.Rows[e.RowIndex].Cells[2].Value.ToString();
                    richTextBoxOpis.Text = OpisPosla;
                    panelOpis.Show();
                }
                if (dataGridViewFreeJobs.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                {
                    string LinkPosla = dataGridViewFreeJobs.Rows[e.RowIndex].Cells[3].Value.ToString();
                    FormWebPoslovi formaWeb = new FormWebPoslovi(LinkPosla);
                    formaWeb.ShowDialog();
                }
            }
        }

        private async void buttonSrchDate_Click(object sender, EventArgs e, string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1)
            {
                bool Ispis = true;
                List<RadnaMjesta> radnaMjesta = new List<RadnaMjesta>();
                List<RadnaMjesta> pretrazenaRadnaMjesta = new List<RadnaMjesta>();
                radnaMjesta = _itemRepository.GetRadnaMjestaKategorije(URL);
                string sDatum = dateTimePickerDate.Text;
                pretrazenaRadnaMjesta = radnaMjesta.Where(x => x.Datum.ToShortDateString() == sDatum).ToList();
                if (pretrazenaRadnaMjesta.Count == 0)
                {
                    MessageBox.Show("Niti jedan datum ne odgovara vašoj pretrazi.", "Obavijest");
                    Ispis = false;
                }
                if (Ispis == true)
                {
                    _tableBindingSource.DataSource = pretrazenaRadnaMjesta;
                    dataGridViewFreeJobs.DataSource = _tableBindingSource;
                }
            }
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                bool IspisBP = true;
                List<RadnaMjesta> radnaMjestaBP = new List<RadnaMjesta>();
                List<RadnaMjesta> pretrazenaRadnaMjestaBP = new List<RadnaMjesta>();
                radnaMjestaBP = await _itemRepository.GetDBFreeJobs();
                string sDatumBP = dateTimePickerDate.Text;
                pretrazenaRadnaMjestaBP = radnaMjestaBP.Where(x => x.Datum.ToShortDateString() == sDatumBP).ToList();
                if (pretrazenaRadnaMjestaBP.Count == 0)
                {
                    MessageBox.Show("Niti jedan datum ne odgovara vašoj pretrazi.", "Obavijest");
                    IspisBP = false;
                }
                if (IspisBP == true)
                {
                    _tableBindingSourceBPRadnaMjesta.DataSource = pretrazenaRadnaMjestaBP;
                    dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
                }
            }

        }
        //definiranje akcije gumbova za brisanje, azuiranje i odlazak na link radno mjesta, tj. baze podataka
        private void dataGridViewRadnaMjestaBP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Selected = true;
                if (dataGridViewRadnaMjestaBP.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
                {
                    int IDRadnogMjesta = Convert.ToInt32(dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Cells[0].Value.ToString());
                    FormBrisanjeRadnogMjesta brisanjeForm = new FormBrisanjeRadnogMjesta(IDRadnogMjesta, this);
                    brisanjeForm.ShowDialog();
                }
                if (dataGridViewRadnaMjestaBP.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
                {
                    string opisPosla =dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Cells[2].Value.ToString();
                    richTextBoxBPOpis.Text = opisPosla;
                    panelBPOpis.Show();
                }
                if (dataGridViewRadnaMjestaBP.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
                {
                    RadnaMjesta oRadnoMjesto = new RadnaMjesta();
                    oRadnoMjesto.IdPosao = Convert.ToInt32(dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Cells[0].Value.ToString());
                    oRadnoMjesto.NazivPosao =dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Cells[1].Value.ToString();
                    oRadnoMjesto.OpisPosla = dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Cells[2].Value.ToString();
                    oRadnoMjesto.Link = dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Cells[3].Value.ToString();
                    FormAzuriranjeRadnogMjestaBP azuriranjeRadnogMjesta = new FormAzuriranjeRadnogMjestaBP(oRadnoMjesto, this);
                    azuriranjeRadnogMjesta.ShowDialog();
                }
                if (dataGridViewRadnaMjestaBP.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                {
                    string LinkPosla = dataGridViewFreeJobs.Rows[e.RowIndex].Cells[3].Value.ToString();
                    FormWebPoslovi formaWeb = new FormWebPoslovi(LinkPosla);
                    formaWeb.ShowDialog();
                }
            }
        }

        private void buttonReturnPanel_Click(object sender, EventArgs e)
        {
            panelOpis.Hide();
        }

        private void btnReturnBPPanel_Click(object sender, EventArgs e)
        {
            panelBPOpis.Hide();
        }
    }
}

