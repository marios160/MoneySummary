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
            button1 = new Button();
            panel1 = new Panel();
            lbl_sum = new Label();
            label1 = new Label();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            dgv_summary = new DataGridView();
            category = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dgv_positions = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_summary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_positions).BeginInit();
            SuspendLayout();
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
            panel1.Controls.Add(lbl_sum);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 52);
            panel1.TabIndex = 2;
            // 
            // lbl_sum
            // 
            lbl_sum.AutoSize = true;
            lbl_sum.Location = new Point(176, 21);
            lbl_sum.Name = "lbl_sum";
            lbl_sum.Size = new Size(13, 15);
            lbl_sum.TabIndex = 2;
            lbl_sum.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 21);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Suma:";
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1240, 682);
            panel2.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgv_summary);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgv_positions);
            splitContainer1.Size = new Size(1240, 682);
            splitContainer1.SplitterDistance = 222;
            splitContainer1.TabIndex = 1;
            // 
            // dgv_summary
            // 
            dgv_summary.AllowUserToAddRows = false;
            dgv_summary.AllowUserToDeleteRows = false;
            dgv_summary.AllowUserToOrderColumns = true;
            dgv_summary.AllowUserToResizeColumns = false;
            dgv_summary.AllowUserToResizeRows = false;
            dgv_summary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_summary.Columns.AddRange(new DataGridViewColumn[] { category, dataGridViewTextBoxColumn1 });
            dgv_summary.Dock = DockStyle.Fill;
            dgv_summary.Location = new Point(0, 0);
            dgv_summary.MultiSelect = false;
            dgv_summary.Name = "dgv_summary";
            dgv_summary.ReadOnly = true;
            dgv_summary.RowHeadersVisible = false;
            dgv_summary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_summary.Size = new Size(1240, 222);
            dgv_summary.TabIndex = 2;
            dgv_summary.SelectionChanged += dgv_summary_SelectionChanged;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            dataGridViewTextBoxColumn1.HeaderText = "Kwota";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgv_positions
            // 
            dgv_positions.AllowUserToAddRows = false;
            dgv_positions.AllowUserToDeleteRows = false;
            dgv_positions.AllowUserToOrderColumns = true;
            dgv_positions.AllowUserToResizeColumns = false;
            dgv_positions.AllowUserToResizeRows = false;
            dgv_positions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_positions.Columns.AddRange(new DataGridViewColumn[] { date, amount, type, description });
            dgv_positions.Dock = DockStyle.Fill;
            dgv_positions.Location = new Point(0, 0);
            dgv_positions.Name = "dgv_positions";
            dgv_positions.ReadOnly = true;
            dgv_positions.RowHeadersVisible = false;
            dgv_positions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_positions.Size = new Size(1240, 456);
            dgv_positions.TabIndex = 1;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            date.DataPropertyName = "Date";
            date.HeaderText = "Data";
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 56;
            // 
            // amount
            // 
            amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            amount.DataPropertyName = "Amount";
            amount.HeaderText = "Kwota";
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 65;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            type.DataPropertyName = "Type";
            type.HeaderText = "Typ transakcji";
            type.Name = "type";
            type.ReadOnly = true;
            type.Width = 103;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.DataPropertyName = "Description";
            description.HeaderText = "Opis";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 734);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_summary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_positions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_sum;
        private Label label1;
        private SplitContainer splitContainer1;
        private DataGridView dgv_positions;
        private DataGridView dgv_summary;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn description;
    }
}
