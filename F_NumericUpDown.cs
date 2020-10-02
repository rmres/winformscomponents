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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_define_Click(object sender, EventArgs e)
        {

            try
            {
                numericUpDown1.Value = Convert.ToDecimal(txt_value.Text);
            }
            catch
            {
                //
            }
        }
    }
}
