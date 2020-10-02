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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void btn_define_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_value.Text) >= trackBar1.Minimum && Convert.ToInt32(txt_value.Text) <= trackBar1.Maximum)
                {
                    trackBar1.Value = Convert.ToInt32(txt_value.Text);
                    label1.Text = trackBar1.Value.ToString();
                }
            }
            catch
            {
                // something
            }
        }
    }
}
