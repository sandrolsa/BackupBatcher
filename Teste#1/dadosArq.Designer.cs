namespace Teste_1
{
    partial class dadosArq
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbArquivo = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            butBusca2 = new Button();
            butBusca = new Button();
            labelCopia = new Label();
            labelBackup = new Label();
            labelDias = new Label();
            labelCaixa = new Label();
            labelEmpresa = new Label();
            dirCopia = new TextBox();
            dirBackup = new TextBox();
            dias = new TextBox();
            caixa = new TextBox();
            empresa = new TextBox();
            butFinaliza = new Button();
            butVolta = new Button();
            gbArquivo.SuspendLayout();
            SuspendLayout();
            // 
            // gbArquivo
            // 
            gbArquivo.Controls.Add(label2);
            gbArquivo.Controls.Add(label1);
            gbArquivo.Controls.Add(butBusca2);
            gbArquivo.Controls.Add(butBusca);
            gbArquivo.Controls.Add(labelCopia);
            gbArquivo.Controls.Add(labelBackup);
            gbArquivo.Controls.Add(labelDias);
            gbArquivo.Controls.Add(labelCaixa);
            gbArquivo.Controls.Add(labelEmpresa);
            gbArquivo.Controls.Add(dirCopia);
            gbArquivo.Controls.Add(dirBackup);
            gbArquivo.Controls.Add(dias);
            gbArquivo.Controls.Add(caixa);
            gbArquivo.Controls.Add(empresa);
            gbArquivo.ForeColor = Color.FromArgb(80, 250, 123);
            gbArquivo.Location = new Point(50, 37);
            gbArquivo.Name = "gbArquivo";
            gbArquivo.Size = new Size(376, 440);
            gbArquivo.TabIndex = 0;
            gbArquivo.TabStop = false;
            gbArquivo.Text = "Dados Arquivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 354);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 13;
            label2.Text = "Buscar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 293);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 12;
            label1.Text = "Buscar";
            // 
            // butBusca2
            // 
            butBusca2.Location = new Point(323, 376);
            butBusca2.Margin = new Padding(10);
            butBusca2.Name = "butBusca2";
            butBusca2.Size = new Size(40, 29);
            butBusca2.TabIndex = 7;
            butBusca2.UseVisualStyleBackColor = true;
            butBusca2.Click += butBusca2_Click;
            // 
            // butBusca
            // 
            butBusca.Location = new Point(323, 315);
            butBusca.Margin = new Padding(10);
            butBusca.Name = "butBusca";
            butBusca.Size = new Size(40, 29);
            butBusca.TabIndex = 5;
            butBusca.UseVisualStyleBackColor = true;
            butBusca.Click += butBusca_Click;
            // 
            // labelCopia
            // 
            labelCopia.AutoSize = true;
            labelCopia.Location = new Point(13, 353);
            labelCopia.Name = "labelCopia";
            labelCopia.Size = new Size(82, 20);
            labelCopia.TabIndex = 9;
            labelCopia.Text = "Cópia para";
            // 
            // labelBackup
            // 
            labelBackup.AutoSize = true;
            labelBackup.Location = new Point(13, 293);
            labelBackup.Name = "labelBackup";
            labelBackup.Size = new Size(120, 20);
            labelBackup.TabIndex = 8;
            labelBackup.Text = "Caminho Backup";
            // 
            // labelDias
            // 
            labelDias.AutoSize = true;
            labelDias.Location = new Point(93, 189);
            labelDias.Name = "labelDias";
            labelDias.Size = new Size(70, 20);
            labelDias.TabIndex = 7;
            labelDias.Text = "Qtd. Dias";
            // 
            // labelCaixa
            // 
            labelCaixa.AutoSize = true;
            labelCaixa.Location = new Point(93, 118);
            labelCaixa.Name = "labelCaixa";
            labelCaixa.Size = new Size(45, 20);
            labelCaixa.TabIndex = 6;
            labelCaixa.Text = "Caixa";
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Location = new Point(93, 48);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(111, 20);
            labelEmpresa.TabIndex = 5;
            labelEmpresa.Text = "Empresa / Filial";
            // 
            // dirCopia
            // 
            dirCopia.AcceptsReturn = true;
            dirCopia.AcceptsTab = true;
            dirCopia.BackColor = Color.WhiteSmoke;
            dirCopia.CharacterCasing = CharacterCasing.Upper;
            dirCopia.Location = new Point(13, 378);
            dirCopia.Margin = new Padding(10, 3, 10, 10);
            dirCopia.MaxLength = 100;
            dirCopia.Name = "dirCopia";
            dirCopia.PlaceholderText = "\\\\LOCALHOST\\DATABASE\\COPIA\\";
            dirCopia.Size = new Size(297, 27);
            dirCopia.TabIndex = 6;
            dirCopia.Leave += checa_Campos;
            // 
            // dirBackup
            // 
            dirBackup.AcceptsReturn = true;
            dirBackup.AcceptsTab = true;
            dirBackup.BackColor = Color.WhiteSmoke;
            dirBackup.CharacterCasing = CharacterCasing.Upper;
            dirBackup.Location = new Point(13, 316);
            dirBackup.Margin = new Padding(10, 3, 10, 10);
            dirBackup.MaxLength = 100;
            dirBackup.Name = "dirBackup";
            dirBackup.PlaceholderText = "C:\\DATABASE\\BACKUP\\ON\\";
            dirBackup.Size = new Size(297, 27);
            dirBackup.TabIndex = 4;
            dirBackup.Leave += checa_Campos;
            // 
            // dias
            // 
            dias.AcceptsReturn = true;
            dias.AcceptsTab = true;
            dias.BackColor = Color.WhiteSmoke;
            dias.Location = new Point(93, 212);
            dias.MaxLength = 3;
            dias.Name = "dias";
            dias.PlaceholderText = "7";
            dias.Size = new Size(200, 27);
            dias.TabIndex = 3;
            dias.TextAlign = HorizontalAlignment.Center;
            dias.Leave += checa_Campos;
            // 
            // caixa
            // 
            caixa.AcceptsReturn = true;
            caixa.AcceptsTab = true;
            caixa.BackColor = Color.WhiteSmoke;
            caixa.CharacterCasing = CharacterCasing.Upper;
            caixa.Location = new Point(93, 141);
            caixa.MaxLength = 4;
            caixa.Name = "caixa";
            caixa.PlaceholderText = "CX01";
            caixa.Size = new Size(200, 27);
            caixa.TabIndex = 2;
            caixa.TextAlign = HorizontalAlignment.Center;
            caixa.Leave += checa_Campos;
            // 
            // empresa
            // 
            empresa.AcceptsReturn = true;
            empresa.AcceptsTab = true;
            empresa.BackColor = Color.WhiteSmoke;
            empresa.CharacterCasing = CharacterCasing.Upper;
            empresa.HideSelection = false;
            empresa.Location = new Point(93, 72);
            empresa.MaxLength = 30;
            empresa.Name = "empresa";
            empresa.PlaceholderText = "MATRIZ";
            empresa.Size = new Size(200, 27);
            empresa.TabIndex = 1;
            empresa.TextAlign = HorizontalAlignment.Center;
            empresa.Leave += checa_Campos;
            // 
            // butFinaliza
            // 
            butFinaliza.Location = new Point(332, 512);
            butFinaliza.Name = "butFinaliza";
            butFinaliza.Size = new Size(94, 29);
            butFinaliza.TabIndex = 8;
            butFinaliza.Text = "Finalizar";
            butFinaliza.UseVisualStyleBackColor = true;
            butFinaliza.Click += butFinaliza_Click;
            // 
            // butVolta
            // 
            butVolta.Location = new Point(50, 512);
            butVolta.Name = "butVolta";
            butVolta.Size = new Size(94, 29);
            butVolta.TabIndex = 0;
            butVolta.Text = "Voltar";
            butVolta.UseVisualStyleBackColor = true;
            butVolta.Click += butVolta_Click;
            // 
            // dadosArq
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 42, 54);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(482, 553);
            Controls.Add(butVolta);
            Controls.Add(butFinaliza);
            Controls.Add(gbArquivo);
            Name = "dadosArq";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dadosArq";
            FormClosed += fechaPrograma;
            gbArquivo.ResumeLayout(false);
            gbArquivo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbArquivo;
        private TextBox dirCopia;
        private TextBox dirBackup;
        private TextBox dias;
        private TextBox caixa;
        private TextBox empresa;
        private Label labelCopia;
        private Label labelBackup;
        private Label labelDias;
        private Label labelCaixa;
        private Label labelEmpresa;
        private Button butBusca2;
        private Button butBusca;
        private Button butFinaliza;
        private Button butVolta;
        private Label label2;
        private Label label1;
    }
}