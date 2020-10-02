namespace Componentes
{
    partial class F_CheckedListBox
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
            this.clb_transp = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarclbselect = new System.Windows.Forms.Button();
            this.btn_clbclear = new System.Windows.Forms.Button();
            this.btn_clbreset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_addtransp = new System.Windows.Forms.TextBox();
            this.lb_addtransp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transp
            // 
            this.clb_transp.FormattingEnabled = true;
            this.clb_transp.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transp.Location = new System.Drawing.Point(12, 12);
            this.clb_transp.Name = "clb_transp";
            this.clb_transp.Size = new System.Drawing.Size(120, 184);
            this.clb_transp.TabIndex = 0;
            // 
            // btn_mostrarclbselect
            // 
            this.btn_mostrarclbselect.Location = new System.Drawing.Point(138, 12);
            this.btn_mostrarclbselect.Name = "btn_mostrarclbselect";
            this.btn_mostrarclbselect.Size = new System.Drawing.Size(120, 23);
            this.btn_mostrarclbselect.TabIndex = 1;
            this.btn_mostrarclbselect.Text = "Mostrar selecionados";
            this.btn_mostrarclbselect.UseVisualStyleBackColor = true;
            this.btn_mostrarclbselect.Click += new System.EventHandler(this.btn_mostrarclbselect_Click);
            // 
            // btn_clbclear
            // 
            this.btn_clbclear.Location = new System.Drawing.Point(138, 42);
            this.btn_clbclear.Name = "btn_clbclear";
            this.btn_clbclear.Size = new System.Drawing.Size(120, 23);
            this.btn_clbclear.TabIndex = 2;
            this.btn_clbclear.Text = "Limpar";
            this.btn_clbclear.UseVisualStyleBackColor = true;
            this.btn_clbclear.Click += new System.EventHandler(this.btn_clbclear_Click);
            // 
            // btn_clbreset
            // 
            this.btn_clbreset.Location = new System.Drawing.Point(138, 72);
            this.btn_clbreset.Name = "btn_clbreset";
            this.btn_clbreset.Size = new System.Drawing.Size(120, 23);
            this.btn_clbreset.TabIndex = 3;
            this.btn_clbreset.Text = "Resetar lista";
            this.btn_clbreset.UseVisualStyleBackColor = true;
            this.btn_clbreset.Click += new System.EventHandler(this.btn_clbreset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar transporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_addtransp
            // 
            this.txt_addtransp.Location = new System.Drawing.Point(151, 147);
            this.txt_addtransp.Name = "txt_addtransp";
            this.txt_addtransp.Size = new System.Drawing.Size(118, 20);
            this.txt_addtransp.TabIndex = 5;
            // 
            // lb_addtransp
            // 
            this.lb_addtransp.AutoSize = true;
            this.lb_addtransp.Location = new System.Drawing.Point(138, 131);
            this.lb_addtransp.Name = "lb_addtransp";
            this.lb_addtransp.Size = new System.Drawing.Size(131, 13);
            this.lb_addtransp.TabIndex = 6;
            this.lb_addtransp.Text = "Digite um novo transporte:";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 222);
            this.Controls.Add(this.lb_addtransp);
            this.Controls.Add(this.txt_addtransp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clbreset);
            this.Controls.Add(this.btn_clbclear);
            this.Controls.Add(this.btn_mostrarclbselect);
            this.Controls.Add(this.clb_transp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transp;
        private System.Windows.Forms.Button btn_mostrarclbselect;
        private System.Windows.Forms.Button btn_clbclear;
        private System.Windows.Forms.Button btn_clbreset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_addtransp;
        private System.Windows.Forms.Label lb_addtransp;
    }
}