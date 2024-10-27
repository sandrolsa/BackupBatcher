using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Teste_1
{
    public partial class criaBat : Form
    {
        public Form BackupBatcher;
        public string dadosServidor { get => servidor.Text; set => servidor.Text = value; }
        public string dadosUsuario { get => usuario.Text; set => usuario.Text = value; }
        public string dadosBanco { get => banco.Text; set => banco.Text = value; }
        public string dadosSenha { get => senha.Text; set => senha.Text = value; }
        public criaBat(Form mainForm)
        {
            InitializeComponent();
            FormClosed += fechaPrograma;
            BackupBatcher = mainForm;
            associa_Evento();
        }
        private void checa_Campos(object? sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (sender is TextBox textbox && string.IsNullOrEmpty(textbox.Text))
                {
                    textbox.Text = textbox.PlaceholderText;
                }
            }
        }
        private void associa_Evento()
        {
            foreach (Control control in Controls)
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
            Hide();
        }
        private void butProximo_Click(object sender, EventArgs e)
        {
            bool camposVazios = false;
            (TextBox textBox, Action<string> setProperty)[] campos = new (TextBox textBox, Action<string> setProperty)[]
            {
                (servidor, value => dadosServidor = value),
                (usuario, value => dadosUsuario = value),
                (banco, value => dadosBanco = value)
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
                _ = MessageBox.Show("Valor padrão atribuído aos campos vazios.", "Atenção!", MessageBoxButtons.OK);
            }
            dadosArq dadosArq = new(this);
            dadosArq.Show();
            Visible = false;
        }
        private void butDbmysql_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arquivos .INI (*.ini)|*.ini|Todos os Arquivos (*.*)|*.*",
                Title = "Selecione o arquivo DbMysql."
            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (var linha in File.ReadLines(openFileDialog.FileName))
                    {
                        if (linha.StartsWith("S"))
                        {
                            servidor.Text = linha.Substring(1);
                        }
                        else if (linha.StartsWith("B"))
                        {
                            banco.Text = linha.Substring(1);
                        }
                        else if (linha.StartsWith("U"))
                        {
                            usuario.Text = linha.Substring(1);
                        }
                        else if (linha.StartsWith ("P"))
                        {
                            senha.Text = linha.Substring(1);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao ler o arquivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void butTesta_Click(object sender, EventArgs e)
        {
            string conexao = $"Server={servidor.Text};Database={banco.Text}; User ID={usuario.Text};Password={senha.Text};Port=3306;";
            using MySqlConnection conn = new MySqlConnection(conexao);
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Conexão bem sucedida!", "Sucesso", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}