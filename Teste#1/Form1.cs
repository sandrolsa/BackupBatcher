namespace Teste_1
{
    public partial class BackupBatcher : Form
    {
        private BatBackup batBackup;
        public BackupBatcher()

        {
            InitializeComponent();
        }
        public void fechaPrograma(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void criaBat_Click(object sender, EventArgs e)
        {
            var criaBat = new criaBat(this);
            criaBat.Show();
            Visible = false;
        }

        private void editaBat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está função ainda não está implementada.", "Atenção!", MessageBoxButtons.OK);
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void excluiBat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está função ainda não está implementada.", "Atenção!", MessageBoxButtons.OK);
        }
    }
}
