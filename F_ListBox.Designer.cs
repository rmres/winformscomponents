namespace Componentes
{
    partial class F_ListBox
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
            this.lsbx_carros = new System.Windows.Forms.ListBox();
            this.txt_carro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.lb_selected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbx_carros
            // 
            this.lsbx_carros.FormattingEnabled = true;
            this.lsbx_carros.Location = new System.Drawing.Point(12, 12);
            this.lsbx_carros.Name = "lsbx_carros";
            this.lsbx_carros.Size = new System.Drawing.Size(120, 212);
            this.lsbx_carros.TabIndex = 0;
            this.lsbx_carros.SelectedIndexChanged += new System.EventHandler(this.lsbx_carros_SelectedIndexChanged);
            // 
            // txt_carro
            // 
            this.txt_carro.Location = new System.Drawing.Point(138, 29);
            this.txt_carro.Name = "txt_carro";
            this.txt_carro.Size = new System.Drawing.Size(106, 20);
            this.txt_carro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carro";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(138, 55);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(138, 84);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(106, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(138, 113);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(106, 23);
            this.btn_get.TabIndex = 5;
            this.btn_get.Text = "Obter";
            this.btn_get.UseVisualStyleBackColor = true;
            // 
            // lb_selected
            // 
            this.lb_selected.AutoSize = true;
            this.lb_selected.Location = new System.Drawing.Point(13, 231);
            this.lb_selected.Name = "lb_selected";
            this.lb_selected.Size = new System.Drawing.Size(35, 13);
            this.lb_selected.TabIndex = 6;
            this.lb_selected.Text = "label2";
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 270);
            this.Controls.Add(this.lb_selected);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_carro);
            this.Controls.Add(this.lsbx_carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbx_carros;
        private System.Windows.Forms.TextBox txt_carro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label lb_selected;
    }
}