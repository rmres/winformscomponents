namespace Componentes
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "150",
            "59.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "51",
            "89.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "74",
            "230.00"}, -1);
            this.lv_products = new System.Windows.Forms.ListView();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_addnew = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_produto = new System.Windows.Forms.Label();
            this.lb_quantidade = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_products
            // 
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_product,
            this.col_qtd,
            this.col_preco});
            this.lv_products.FullRowSelect = true;
            this.lv_products.HideSelection = false;
            this.lv_products.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lv_products.Location = new System.Drawing.Point(12, 12);
            this.lv_products.MultiSelect = false;
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(531, 152);
            this.lv_products.TabIndex = 0;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            this.lv_products.SelectedIndexChanged += new System.EventHandler(this.lv_products_SelectedIndexChanged);
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 51;
            // 
            // col_product
            // 
            this.col_product.Text = "Produto";
            this.col_product.Width = 280;
            // 
            // col_qtd
            // 
            this.col_qtd.Text = "Quantidade";
            this.col_qtd.Width = 71;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 124;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 217);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(56, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(75, 216);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(272, 20);
            this.txt_product.TabIndex = 2;
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(354, 216);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(74, 20);
            this.txt_qtd.TabIndex = 3;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(434, 216);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(90, 20);
            this.txt_preco.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(12, 243);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(132, 23);
            this.btn_get.TabIndex = 9;
            this.btn_get.Text = "Obter";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(13, 273);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(131, 23);
            this.btn_remove.TabIndex = 10;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_addnew
            // 
            this.btn_addnew.Location = new System.Drawing.Point(13, 303);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(131, 23);
            this.btn_addnew.TabIndex = 11;
            this.btn_addnew.Text = "Cadastrar novo produto";
            this.btn_addnew.UseVisualStyleBackColor = true;
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(13, 171);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 13);
            this.lb_id.TabIndex = 12;
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.Location = new System.Drawing.Point(75, 170);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(0, 13);
            this.lb_produto.TabIndex = 13;
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.AutoSize = true;
            this.lb_quantidade.Location = new System.Drawing.Point(354, 170);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(0, 13);
            this.lb_quantidade.TabIndex = 14;
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(423, 169);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(0, 13);
            this.lb_preco.TabIndex = 15;
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 358);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lb_quantidade);
            this.Controls.Add(this.lb_produto);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.btn_addnew);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lv_products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_product;
        private System.Windows.Forms.ColumnHeader col_qtd;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_addnew;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.Label lb_quantidade;
        private System.Windows.Forms.Label lb_preco;
    }
}