namespace MoneySummary
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
            components = new System.ComponentModel.Container();
            DataGridView dgv_Summary;
            category = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorySummaryBindingSource = new BindingSource(components);
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            dgv_Summary = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Summary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categorySummaryBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Summary
            // 
            dgv_Summary.AllowUserToAddRows = false;
            dgv_Summary.AllowUserToDeleteRows = false;
            dgv_Summary.AutoGenerateColumns = false;
            dgv_Summary.BorderStyle = BorderStyle.None;
            dgv_Summary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Summary.Columns.AddRange(new DataGridViewColumn[] { category, amount, categoryDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            dgv_Summary.DataSource = categorySummaryBindingSource;
            dgv_Summary.Dock = DockStyle.Fill;
            dgv_Summary.Location = new Point(0, 0);
            dgv_Summary.Name = "dgv_Summary";
            dgv_Summary.ReadOnly = true;
            dgv_Summary.RowHeadersVisible = false;
            dgv_Summary.Size = new Size(800, 398);
            dgv_Summary.TabIndex = 1;
            // 
            // category
            // 
            category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            category.DataPropertyName = "Category";
            category.HeaderText = "Kategoria";
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 82;
            // 
            // amount
            // 
            amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amount.DataPropertyName = "Amount";
            amount.HeaderText = "Kwota";
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorySummaryBindingSource
            // 
            categorySummaryBindingSource.DataSource = typeof(CategorySummary);
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 0;
            button1.Text = "Wczytaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_Summary);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 398);
            panel2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Summary).EndInit();
            ((System.ComponentModel.ISupportInitialize)categorySummaryBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgv_Summary;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private BindingSource categorySummaryBindingSource;
    }
}
