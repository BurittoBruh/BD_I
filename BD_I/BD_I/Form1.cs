using System;
using System.Windows.Forms;

namespace PreDiplomaPractice
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "ÀÈÑ «Ïðåääèïëîìíàÿ ïðàêòèêà»";
            WindowState = FormWindowState.Maximized;
        }

        private void ñòóäåíòûToolStripMenuItem_Click(object sender, EventArgs e) => new FrmStudents().ShowDialog();
        private void ïðåäïðèÿòèÿToolStripMenuItem_Click(object sender, EventArgs e) => new FrmCompanies().ShowDialog();
        private void ïðàêòèêàToolStripMenuItem_Click(object sender, EventArgs e) => new FrmPractice().ShowDialog();
        private void îò÷¸ò1ToolStripMenuItem_Click(object sender, EventArgs e) => new Report1().ShowDialog();
        private void îò÷¸ò2ToolStripMenuItem_Click(object sender, EventArgs e) => new Report2().ShowDialog();
        private void îò÷¸ò3ToolStripMenuItem_Click(object sender, EventArgs e) => new Report3().ShowDialog();
    }
}