
namespace Mini_Shazam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            homePage1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            databasePage1.BringToFront();
        }

        private void MiniShazam_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homePage1.BringToFront();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            infoPage1.BringToFront();
        }
    }
}
