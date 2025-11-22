using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PreDiplomaPractice
{
    public partial class FrmStudents : Form
    {
        public FrmStudents() => InitializeComponent();

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            LoadSpecialty();
            LoadGrid();
        }

        private void LoadSpecialty()
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var dt = new DataTable();
            new NpgsqlDataAdapter("SELECT specialty_id, name FROM specialty ORDER BY name", con).Fill(dt);
            cmbSpecialty.DataSource = dt;
            cmbSpecialty.DisplayMember = "name";
            cmbSpecialty.ValueMember = "specialty_id";
        }

        private void LoadGrid()
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var sql = @"
                SELECT s.student_id, s.record_book_num AS ""Зачётка"", s.fio AS ""ФИО"",
                       s.cohort_year AS ""Год"", sp.name AS ""Специальность""
                FROM student s
                JOIN specialty sp ON s.specialty_id = sp.specialty_id
                ORDER BY s.fio";
            var dt = new DataTable();
            new NpgsqlDataAdapter(sql, con).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBook.Text) || string.IsNullOrWhiteSpace(txtFIO.Text)) return;

            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var cmd = new NpgsqlCommand(@"INSERT INTO student 
                (record_book_num, fio, cohort_year, specialty_id) 
                VALUES (@b, @f, @y, @s)", con);
            cmd.Parameters.AddWithValue("b", txtBook.Text.Trim());
            cmd.Parameters.AddWithValue("f", txtFIO.Text.Trim());
            cmd.Parameters.AddWithValue("y", (int)nudYear.Value);
            cmd.Parameters.AddWithValue("s", cmbSpecialty.SelectedValue);
            cmd.ExecuteNonQuery();

            LoadGrid();
            txtBook.Clear(); txtFIO.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            if (MessageBox.Show("Удалить студента?", "Да?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var con = new NpgsqlConnection(DbConnection.ConnectionString);
                con.Open();
                new NpgsqlCommand($"DELETE FROM student WHERE student_id = {id}", con).ExecuteNonQuery();
                LoadGrid();
            }
        }
    }
}