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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label2.Text = "";
            
            label1.Text = treeView1.SelectedNode.Text;

            try
            {
                if (treeView1.SelectedNode.Tag != null)
                {
                    label2.Text = treeView1.SelectedNode.Tag.ToString();
                }
            }
            catch
            {
                //
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode raiz = treeView1.Nodes.Add("Raiz");
            raiz.Name = "Raiz";

            TreeNode no = raiz.Nodes.Add("Nó");
            no.Name = "No";
            
        }
    }
}
