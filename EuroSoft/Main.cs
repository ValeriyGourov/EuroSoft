using System;
using System.Windows.Forms;

namespace EuroSoft
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillTestResultsTable();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text))
            {
                ErrorProvider.SetError(UserName, "No name specified.");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }

            Testing testing = new Testing();
            testing.ShowDialog(this);
            if (testing.TestResult != null)
            {
                TestResultView testResultView = new TestResultView(UserName.Text, testing.TestResult);
                testResultView.ShowDialog(this);

                FillTestResultsTable();
            }
        }

        private void FillTestResultsTable() => testResultsTableAdapter.Fill(testResultsDataSet.TestResults);
    }
}
