using System;
using System.Diagnostics;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

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
            criaBat criaBat = new(this);
            criaBat.Show();
            Visible = false;
        }
        private void editaBat_Click(object sender, EventArgs e)
        {
            // Cria��o do formul�rio tempor�rio
            Form horarioForm = new Form
            {
                Width = 250,
                Height = 150,
                Text = "Hor�rio do backup di�rio.",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            // Cria��o do DateTimePicker para selecionar apenas a hora
            DateTimePicker timePicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Value = DateTime.Now,
                Location = new System.Drawing.Point(30, 20),
                Width = 150
            };

            // Cria��o do bot�o para confirmar a sele��o de hor�rio
            Button btnConfirmar = new Button
            {
                Text = "Confirmar",
                DialogResult = DialogResult.OK,
                Location = new System.Drawing.Point(70, 60),
                Width = 100,
                Height = 30
            };

            // Adiciona controles ao formul�rio tempor�rio
            horarioForm.Controls.Add(timePicker);
            horarioForm.Controls.Add(btnConfirmar);

            // Exibe o formul�rio tempor�rio como modal e captura o resultado
            if (horarioForm.ShowDialog() == DialogResult.OK)
            {
                // Captura hora do DateTimePicker
                string hora = timePicker.Value.ToString("HH:mm");

                // Caminho do script
                string diretorio = @"C:\DATABASE\BACKUP\BAT\backup.bat";
                // Comando para criar a tarefa no agendador de tarefas
                string comando = $"/create /sc daily /tn \"BackupDiario\" /tr \"{diretorio}\" /st {hora} /f";

                try
                {
                    // Executa o comando usando schtasks
                    Process.Start("schtasks", comando);
                    MessageBox.Show("Tarefa agendada com sucesso!", "Sucesso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao agendar a tarefa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void excluiBat_Click(object sender, EventArgs e)
        {
            // Nome da tarefa no Agendador de Tarefas
            string tarefa = "BackupDiario";
            // Caminho do arquivo backup.bat
            string bat = @"C:\DATABASE\BACKUP\BAT\backup.bat";

            try
            {
                // Comando para excluir a tarefa no agendador de tarefas
                string excluirTarefa = $"/delete /tn \"{tarefa}\" /f";
                Process.Start("schtasks", excluirTarefa);

                MessageBox.Show("Tarefa agendada exclu�da com sucesso!", "Sucesso", MessageBoxButtons.OK);

                // Verifica se o arquivo existe antes de tentar exclu�-lo
                if (File.Exists(bat))
                {
                    File.Delete(bat);
                    MessageBox.Show("Arquivo backup.bat exclu�do com sucesso!", "Sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Arquivo backup.bat n�o encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir a tarefa ou o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
