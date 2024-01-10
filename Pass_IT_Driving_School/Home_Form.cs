using Timer = System.Windows.Forms.Timer;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace Pass_IT_Driving_School
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
        }

        private Task ProgressData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalprocess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalprocess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalprocess;
                    progress.Report(progressReport);
                    Thread.Sleep(100);
                }
            });
        }

        private async void ShowProgress()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 50; i++)
                list.Add(i.ToString());
            lblProgressbar.Text = "Initalizing...";
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (O, report) =>
            {
                lblProgressbar.Text = string.Format("Starting...{0}%", report.PercentComplete);
                progressBar1.Value = report.PercentComplete;
                progressBar1.Update();
            };
            await ProgressData(list, progress);
            lblProgressbar.Text = "Completed!!!";
            LogIn_Form logIn_Form = new LogIn_Form();
            logIn_Form.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ShowProgress();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}