namespace AvaliacaoProcessoSeletivo.View
{
    partial class CadastroDeFuncionariosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeFuncionariosView));
            this.painelCadastroFuncionarios = new System.Windows.Forms.Panel();
            this.maskedTextBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label_Telefone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Endereco = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.button_VoltarFuncionario = new System.Windows.Forms.Button();
            this.button_UltimoFuncionario = new System.Windows.Forms.Button();
            this.button_ProximoFuncionario = new System.Windows.Forms.Button();
            this.button_PrimeiroFuncionario = new System.Windows.Forms.Button();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.button_Incluir = new System.Windows.Forms.Button();
            this.textBox_Endereco = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.painelCadastroFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCadastroFuncionarios
            // 
            this.painelCadastroFuncionarios.Controls.Add(this.maskedTextBox_CPF);
            this.painelCadastroFuncionarios.Controls.Add(this.maskedTextBox_Telefone);
            this.painelCadastroFuncionarios.Controls.Add(this.label_Telefone);
            this.painelCadastroFuncionarios.Controls.Add(this.label_Email);
            this.painelCadastroFuncionarios.Controls.Add(this.label_Endereco);
            this.painelCadastroFuncionarios.Controls.Add(this.label_CPF);
            this.painelCadastroFuncionarios.Controls.Add(this.label_Nome);
            this.painelCadastroFuncionarios.Controls.Add(this.button_VoltarFuncionario);
            this.painelCadastroFuncionarios.Controls.Add(this.button_UltimoFuncionario);
            this.painelCadastroFuncionarios.Controls.Add(this.button_ProximoFuncionario);
            this.painelCadastroFuncionarios.Controls.Add(this.button_PrimeiroFuncionario);
            this.painelCadastroFuncionarios.Controls.Add(this.button_Excluir);
            this.painelCadastroFuncionarios.Controls.Add(this.button_Salvar);
            this.painelCadastroFuncionarios.Controls.Add(this.button_Incluir);
            this.painelCadastroFuncionarios.Controls.Add(this.textBox_Endereco);
            this.painelCadastroFuncionarios.Controls.Add(this.textBox_Email);
            this.painelCadastroFuncionarios.Controls.Add(this.textBox_Nome);
            this.painelCadastroFuncionarios.Location = new System.Drawing.Point(31, 29);
            this.painelCadastroFuncionarios.Name = "painelCadastroFuncionarios";
            this.painelCadastroFuncionarios.Size = new System.Drawing.Size(720, 350);
            this.painelCadastroFuncionarios.TabIndex = 0;
            this.painelCadastroFuncionarios.Paint += new System.Windows.Forms.PaintEventHandler(this.painelCadastroFuncionarios_Paint);
            // 
            // maskedTextBox_CPF
            // 
            this.maskedTextBox_CPF.Location = new System.Drawing.Point(472, 36);
            this.maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            this.maskedTextBox_CPF.Size = new System.Drawing.Size(212, 23);
            this.maskedTextBox_CPF.TabIndex = 69;
            this.maskedTextBox_CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_CPF_MaskInputRejected);
            // 
            // maskedTextBox_Telefone
            // 
            this.maskedTextBox_Telefone.Location = new System.Drawing.Point(473, 206);
            this.maskedTextBox_Telefone.Name = "maskedTextBox_Telefone";
            this.maskedTextBox_Telefone.Size = new System.Drawing.Size(211, 23);
            this.maskedTextBox_Telefone.TabIndex = 70;
            // 
            // label_Telefone
            // 
            this.label_Telefone.AutoSize = true;
            this.label_Telefone.Location = new System.Drawing.Point(472, 188);
            this.label_Telefone.Name = "label_Telefone";
            this.label_Telefone.Size = new System.Drawing.Size(51, 15);
            this.label_Telefone.TabIndex = 67;
            this.label_Telefone.Text = "Telefone";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(36, 188);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(36, 15);
            this.label_Email.TabIndex = 66;
            this.label_Email.Text = "Email";
            // 
            // label_Endereco
            // 
            this.label_Endereco.AutoSize = true;
            this.label_Endereco.Location = new System.Drawing.Point(36, 101);
            this.label_Endereco.Name = "label_Endereco";
            this.label_Endereco.Size = new System.Drawing.Size(56, 15);
            this.label_Endereco.TabIndex = 65;
            this.label_Endereco.Text = "Endereço";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(472, 18);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(28, 15);
            this.label_CPF.TabIndex = 64;
            this.label_CPF.Text = "CPF";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(36, 18);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(40, 15);
            this.label_Nome.TabIndex = 63;
            this.label_Nome.Text = "Nome";
            // 
            // button_VoltarFuncionario
            // 
            this.button_VoltarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_VoltarFuncionario.Location = new System.Drawing.Point(529, 297);
            this.button_VoltarFuncionario.Name = "button_VoltarFuncionario";
            this.button_VoltarFuncionario.Size = new System.Drawing.Size(44, 35);
            this.button_VoltarFuncionario.TabIndex = 62;
            this.button_VoltarFuncionario.Text = "<";
            this.button_VoltarFuncionario.UseVisualStyleBackColor = true;
            this.button_VoltarFuncionario.Click += new System.EventHandler(this.button_VoltarFuncionario_Click);
            // 
            // button_UltimoFuncionario
            // 
            this.button_UltimoFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UltimoFuncionario.Location = new System.Drawing.Point(641, 297);
            this.button_UltimoFuncionario.Name = "button_UltimoFuncionario";
            this.button_UltimoFuncionario.Size = new System.Drawing.Size(44, 35);
            this.button_UltimoFuncionario.TabIndex = 61;
            this.button_UltimoFuncionario.Text = ">>";
            this.button_UltimoFuncionario.UseVisualStyleBackColor = true;
            this.button_UltimoFuncionario.Click += new System.EventHandler(this.button_UltimoFuncionario_Click);
            // 
            // button_ProximoFuncionario
            // 
            this.button_ProximoFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ProximoFuncionario.Location = new System.Drawing.Point(588, 297);
            this.button_ProximoFuncionario.Name = "button_ProximoFuncionario";
            this.button_ProximoFuncionario.Size = new System.Drawing.Size(44, 35);
            this.button_ProximoFuncionario.TabIndex = 60;
            this.button_ProximoFuncionario.Text = ">";
            this.button_ProximoFuncionario.UseVisualStyleBackColor = true;
            this.button_ProximoFuncionario.Click += new System.EventHandler(this.button_ProximoFuncionario_Click);
            // 
            // button_PrimeiroFuncionario
            // 
            this.button_PrimeiroFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PrimeiroFuncionario.Location = new System.Drawing.Point(472, 297);
            this.button_PrimeiroFuncionario.Name = "button_PrimeiroFuncionario";
            this.button_PrimeiroFuncionario.Size = new System.Drawing.Size(44, 35);
            this.button_PrimeiroFuncionario.TabIndex = 59;
            this.button_PrimeiroFuncionario.Text = "<<";
            this.button_PrimeiroFuncionario.UseVisualStyleBackColor = true;
            this.button_PrimeiroFuncionario.Click += new System.EventHandler(this.button_PrimeiroFuncionario_Click);
            // 
            // button_Excluir
            // 
            this.button_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Excluir.Location = new System.Drawing.Point(287, 297);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(99, 35);
            this.button_Excluir.TabIndex = 58;
            this.button_Excluir.Text = "Excluir";
            this.button_Excluir.UseVisualStyleBackColor = true;
            this.button_Excluir.Click += new System.EventHandler(this.button_Excluir_Click);
            // 
            // button_Salvar
            // 
            this.button_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Salvar.Location = new System.Drawing.Point(164, 297);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(99, 35);
            this.button_Salvar.TabIndex = 57;
            this.button_Salvar.Text = "Salvar";
            this.button_Salvar.UseVisualStyleBackColor = true;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // button_Incluir
            // 
            this.button_Incluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Incluir.Location = new System.Drawing.Point(36, 297);
            this.button_Incluir.Name = "button_Incluir";
            this.button_Incluir.Size = new System.Drawing.Size(99, 35);
            this.button_Incluir.TabIndex = 56;
            this.button_Incluir.Text = "Incluir";
            this.button_Incluir.UseVisualStyleBackColor = true;
            this.button_Incluir.Click += new System.EventHandler(this.button_Incluir_Click_1);
            // 
            // textBox_Endereco
            // 
            this.textBox_Endereco.Location = new System.Drawing.Point(36, 119);
            this.textBox_Endereco.Name = "textBox_Endereco";
            this.textBox_Endereco.Size = new System.Drawing.Size(649, 23);
            this.textBox_Endereco.TabIndex = 55;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(36, 206);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(399, 23);
            this.textBox_Email.TabIndex = 54;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(36, 36);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(399, 23);
            this.textBox_Nome.TabIndex = 51;
            this.textBox_Nome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // CadastroDeFuncionariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.painelCadastroFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroDeFuncionariosView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "CadastroDeFuncionarios";
            this.Load += new System.EventHandler(this.CadastroDeFuncionarios_Load);
            this.painelCadastroFuncionarios.ResumeLayout(false);
            this.painelCadastroFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel painelCadastroFuncionarios;
        private Label label_Telefone;
        private Label label_Email;
        private Label label_Endereco;
        private Label label_CPF;
        private Label label_Nome;
        private Button button_VoltarFuncionario;
        private Button button_UltimoFuncionario;
        private Button button_ProximoFuncionario;
        private Button button_PrimeiroFuncionario;
        private Button button_Excluir;
        private Button button_Salvar;
        private Button button_Incluir;
        private TextBox textBox_Endereco;
        private TextBox textBox_Email;
        private TextBox textBox_Nome;
        private MaskedTextBox maskedTextBox_Telefone;
        private MaskedTextBox maskedTextBox_CPF;
    }
}