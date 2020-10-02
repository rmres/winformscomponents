namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_getdate = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.btn_setdate = new System.Windows.Forms.Button();
            this.btn_today = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(314, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_getdate
            // 
            this.btn_getdate.Location = new System.Drawing.Point(332, 9);
            this.btn_getdate.Name = "btn_getdate";
            this.btn_getdate.Size = new System.Drawing.Size(176, 23);
            this.btn_getdate.TabIndex = 1;
            this.btn_getdate.Text = "Obter data";
            this.btn_getdate.UseVisualStyleBackColor = true;
            this.btn_getdate.Click += new System.EventHandler(this.btn_getdate_Click);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(12, 39);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(314, 20);
            this.txt_data.TabIndex = 2;
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(12, 65);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(100, 20);
            this.txt_dia.TabIndex = 3;
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(120, 65);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(100, 20);
            this.txt_mes.TabIndex = 4;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(227, 65);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 5;
            // 
            // btn_setdate
            // 
            this.btn_setdate.Location = new System.Drawing.Point(332, 67);
            this.btn_setdate.Name = "btn_setdate";
            this.btn_setdate.Size = new System.Drawing.Size(174, 23);
            this.btn_setdate.TabIndex = 9;
            this.btn_setdate.Text = "Setar data";
            this.btn_setdate.UseVisualStyleBackColor = true;
            this.btn_setdate.Click += new System.EventHandler(this.btn_setdate_Click);
            // 
            // btn_today
            // 
            this.btn_today.Location = new System.Drawing.Point(332, 38);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(174, 23);
            this.btn_today.TabIndex = 10;
            this.btn_today.Text = "Hoje";
            this.btn_today.UseVisualStyleBackColor = true;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 110);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.btn_setdate);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_getdate);
            this.Controls.Add(this.dtp_data);
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_getdate;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Button btn_setdate;
        private System.Windows.Forms.Button btn_today;
    }
}