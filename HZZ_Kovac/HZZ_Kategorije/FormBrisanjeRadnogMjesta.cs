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
    public partial class FormBrisanjeRadnogMjesta : Form
    {
        private int idPosla;
        private RadnaMjesta odabranaRadnaMjesta = new RadnaMjesta();
        private BindingSource _tableBindingSource = new BindingSource();
        private MainRepository _jobRepository = new MainRepository();
        private Form oPosao = new Form();
        public FormBrisanjeRadnogMjesta(int id,Form obrisani)
        {
            idPosla = id;
            oPosao = obrisani as FormSlobodnaRadnaMjesta;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _jobRepository.DeleteJobFromDB(idPosla);
            DataGridView tablica = (DataGridView)this.oPosao.Controls[0].Controls[1].Controls[1];
            _tableBindingSource.DataSource = _jobRepository.GetDBFreeJobs();
            tablica.DataSource = _tableBindingSource;
            this.Close();
        }
    }
}
