namespace Teste_1
{
    public partial class dadosArq : Form
    {
        private readonly criaBat criaBatForm;
        private readonly BatBackup batBackup;
        private readonly BackupBatcher backupBatcher;
        public string dadosEmpresa { get => empresa.Text; set => empresa.Text = value; }
        public string dadosCaixa { get => caixa.Text; set => caixa.Text = value; }
        public string qtdDias { get => dias.Text; set => dias.Text = value; }
        public string backup { get => dirBackup.Text; set => dirBackup.Text = value; }
        public string copia { get => dirCopia.Text; set => dirCopia.Text = value; }
        public dadosArq(criaBat form)
        {
            InitializeComponent();
            criaBatForm = form;
            batBackup = new BatBackup(criaBatForm, this);
            backupBatcher = new BackupBatcher();
            associa_Evento();
        }
        private void checa_Campos(object? sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (sender is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = textBox.PlaceholderText;
                }
            }
        }
        private void associa_Evento()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Leave += checa_Campos;
                }
            }
        }
        public void fechaPrograma(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void butBusca_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    backup = folderBrowserDialog.SelectedPath + "\\";
                }
            }
        }
        private void butBusca2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    copia = folderBrowserDialog.SelectedPath + "\\";
                }
            }
        }
        private void butFinaliza_Click(object sender, EventArgs e)
        {
            bool camposVazios = false;
            (TextBox textBox, Action<string> setProperty)[] campos = new (TextBox textBox, Action<string> setProperty)[]
            {
                (empresa, value => dadosEmpresa = value),
                (caixa, value => dadosCaixa = value),
                (dias, value => qtdDias = value),
                (dirBackup, value => backup = value),
                (dirCopia, value => copia = value)
            };
            foreach ((TextBox textBox, Action<string> setProperty) in campos)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    camposVazios = true;
                    setProperty(textBox.PlaceholderText);
                }
            }
            if (camposVazios)
            {
                _ = MessageBox.Show("Valor padrão atribuído aos campos vazios", "Atenção", MessageBoxButtons.OK);
            }
            _ = MessageBox.Show("Bat criada com sucesso!", "Sucesso", MessageBoxButtons.OK);
            batBackup.Bat_Backup();
            backupBatcher.Show();
            Visible = false;
        }
        private void butVolta_Click(object sender, EventArgs e)
        {
            criaBatForm.Visible = true;
            Visible = false;
        }
    }
}
