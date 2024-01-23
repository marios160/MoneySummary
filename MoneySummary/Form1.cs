using System.Data;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MoneySummary
{
    public partial class Form1 : Form
    {
        public Controller ctr = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            DialogResult result = dialog.ShowDialog();
            ctr.FilePath = dialog.FileName;
            lbl_sum.Text = ctr.Calculate().ToString();
            Refresh();
             
        }

        private void Refresh()
        {
            dgv_summary.DataSource = ctr.CategorySummaryListBinding;
            dgv_positions.DataSource = ctr.CategoryPositionListBinding;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_summary.AutoGenerateColumns = false;
            dgv_positions.AutoGenerateColumns = false;
            dgv_summary.DataSource = ctr.CategorySummaryListBinding;
            dgv_positions.DataSource = ctr.CategoryPositionListBinding;
        }

        private void dgv_summary_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_summary.SelectedRows.Count > 0)
            {
                ctr.GetPositions(dgv_summary.CurrentRow.Cells["category"].Value.ToString());
            }
        }
    }
}
