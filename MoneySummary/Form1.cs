using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MoneySummary
{
    public partial class Form1 : Form
    {
        public Controller ctr = Controller.GetInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog();
            ctr.Clear();
            foreach (string s in dialog.FileNames)
            {
                ctr.FilePath = s;
                ctr.Calculate();
            }
            Refresh();
            lbl_sum.Text = ctr.Sum.ToString();

        }

        private void Refresh()
        {
            //dgv_summary.DataSource = ctr.CategorySummaryListBinding;
            loadSummaryList();
            dgv_positions.DataSource = ctr.CategoryPositionListBinding;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_summary.AutoGenerateColumns = false;
            dgv_positions.AutoGenerateColumns = false;
            //dgv_summary.DataSource = ctr.CategorySummaryListBinding;
            loadSummaryList();
            dgv_positions.DataSource = ctr.CategoryPositionListBinding;
        }

        private void dgv_summary_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_summary.SelectedRows.Count > 0)
            {
                ctr.GetPositions(dgv_summary.CurrentRow.Cells["category"].Value.ToString());
            }
        }

        private void btn_reloadKeys_Click(object sender, EventArgs e)
        {
            ctr.Recalculate();
            Refresh();
        }

        private void loadSummaryList()
        {
            if (ctr.CategorySummaryList != null)
            {
                dgv_summary.Columns.Clear();
                dgv_summary.Columns.Add("Category", "Kategoria");

                // Pobranie unikalnych miesiêcy
                var allMonths = ctr.CategorySummaryList
                    .SelectMany(c => c.Amounts.Keys)
                    .Distinct()
                    .OrderBy(d => d)
                    .ToList();

                // Dodanie kolumn dla miesiêcy
                Dictionary<DateTime, decimal> sums = new();
                foreach (var month in allMonths)
                {
                    dgv_summary.Columns.Add(month.ToString("yyyy-MM"), month.ToString("MMM yyyy"));
                    sums.Add(month,0);
                }
                dgv_summary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                List<string> exceptCategories = new() { Category.PRZELEW_WEW.ToString(), Category.LOKATY.ToString() };

                // Wype³nienie DataGridView
                foreach (var category in ctr.CategorySummaryList)
                {
                    if (exceptCategories.Contains(category.Category)) continue;

                    var row = new List<object> { category.Category };

                    foreach (var month in allMonths)
                    {
                        row.Add(category.Amounts.TryGetValue(month, out decimal sum) ? sum.ToString("C") : "");
                        sums[month] += sum;
                    }

                    dgv_summary.Rows.Add(row.ToArray());
                }

                //Dodanie sumy dla ka¿dego miesi¹ca
                var rowSum = new List<object> { "SUMY" };
                foreach (var sum in sums)
                {
                    rowSum.Add(sum.Value);
                }
                
                dgv_summary.Rows.Add(rowSum.ToArray());
                dgv_summary.Rows[dgv_summary.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                dgv_summary.Rows[dgv_summary.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            }
        }
    }
}
