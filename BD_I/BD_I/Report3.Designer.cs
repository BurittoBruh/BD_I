namespace PreDiplomaPractice
{
    partial class Report3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbSpecialty = new ComboBox();
            label1 = new Label();
            nudYear = new NumericUpDown();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            btnShow = new Button();
            dataGridView1 = new DataGridView();
            lblCount = new Label();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialty.Location = new Point(171, 20);
            cmbSpecialty.Margin = new Padding(3, 4, 3, 4);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(365, 28);
            cmbSpecialty.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 7;
            label1.Text = "Специальность:";
            // 
            // nudYear
            // 
            nudYear.Location = new Point(171, 73);
            nudYear.Margin = new Padding(3, 4, 3, 4);
            nudYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 2015, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(91, 27);
            nudYear.TabIndex = 1;
            nudYear.Value = new decimal(new int[] { 2015, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 6;
            label2.Text = "Год поступления:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(264, 131);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(166, 27);
            dtpDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 131);
            label3.Name = "label3";
            label3.Size = new Size(244, 20);
            label3.TabIndex = 5;
            label3.Text = "На дату (защита должна быть до):";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(220, 53, 69);
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.ForeColor = Color.White;
            btnShow.Location = new Point(454, 115);
            btnShow.Margin = new Padding(3, 4, 3, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(160, 53);
            btnShow.TabIndex = 4;
            btnShow.Text = "Показать должников";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(14, 187);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(869, 427);
            dataGridView1.TabIndex = 3;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCount.ForeColor = Color.FromArgb(220, 53, 69);
            lblCount.Location = new Point(14, 627);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(288, 23);
            lblCount.TabIndex = 0;
            lblCount.Text = "Найдено студентов без оценки: 0";
            // 
            // Report3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 668);
            Controls.Add(lblCount);
            Controls.Add(dataGridView1);
            Controls.Add(btnShow);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(nudYear);
            Controls.Add(label2);
            Controls.Add(cmbSpecialty);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Report3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отчёт 3: Студенты без оценки на дату";
            Load += Report3_Load;
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCount;
    }
}