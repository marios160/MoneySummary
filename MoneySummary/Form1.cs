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
            ctr.Calculate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgv_Summary.AutoGenerateColumns = false;
            //dgv_Summary.DataSource = ctr.CategorySummaryListBinding;
        }
    }
}
