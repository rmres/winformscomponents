namespace Componentes
{
    partial class F_ComboBox
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
            this.btn_showselect = new System.Windows.Forms.Button();
            this.cmb_transp = new System.Windows.Forms.ComboBox();
            this.btn_clearcmb = new System.Windows.Forms.Button();
            this.btn_resetcmb = new System.Windows.Forms.Button();
            this.btn_addelement = new System.Windows.Forms.Button();
            this.txt_cmbtransp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_showselect
            // 
            this.btn_showselect.Location = new System.Drawing.Point(174, 12);
            this.btn_showselect.Name = "btn_showselect";
            this.btn_showselect.Size = new System.Drawing.Size(156, 23);
            this.btn_showselect.TabIndex = 0;
            this.btn_showselect.Text = "Mostrar selecionado";
            this.btn_showselect.UseVisualStyleBackColor = true;
            this.btn_showselect.Click += new System.EventHandler(this.btn_showselect_Click);
            // 
            // cmb_transp
            // 
            this.cmb_transp.FormattingEnabled = true;
            this.cmb_transp.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cmb_transp.Location = new System.Drawing.Point(12, 12);
            this.cmb_transp.Name = "cmb_transp";
            this.cmb_transp.Size = new System.Drawing.Size(156, 21);
            this.cmb_transp.TabIndex = 1;
            this.cmb_transp.SelectedIndexChanged += new System.EventHandler(this.cmb_transp_SelectedIndexChanged);
            // 
            // btn_clearcmb
            // 
            this.btn_clearcmb.Location = new System.Drawing.Point(174, 42);
            this.btn_clearcmb.Name = "btn_clearcmb";
            this.btn_clearcmb.Size = new System.Drawing.Size(156, 23);
            this.btn_clearcmb.TabIndex = 2;
            this.btn_clearcmb.Text = "Limpar";
            this.btn_clearcmb.UseVisualStyleBackColor = true;
            this.btn_clearcmb.Click += new System.EventHandler(this.btn_clearcmb_Click);
            // 
            // btn_resetcmb
            // 
            this.btn_resetcmb.Location = new System.Drawing.Point(174, 71);
            this.btn_resetcmb.Name = "btn_resetcmb";
            this.btn_resetcmb.Size = new System.Drawing.Size(156, 23);
            this.btn_resetcmb.TabIndex = 3;
            this.btn_resetcmb.Text = "Resetar";
            this.btn_resetcmb.UseVisualStyleBackColor = true;
            this.btn_resetcmb.Click += new System.EventHandler(this.btn_resetcmb_Click);
            // 
            // btn_addelement
            // 
            this.btn_addelement.Location = new System.Drawing.Point(174, 164);
            this.btn_addelement.Name = "btn_addelement";
            this.btn_addelement.Size = new System.Drawing.Size(156, 23);
            this.btn_addelement.TabIndex = 4;
            this.btn_addelement.Text = "Adicionar";
            this.btn_addelement.UseVisualStyleBackColor = true;
            this.btn_addelement.Click += new System.EventHandler(this.btn_addelement_Click);
            // 
            // txt_cmbtransp
            // 
            this.txt_cmbtransp.Location = new System.Drawing.Point(174, 138);
            this.txt_cmbtransp.Name = "txt_cmbtransp";
            this.txt_cmbtransp.Size = new System.Drawing.Size(156, 20);
            this.txt_cmbtransp.TabIndex = 5;
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 201);
            this.Controls.Add(this.txt_cmbtransp);
            this.Controls.Add(this.btn_addelement);
            this.Controls.Add(this.btn_resetcmb);
            this.Controls.Add(this.btn_clearcmb);
            this.Controls.Add(this.cmb_transp);
            this.Controls.Add(this.btn_showselect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showselect;
        private System.Windows.Forms.ComboBox cmb_transp;
        private System.Windows.Forms.Button btn_clearcmb;
        private System.Windows.Forms.Button btn_resetcmb;
        private System.Windows.Forms.Button btn_addelement;
        private System.Windows.Forms.TextBox txt_cmbtransp;
    }
}