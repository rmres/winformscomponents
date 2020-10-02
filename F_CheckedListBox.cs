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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarclbselect_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string i in clb_transp.CheckedItems)
            {
                txt += i + "\n";
            }

            MessageBox.Show(txt);
        }

        private void btn_clbclear_Click(object sender, EventArgs e)
        {
            clb_transp.Items.Clear();
        }

        private void btn_clbreset_Click(object sender, EventArgs e)
        {
            clb_transp.Items.Clear();

            List<string> transportes = new List<string>();

            transportes.Add("Carro");
            transportes.Add("Avião");
            transportes.Add("Navio");
            transportes.Add("Ônibus");
            transportes.Add("Trem");

            clb_transp.Items.AddRange(transportes.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_addtransp.Text != "")
            {
                clb_transp.Items.Add(txt_addtransp.Text);
                txt_addtransp.Clear();
                txt_addtransp.Focus();
            }
        }
    }
}
