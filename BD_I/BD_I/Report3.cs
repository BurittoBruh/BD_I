using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PreDiplomaPractice
{
    public partial class Report3 : Form
    {
        public Report3()
        {
            InitializeComponent();
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();

            // Специальности
            var dtSpec = new DataTable();
            new NpgsqlDataAdapter("SELECT specialty_id, name || ' (' || code || ')' FROM specialty ORDER BY name", con)
                .Fill(dtSpec);
            cmbSpecialty.DataSource = dtSpec;
            cmbSpecialty.DisplayMember = "name";
            cmbSpecialty.ValueMember = "specialty_id";

            // Годы поступления
            nudYear.Minimum = 2015;
            nudYear.Maximum = DateTime.Now.Year + 1;
            nudYear.Value = DateTime.Now.Year - 4;

            dtpDate.Value = DateTime.Today;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();

            var sql = @"
                SELECT s.record_book_num AS ""Зачётка"",
                       s.fio AS ""ФИО студента"",
                       sp.name AS ""Специальность"",
                       s.cohort_year AS ""Год поступления""
                FROM student s
                JOIN specialty sp ON s.specialty_id = sp.specialty_id
                JOIN practice p ON p.student_id = s.student_id
                WHERE s.specialty_id = @spec
                  AND s.cohort_year = @year
                  AND (p.practice_defense_date <= @ondate OR p.practice_defense_date IS NULL)
                  AND p.grade IS NULL
                ORDER BY s.fio";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("spec", cmbSpecialty.SelectedValue);
            cmd.Parameters.AddWithValue("year", (int)nudYear.Value);
            cmd.Parameters.AddWithValue("ondate", dtpDate.Value.Date);

            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dataGridView1.DataSource = dt;

            lblCount.Text = $"Найдено студентов без оценки: {dt.Rows.Count}";
            if (dt.Rows.Count == 0)
                MessageBox.Show("Все студенты сдали практику вовремя!", "Отлично!");
        }
    }
}
