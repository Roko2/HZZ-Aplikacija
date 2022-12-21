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
    public partial class FormStatistikaNezaposleni : Form
    {
        public FormStatistikaNezaposleni()
        {
            InitializeComponent();
        }
        private void buttonReturnPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
