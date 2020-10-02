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
    public partial class F_Veiculos : Form
    {
        Componente fp;
        public F_Veiculos(string veic, Componente f)
        {
            InitializeComponent();

            txt_listaveic.Text = veic;

            fp = f;
            f.num = 10;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.txt_lista.Text = txt_listaveic.Text ;
        }
    }
}
