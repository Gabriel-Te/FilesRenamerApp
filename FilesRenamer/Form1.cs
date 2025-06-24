namespace FilesRenamerApp
{
    using FileRenamer;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createReport_CheckedChanged(null, null);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var fileNameChanger = new FileNameChanger();
            fileNameChanger.ChangeFilesNames(folderPath.Text, name.Text, reportPath.Text == "" ? null : reportPath.Text);
            folderPath.Text = "";
            name.Text = "";
            reportPath.Text = "";

        }

        private void createReport_CheckedChanged(object? sender, EventArgs? e)
        {
            if (createReport.Checked)
            {
                reportPath.Enabled = true;
                reportPath.BackColor = SystemColors.Window;
            }
            else
            {
                reportPath.Enabled = false;
                reportPath.Text = "";
                reportPath.BackColor = SystemColors.ControlDark;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Gabriel-Te",
            });
        }

        private void reportPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
