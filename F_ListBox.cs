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
    public partial class F_ListBox : Form
    {

        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("Centra");
            carros.Add("CRV");
            carros.Add("Palio Fire");

            lsbx_carros.DataSource = carros;

            lsbx_carros.ClearSelected();
        }

        private void lsbx_carros_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_selected.Text = lsbx_carros.Text;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_carro.Text == "")
            {
                MessageBox.Show("Digite algo.");
            }
            else
            {
                if (lsbx_carros.FindString(txt_carro.Text) < 0) {
                    carros.Add(txt_carro.Text);

                    UpdateListBox();

                    txt_carro.Clear();
                    txt_carro.Focus();
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                carros.RemoveAt(lsbx_carros.SelectedIndex);

                UpdateListBox();
            }
            catch
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

        private void UpdateListBox()
        {
            lsbx_carros.DataSource = null;
            lsbx_carros.DataSource = carros;
        }
    }
}
