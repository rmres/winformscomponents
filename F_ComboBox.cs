using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_showselect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_transp.Text);
        }

        private void btn_clearcmb_Click(object sender, EventArgs e)
        {
            cmb_transp.Items.Clear();
        }

        private void btn_resetcmb_Click(object sender, EventArgs e)
        {
            cmb_transp.Items.Add("Carro");
            cmb_transp.Items.Add("Avião");
            cmb_transp.Items.Add("Navio");
            cmb_transp.Items.Add("Ônibus");
            cmb_transp.Items.Add("Trem");
        }

        private void cmb_transp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cmbtransp.Text = cmb_transp.Text;
        }

        private void btn_addelement_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_cmbtransp.Text))
            {
                if (cmb_transp.FindString(txt_cmbtransp.Text) < 0)
                {
                    cmb_transp.Items.Add(txt_cmbtransp.Text);
                }
            }
        }
    }
}
