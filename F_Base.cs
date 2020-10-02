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
    public partial class Componente : Form
    {

        public int num;
        public Componente()
        {
            InitializeComponent();

            txt_lista.ReadOnly = true;
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_adicionar.Text == "")
            {
                MessageBox.Show("Digite algo!");
                txt_adicionar.Focus();
                return;
            }
            txt_lista.Text += txt_adicionar.Text + ", ";
            //txt_lista.Text = txt_lista.Text + txt_adicionar.Text;

            txt_adicionar.Clear();
            txt_adicionar.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_lista.Clear();
            txt_adicionar.Clear();
            txt_adicionar.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(txt_lista.Text, this);
            f_Veiculos.ShowDialog();
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Checkbox f_Checkbox = new F_Checkbox();

            f_Checkbox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();

            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();

            f_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();

            f_DateTimePicker.ShowDialog();
        }

        private void linkedLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();

            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();

            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();

            f_ListView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();

            f_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();

            f_MonthCalendar.ShowDialog();
        }

        private void MenuICO_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tsm_close")
            {
                this.Close(); 
            }
            else if (e.ClickedItem.Name == "tsm_restore")
            {
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
            }
            else if (e.ClickedItem.Name == "tsm_message")
            {
                MessageBox.Show("haha");
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();

            f_NumericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox = new F_PictureBox();
            
            f_PictureBox.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_ProgressBar = new F_ProgressBar();

            f_ProgressBar.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_RadioButton f_RadioButton = new F_RadioButton();

            f_RadioButton.ShowDialog();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TrackBar f_TrackBar = new F_TrackBar();

            f_TrackBar.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TreeView f_TreeView = new F_TreeView();

            f_TreeView.ShowDialog();
        }
    }
}