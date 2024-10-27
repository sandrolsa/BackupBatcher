using System.Runtime.CompilerServices;

namespace Teste_1
{
    partial class BackupBatcher
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupBatcher));
            criaBat = new Button();
            editaBat = new Button();
            excluiBat = new Button();
            backupTitulo = new Label();
            sair = new Button();
            gbPrincipal = new GroupBox();
            gbPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // criaBat
            // 
            criaBat.BackColor = Color.FromArgb(98, 114, 164);
            resources.ApplyResources(criaBat, "criaBat");
            criaBat.FlatAppearance.BorderColor = Color.FromArgb(80, 250, 123);
            criaBat.FlatAppearance.BorderSize = 2;
            criaBat.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 250, 123);
            criaBat.ForeColor = Color.FromArgb(68, 71, 90);
            criaBat.Name = "criaBat";
            criaBat.UseVisualStyleBackColor = false;
            criaBat.Click += criaBat_Click;
            // 
            // editaBat
            // 
            editaBat.BackColor = Color.FromArgb(98, 114, 164);
            resources.ApplyResources(editaBat, "editaBat");
            editaBat.FlatAppearance.BorderColor = Color.FromArgb(80, 250, 123);
            editaBat.FlatAppearance.BorderSize = 2;
            editaBat.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 250, 123);
            editaBat.ForeColor = Color.FromArgb(68, 71, 90);
            editaBat.Name = "editaBat";
            editaBat.UseVisualStyleBackColor = false;
            editaBat.Click += editaBat_Click;
            // 
            // excluiBat
            // 
            excluiBat.BackColor = Color.FromArgb(98, 114, 164);
            resources.ApplyResources(excluiBat, "excluiBat");
            excluiBat.FlatAppearance.BorderColor = Color.FromArgb(80, 250, 123);
            excluiBat.FlatAppearance.BorderSize = 2;
            excluiBat.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 250, 123);
            excluiBat.ForeColor = Color.FromArgb(68, 71, 90);
            excluiBat.Name = "excluiBat";
            excluiBat.UseVisualStyleBackColor = false;
            excluiBat.Click += excluiBat_Click;
            // 
            // backupTitulo
            // 
            resources.ApplyResources(backupTitulo, "backupTitulo");
            backupTitulo.FlatStyle = FlatStyle.Flat;
            backupTitulo.ForeColor = Color.FromArgb(80, 250, 123);
            backupTitulo.Name = "backupTitulo";
            // 
            // sair
            // 
            sair.BackColor = Color.FromArgb(68, 71, 90);
            resources.ApplyResources(sair, "sair");
            sair.ForeColor = Color.FromArgb(98, 114, 164);
            sair.Name = "sair";
            sair.UseVisualStyleBackColor = false;
            sair.Click += sair_Click;
            // 
            // gbPrincipal
            // 
            resources.ApplyResources(gbPrincipal, "gbPrincipal");
            gbPrincipal.Controls.Add(criaBat);
            gbPrincipal.Controls.Add(editaBat);
            gbPrincipal.Controls.Add(excluiBat);
            gbPrincipal.Name = "gbPrincipal";
            gbPrincipal.TabStop = false;
            // 
            // BackupBatcher
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(40, 42, 54);
            Controls.Add(sair);
            Controls.Add(backupTitulo);
            Controls.Add(gbPrincipal);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BackupBatcher";
            FormClosed += fechaPrograma;
            gbPrincipal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button criaBat;
        private Button editaBat;
        private Button excluiBat;
        private Label backupTitulo;
        private Button sair;
        private GroupBox gbPrincipal;
    }
}
