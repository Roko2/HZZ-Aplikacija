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
    public partial class FormDodavanjePosla : Form
    {
        private RadnaMjesta odabranaRadnaMjesta=new RadnaMjesta();
        private BindingSource _tableBindingSource = new BindingSource();
        private MainRepository _jobRepository = new MainRepository();
        private Form oPosao = new Form();
        public FormDodavanjePosla(RadnaMjesta radnaMjestaD, Form Dodani)
        {
            odabranaRadnaMjesta=radnaMjestaD;
            oPosao = Dodani as FormSlobodnaRadnaMjesta;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //dodavanje radnog mjesta u bazu i ažuriranje tablice
        private async void button2_Click(object sender, EventArgs e)
        {
            List<RadnaMjesta> lRadnaMjesta = new List<RadnaMjesta>();
            lRadnaMjesta = await _jobRepository.GetDBFreeJobs();
            var postoji = (from x in lRadnaMjesta where x.Link == odabranaRadnaMjesta.Link select x).Any();
            if (postoji == true)
            {
                MessageBox.Show("Odabrali ste već postojeći posao iz baze, ne možete dodati ovaj posao.", "Greška");
            }
            else
            {
                _jobRepository.AddJobToDB(odabranaRadnaMjesta);
                DataGridView tablica = (DataGridView)this.oPosao.Controls[0].Controls[1].Controls[1];
                _tableBindingSource.DataSource = _jobRepository.GetDBFreeJobs();
                tablica.DataSource = _tableBindingSource;
                this.Close();
            }

        }
    }
}
