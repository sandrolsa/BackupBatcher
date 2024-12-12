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
            // Criação do formulário temporário
            Form horarioForm = new Form
            {
                Width = 250,
                Height = 150,
                Text = "Horário do backup diário.",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            // Criação do DateTimePicker para selecionar apenas a hora
            DateTimePicker timePicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Value = DateTime.Now,
                Location = new System.Drawing.Point(30, 20),
                Width = 150
            };

            // Criação do botão para confirmar a seleção de horário
            Button btnConfirmar = new Button
            {
                Text = "Confirmar",
                DialogResult = DialogResult.OK,
                Location = new System.Drawing.Point(70, 60),
                Width = 100,
                Height = 30
            };

            // Adiciona controles ao formulário temporário
            horarioForm.Controls.Add(timePicker);
            horarioForm.Controls.Add(btnConfirmar);

            // Exibe o formulário temporário como modal e captura o resultado
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

                MessageBox.Show("Tarefa agendada excluída com sucesso!", "Sucesso", MessageBoxButtons.OK);

                // Verifica se o arquivo existe antes de tentar excluí-lo
                if (File.Exists(bat))
                {
                    File.Delete(bat);
                    MessageBox.Show("Arquivo backup.bat excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Arquivo backup.bat não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir a tarefa ou o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
