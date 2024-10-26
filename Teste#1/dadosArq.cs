using System;
using System.Windows.Forms;

namespace Teste_1
{
    public partial class dadosArq : Form
    {
        private readonly criaBat criaBatForm;
        private BatBackup batBackup;

        public string dadosEmpresa { get { return empresa.Text; } set { empresa.Text = value; } }
        public string dadosCaixa { get { return caixa.Text; } set { caixa.Text = value; } }
        public string qtdDias { get { return dias.Text; } set { dias.Text = value; } }
        public string backup { get { return dirBackup.Text; } set { dirBackup.Text = value; } }
        public string copia { get { return dirCopia.Text; } set { dirCopia.Text = value; } }

        public dadosArq(criaBat form)
        {
            InitializeComponent();
            criaBatForm = form;
            batBackup = new BatBackup(criaBatForm, this);
            associa_Evento();

        }

        private void checa_Campos(object? sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (sender is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = textBox.PlaceholderText;
                }
            }
        }

        private void associa_Evento()
        {
            foreach (Control control in this.Controls)
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
        private void butVolta_Click(object sender, EventArgs e)
        {
            criaBatForm.Visible = true;
            Visible = false;
        }

        private void butFinaliza_Click(object sender, EventArgs e)
        {

            bool camposVazios = false;

            var campos = new (TextBox textBox, Action<string> setProperty)[]
            {
                (empresa, value => dadosEmpresa = value),
                (caixa, value => dadosCaixa = value),
                (dias, value => qtdDias = value),
                (dirBackup, value => backup = value),
                (dirCopia, value => copia = value)
            };
            foreach (var (textBox, setProperty) in campos)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    camposVazios = true;
                    setProperty(textBox.PlaceholderText);
                    batBackup.Bat_Backup();
                    MessageBox.Show("Bat criada com sucesso!", "Sucesso", MessageBoxButtons.OK);
                }
            }

            if (!camposVazios)
            {
                batBackup.Bat_Backup();
                MessageBox.Show("Bat criada com sucesso!", "Sucesso", MessageBoxButtons.OK);
            }
        }

        private void butBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está função ainda não está implementada.", "Atenção!", MessageBoxButtons.OK);
        }

        private void butBusca2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está função ainda não está implementada.", "Atenção!", MessageBoxButtons.OK);
        }
    }
}
