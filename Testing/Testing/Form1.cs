namespace Testing
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup f2 = new frmSignup();
            f2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRsrv rsrv = new frmRsrv();
            rsrv.Show();
            Hide();
        }
    }
}
