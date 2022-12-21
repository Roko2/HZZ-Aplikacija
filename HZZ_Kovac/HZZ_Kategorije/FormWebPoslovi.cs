using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HZZ_Kategorije
{
    public partial class FormWebPoslovi : Form
    {
        private string LinkPosla;
        public FormWebPoslovi(string link)
        {
            LinkPosla = link;
            InitializeComponent();
        }

        private void FormWebPoslovi_Load(object sender, EventArgs e)
        {
            webPoslovi.Navigate(new Uri(LinkPosla));
        }
    }
}
