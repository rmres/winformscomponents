namespace Componentes
{
    partial class F_LinkLabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.llb_yt = new System.Windows.Forms.LinkLabel();
            this.llb_calc = new System.Windows.Forms.LinkLabel();
            this.llb_multiplos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite algo";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(13, 30);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(219, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // llb_yt
            // 
            this.llb_yt.AutoSize = true;
            this.llb_yt.Location = new System.Drawing.Point(15, 82);
            this.llb_yt.Name = "llb_yt";
            this.llb_yt.Size = new System.Drawing.Size(47, 13);
            this.llb_yt.TabIndex = 2;
            this.llb_yt.TabStop = true;
            this.llb_yt.Text = "Youtube";
            this.llb_yt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_yt_LinkClicked);
            // 
            // llb_calc
            // 
            this.llb_calc.AutoSize = true;
            this.llb_calc.Location = new System.Drawing.Point(77, 82);
            this.llb_calc.Name = "llb_calc";
            this.llb_calc.Size = new System.Drawing.Size(63, 13);
            this.llb_calc.TabIndex = 3;
            this.llb_calc.TabStop = true;
            this.llb_calc.Text = "Calculadora";
            this.llb_calc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_calc_LinkClicked);
            // 
            // llb_multiplos
            // 
            this.llb_multiplos.AutoSize = true;
            this.llb_multiplos.Location = new System.Drawing.Point(15, 108);
            this.llb_multiplos.Name = "llb_multiplos";
            this.llb_multiplos.Size = new System.Drawing.Size(131, 13);
            this.llb_multiplos.TabIndex = 4;
            this.llb_multiplos.TabStop = true;
            this.llb_multiplos.Text = "Google - Youtube - Twitter";
            this.llb_multiplos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_multiplos_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 137);
            this.Controls.Add(this.llb_multiplos);
            this.Controls.Add(this.llb_calc);
            this.Controls.Add(this.llb_yt);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.LinkLabel llb_yt;
        private System.Windows.Forms.LinkLabel llb_calc;
        private System.Windows.Forms.LinkLabel llb_multiplos;
    }
}