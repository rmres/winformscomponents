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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {

            if (txt_id.Text != "" && txt_product.Text != "" && txt_qtd.Text != "" && txt_preco.Text != "")
            {
                string[] prod = new string[4];
                prod[0] = txt_id.Text;
                prod[1] = txt_product.Text;
                prod[2] = txt_qtd.Text;
                prod[3] = txt_preco.Text;

                ListViewItem newprod = new ListViewItem(prod);

                lv_products.Items.Add(newprod);

                ClearFields();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }

        private void ClearFields()
        {
            txt_id.Clear();
            txt_preco.Clear();
            txt_product.Clear();
            txt_qtd.Clear();

            txt_id.Focus();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                lv_products.Items.RemoveAt(lv_products.SelectedIndices[0]);
            }
            catch
            {
                //
            }
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                txt_id.Text = lv_products.SelectedItems[0].SubItems[0].Text;
                txt_product.Text = lv_products.SelectedItems[0].SubItems[1].Text;
                txt_qtd.Text = lv_products.SelectedItems[0].SubItems[2].Text;
                txt_preco.Text = lv_products.SelectedItems[0].SubItems[3].Text;
            }
            catch
            {
                //
            }
        }

        private void lv_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0) {
                lb_id.Text = lv_products.SelectedItems[0].SubItems[0].Text;
                lb_produto.Text = lv_products.SelectedItems[0].SubItems[1].Text;
                lb_quantidade.Text = lv_products.SelectedItems[0].SubItems[2].Text;
                lb_preco.Text = lv_products.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
