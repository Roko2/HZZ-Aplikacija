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
    public partial class FormSlobodnaRadnaMjesta : Form
    {
        private string url;
        private BindingSource _tableBindingSource = new BindingSource();
        private MainRepository _itemRepository = new MainRepository();
        private BindingSource _tableBindingSourceBPRadnaMjesta = new BindingSource();
        
        public FormSlobodnaRadnaMjesta(string URL)
        {
            InitializeComponent();
            url = URL;
            //// _itemRepository.AddCategory(_itemRepository.GetCategories());
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
        private void FormKategorije_Load(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.FromArgb(41, 161, 211);
            DataGridViewImageColumn buttonDodaj = new DataGridViewImageColumn();
            buttonDodaj.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\.NET_Projekt_Kovac\HZZ_Kovac\Slike\plus.png");
            buttonDodaj.Width = 20;
            buttonDodaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFreeJobs.Columns.Add(buttonDodaj);
            dataGridViewFreeJobs.AutoGenerateColumns = false;

            DataGridViewImageColumn buttonObrisi = new DataGridViewImageColumn();
            buttonObrisi.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\.NET_Projekt_Kovac\HZZ_Kovac\Slike\bin.png");
            buttonObrisi.Width = 20;
            buttonObrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRadnaMjestaBP.Columns.Add(buttonObrisi);
            dataGridViewRadnaMjestaBP.AutoGenerateColumns = false;

            dataGridViewFreeJobs.DataSource = _tableBindingSource;
            dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void btnAZ_Click(object sender, EventArgs e,string URL)
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
                SortiraneKategorijeBP = _itemRepository.GetDBFreeJobs();
                SortiraneKategorijeBP = SortiraneKategorijeBP.OrderBy(i => i.NazivPosao).ToList();

                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private void btnZA_Click(object sender, EventArgs e, string URL)
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
                SortiraneKategorijeBP = _itemRepository.GetDBFreeJobs();
                SortiraneKategorijeBP = SortiraneKategorijeBP.OrderByDescending(i => i.NazivPosao).ToList();

                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e, string URL)
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
                SortiraneKategorijeBP = _itemRepository.GetDBFreeJobs();
                SortiraneKategorijeBP = SortiraneKategorijeBP.OrderBy(i => i.Datum).ToList();

                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private void button3_Click(object sender, EventArgs e,string URL)
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
                SortiraneKategorijeBP = _itemRepository.GetDBFreeJobs();
                SortiraneKategorijeBP = SortiraneKategorijeBP.OrderByDescending(i => i.Datum).ToList();

                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private void button1_Click(object sender, EventArgs e,string URL)
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
                SortiraneKategorijeBP = _itemRepository.GetDBFreeJobs();
                _tableBindingSourceBPRadnaMjesta.DataSource = SortiraneKategorijeBP;
                dataGridViewRadnaMjestaBP.DataSource = _tableBindingSourceBPRadnaMjesta;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e,string URL)
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
                radnaMjestaBP = _itemRepository.GetDBFreeJobs();
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
                if (dataGridViewFreeJobs.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
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
                            FormDodavanjePosla dodavanjeForm = new FormDodavanjePosla(objekt, this);
                            dodavanjeForm.ShowDialog();
                        }
                    }

                }
            }
        }

        private void buttonSrchDate_Click(object sender, EventArgs e,string URL)
        {
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage1) {
                bool Ispis = true;
                List<RadnaMjesta> radnaMjesta = new List<RadnaMjesta>();
                List<RadnaMjesta> pretrazenaRadnaMjesta = new List<RadnaMjesta>();
                radnaMjesta = _itemRepository.GetRadnaMjestaKategorije(URL);
                string sDatum = dateTimePicker1.Text;
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
                radnaMjestaBP = _itemRepository.GetDBFreeJobs();
                string sDatumBP = dateTimePicker1.Text;
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
        private void dataGridViewRadnaMjestaBP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (tabControlSlobodnaRadnaMjesta.SelectedTab == tabPage2)
            {
                dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Selected = true;
                if (dataGridViewRadnaMjestaBP.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
                {
                    int IDkategorije = Convert.ToInt32(dataGridViewRadnaMjestaBP.Rows[e.RowIndex].Cells[0].Value.ToString());
                    FormBrisanjeRadnogMjesta brisanjeForm = new FormBrisanjeRadnogMjesta(IDkategorije, this);
                    brisanjeForm.Show();
                }
            }
        }
    }
}

