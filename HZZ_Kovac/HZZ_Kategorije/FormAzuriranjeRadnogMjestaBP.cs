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
    public partial class FormAzuriranjeRadnogMjestaBP : Form
    {
        private RadnaMjesta posao = new RadnaMjesta();
        private MainRepository _jobRepository = new MainRepository();
        private Form posaoForm = new Form();

        public FormAzuriranjeRadnogMjestaBP(RadnaMjesta oPosao,Form Azurirani)
        {
            posao = oPosao;
            posaoForm = Azurirani as FormSlobodnaRadnaMjesta;
            InitializeComponent();
        }

        private void FormAzuriranjeRadnogMjestaBP_Load(object sender, EventArgs e)
        {
            txtBoxID.Text = posao.IdPosao.ToString();
            txtBoxNaziv.Text = posao.NazivPosao;
            richTxtBoxOpis.Text = posao.OpisPosla;
            DateTime datum = DateTime.Now;
            dateTimePickerSpremanja.Value = datum;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            RadnaMjesta objektPosao = new RadnaMjesta();
            objektPosao.IdPosao= Convert.ToInt32(txtBoxID.Text);
            objektPosao.NazivPosao = txtBoxNaziv.Text;
            objektPosao.OpisPosla = richTxtBoxOpis.Text;
            objektPosao.Datum = dateTimePickerSpremanja.Value;
            if (objektPosao.NazivPosao == "" || objektPosao.OpisPosla == "")
            {
                MessageBox.Show("Popunite sva polja kako bi uspješno ažurirali radno mjesto.", "Greška");
            }
            else
            {
                FormPotvrdaRadnogMjesta potvrda = new FormPotvrdaRadnogMjesta(objektPosao, posaoForm);
                potvrda.ShowDialog(this);
            }
        }
    }
}
