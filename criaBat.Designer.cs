namespace Teste_1
{
    partial class criaBat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criaBat));
            butCancela = new Button();
            gbCriaBat = new GroupBox();
            butDbmysql = new Button();
            butTesta = new Button();
            senha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            banco = new TextBox();
            servidor = new TextBox();
            usuario = new TextBox();
            butProximo = new Button();
            gbCriaBat.SuspendLayout();
            SuspendLayout();
            // 
            // butCancela
            // 
            butCancela.Font = new Font("Segoe UI", 9F);
            butCancela.Location = new Point(50, 512);
            butCancela.Name = "butCancela";
            butCancela.Size = new Size(94, 29);
            butCancela.TabIndex = 0;
            butCancela.Text = "Cancelar";
            butCancela.UseVisualStyleBackColor = true;
            butCancela.Click += butCancela_Click;
            // 
            // gbCriaBat
            // 
            gbCriaBat.Controls.Add(butDbmysql);
            gbCriaBat.Controls.Add(butTesta);
            gbCriaBat.Controls.Add(senha);
            gbCriaBat.Controls.Add(label4);
            gbCriaBat.Controls.Add(label3);
            gbCriaBat.Controls.Add(label2);
            gbCriaBat.Controls.Add(label1);
            gbCriaBat.Controls.Add(banco);
            gbCriaBat.Controls.Add(servidor);
            gbCriaBat.Controls.Add(usuario);
            gbCriaBat.Font = new Font("Segoe UI", 9F);
            gbCriaBat.ForeColor = Color.FromArgb(80, 250, 123);
            gbCriaBat.Location = new Point(50, 37);
            gbCriaBat.Name = "gbCriaBat";
            gbCriaBat.Size = new Size(376, 440);
            gbCriaBat.TabIndex = 1;
            gbCriaBat.TabStop = false;
            gbCriaBat.Text = "Conexão";
            // 
            // butDbmysql
            // 
            butDbmysql.BackColor = Color.FromArgb(98, 114, 164);
            butDbmysql.FlatAppearance.BorderColor = Color.FromArgb(80, 250, 123);
            butDbmysql.FlatStyle = FlatStyle.Popup;
            butDbmysql.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butDbmysql.Location = new Point(86, 374);
            butDbmysql.Name = "butDbmysql";
            butDbmysql.Size = new Size(94, 29);
            butDbmysql.TabIndex = 5;
            butDbmysql.Text = "DbMysql";
            butDbmysql.UseVisualStyleBackColor = false;
            butDbmysql.Click += butDbmysql_Click;
            // 
            // butTesta
            // 
            butTesta.BackColor = Color.FromArgb(98, 114, 164);
            butTesta.FlatAppearance.BorderColor = Color.FromArgb(80, 250, 123);
            butTesta.FlatStyle = FlatStyle.Popup;
            butTesta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butTesta.Location = new Point(186, 374);
            butTesta.Name = "butTesta";
            butTesta.Size = new Size(94, 29);
            butTesta.TabIndex = 6;
            butTesta.Text = "Testar";
            butTesta.UseVisualStyleBackColor = false;
            butTesta.Click += butTesta_Click;
            // 
            // senha
            // 
            senha.AcceptsReturn = true;
            senha.AcceptsTab = true;
            senha.BackColor = Color.WhiteSmoke;
            senha.HideSelection = false;
            senha.Location = new Point(86, 314);
            senha.MaxLength = 20;
            senha.Name = "senha";
            senha.PasswordChar = '●';
            senha.PlaceholderText = "123456";
            senha.Size = new Size(200, 27);
            senha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 291);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 9;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 207);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 13;
            label3.Text = "Banco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 126);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 14;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 43);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 15;
            label1.Text = "Hospedagem";
            // 
            // banco
            // 
            banco.AcceptsReturn = true;
            banco.AcceptsTab = true;
            banco.BackColor = Color.WhiteSmoke;
            banco.CharacterCasing = CharacterCasing.Lower;
            banco.Location = new Point(86, 230);
            banco.MaxLength = 30;
            banco.Name = "banco";
            banco.PlaceholderText = "pdvserver";
            banco.Size = new Size(200, 27);
            banco.TabIndex = 3;
            banco.Leave += checa_Campos;
            // 
            // servidor
            // 
            servidor.AcceptsReturn = true;
            servidor.AcceptsTab = true;
            servidor.BackColor = Color.WhiteSmoke;
            servidor.CharacterCasing = CharacterCasing.Lower;
            servidor.Location = new Point(86, 66);
            servidor.MaxLength = 30;
            servidor.Name = "servidor";
            servidor.PlaceholderText = "localhost";
            servidor.Size = new Size(200, 27);
            servidor.TabIndex = 1;
            servidor.Leave += checa_Campos;
            // 
            // usuario
            // 
            usuario.AcceptsReturn = true;
            usuario.AcceptsTab = true;
            usuario.BackColor = Color.WhiteSmoke;
            usuario.Location = new Point(86, 149);
            usuario.MaxLength = 30;
            usuario.Name = "usuario";
            usuario.PlaceholderText = "root";
            usuario.Size = new Size(200, 27);
            usuario.TabIndex = 2;
            usuario.Leave += checa_Campos;
            // 
            // butProximo
            // 
            butProximo.Font = new Font("Segoe UI", 9F);
            butProximo.Location = new Point(332, 512);
            butProximo.Name = "butProximo";
            butProximo.Size = new Size(94, 29);
            butProximo.TabIndex = 7;
            butProximo.Text = "Próximo";
            butProximo.UseVisualStyleBackColor = true;
            butProximo.Click += butProximo_Click;
            // 
            // criaBat
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 42, 54);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(482, 553);
            Controls.Add(butProximo);
            Controls.Add(gbCriaBat);
            Controls.Add(butCancela);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "criaBat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup Batcher";
            gbCriaBat.ResumeLayout(false);
            gbCriaBat.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private Button butCancela;
        private GroupBox gbCriaBat;
        private TextBox banco;
        private TextBox usuario;
        private TextBox servidor;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox senha;
        private Button butDbmysql;
        private Button butTesta;
        private Button butProximo;
    }
}