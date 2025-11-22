using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PreDiplomaPractice
{
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();

            // Заполняем специальности
            var dtSpec = new DataTable();
            new NpgsqlDataAdapter("SELECT specialty_id, name || ' (' || code || ')' AS info FROM specialty ORDER BY name", con)
                .Fill(dtSpec);
            cmbSpecialty.DataSource = dtSpec;
            cmbSpecialty.DisplayMember = "info";
            cmbSpecialty.ValueMember = "specialty_id";

            dtpFrom.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTo.Value = DateTime.Now;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();

            var sql = @"
                SELECT DISTINCT c.name AS ""Предприятие"", c.address AS ""Адрес""
                FROM practice p
                JOIN student s ON p.student_id = s.student_id
                JOIN company c ON p.company_id = c.company_id
                WHERE s.specialty_id = @spec
                  AND p.date_start <= @to 
                  AND p.date_end >= @from
                ORDER BY c.name";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("spec", cmbSpecialty.SelectedValue);
            cmd.Parameters.AddWithValue("from", dtpFrom.Value.Date);
            cmd.Parameters.AddWithValue("to", dtpTo.Value.Date);

            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
                MessageBox.Show("За выбранный период студенты данной специальности не проходили практику.", "Информация");
        }
    }
}