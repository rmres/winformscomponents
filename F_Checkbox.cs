using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Checkbox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();
        public F_Checkbox()
        {
            InitializeComponent();
            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void btn_checktransp_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (CheckBox i in transp)
            {
                if (i.Checked)
                {
                    txt += i.Text + "\n";
                }
            }
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked == true)
            {
                MessageBox.Show("Patinete como naquele pique");
            }
        }

        private void btn_abrirfilho_Click(object sender, EventArgs e)
        {
            F_Filho f_filho = new F_Filho();

            f_filho.ShowDialog();
        }
    }
}
