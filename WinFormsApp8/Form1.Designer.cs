namespace WinFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCategory = new ComboBox();
            lstProducts = new ListBox();
            btnAddProduct = new Button();
            btnFilter = new Button();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(265, 124);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(166, 28);
            cmbCategory.TabIndex = 0;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(265, 188);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(438, 104);
            lstProducts.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(282, 323);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Додати товар";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click_1;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(41, 228);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(141, 29);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Фільтрування";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFilter);
            Controls.Add(btnAddProduct);
            Controls.Add(lstProducts);
            Controls.Add(cmbCategory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCategory;
        private ListBox lstProducts;
        private Button btnAddProduct;
        private Button btnFilter;
    }
}
