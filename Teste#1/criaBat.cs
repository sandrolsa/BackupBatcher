using System;
using System.Windows.Forms;

namespace Teste_1
{
    public partial class criaBat : Form
    {
        public Form BackupBatcher;
        public string dadosServidor { get { return servidor.Text; } set { servidor.Text = value; } }
        public string dadosUsuario { get { return usuario.Text; } set { usuario.Text = value; } }
        public string dadosBanco { get { return banco.Text; } set { banco.Text = value; } }
        public string dadosSenha { get { return senha.Text; } set { senha.Text = value; } }

        public criaBat(Form mainForm)
        {
            InitializeComponent();
            this.FormClosed += fechaPrograma;
            BackupBatcher = mainForm;
            associa_Evento();
        }
        private void checa_Campos(object? sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (sender is TextBox textbox && string.IsNullOrEmpty(textbox.Text))
                {
                    textbox.Text = textbox.PlaceholderText;
                }
            }
        }
        private void associa_Evento()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Leave += checa_Campos;
                }
            }
        }
        private void fechaPrograma(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void butCancela_Click(object sender, EventArgs e)
        {
            BackupBatcher.Visible = true;
            this.Hide();
        }

        private void butProximo_Click(object sender, EventArgs e)
        {
            bool camposVazios = false;

            var campos = new (TextBox textBox, Action<string> setProperty)[]
            {
                (servidor, value => dadosServidor = value),
                (usuario, value => dadosUsuario = value),
                (banco, value => dadosBanco = value),
                (senha, value => dadosSenha = value)
            };

            foreach (var (textBox, setProperty) in campos)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    camposVazios = true;
                    setProperty(textBox.PlaceholderText);
                }
            }

            if (camposVazios)
            {
                MessageBox.Show("Valor padrão atribuído aos campos vazios.", "Atenção!", MessageBoxButtons.OK);
            }

            var dadosArq = new dadosArq(this);
            dadosArq.Show();
            Visible = false;
        }

        private void butDbmysql_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está função ainda não está implementada.", "Atenção!", MessageBoxButtons.OK);
        }

        private void butTesta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está função ainda não está implementada.", "Atenção!", MessageBoxButtons.OK);
        }
    }
}