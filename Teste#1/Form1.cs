namespace Teste_1
{
    public partial class BackupBatcher : Form
    {
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
            MessageBox.Show("Est� fun��o ainda n�o est� implementada.", "Aten��o!", MessageBoxButtons.OK);
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void excluiBat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Est� fun��o ainda n�o est� implementada.", "Aten��o!", MessageBoxButtons.OK);
        }
    }
}
