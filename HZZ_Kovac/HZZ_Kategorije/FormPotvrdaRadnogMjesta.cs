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
    public partial class FormPotvrdaRadnogMjesta : Form
    {
        private RadnaMjesta objektPosao = new RadnaMjesta();
        private BindingSource _tableBindingSource = new BindingSource();
        private MainRepository _jobRepository = new MainRepository();
        private Form radnoMjestoForm = new Form();

        public FormPotvrdaRadnogMjesta(RadnaMjesta oPosao, Form Azurirani)
        {
            radnoMjestoForm = Azurirani as FormSlobodnaRadnaMjesta;
            objektPosao = oPosao;
            InitializeComponent();
        }

        private void FormPotvrdaRadnogMjesta_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<RadnaMjesta> radnaMjesta = new List<RadnaMjesta>();
            _jobRepository.AzurirajRadnoMjestoBP(objektPosao);
            DataGridView tablica = (DataGridView)this.radnoMjestoForm.Controls[0].Controls[1].Controls[1];
            _tableBindingSource.DataSource = _jobRepository.GetDBFreeJobs();
            tablica.DataSource = _tableBindingSource;
            this.Close();
            ((FormAzuriranjeRadnogMjestaBP)Owner).Close();
        }
    }
}
