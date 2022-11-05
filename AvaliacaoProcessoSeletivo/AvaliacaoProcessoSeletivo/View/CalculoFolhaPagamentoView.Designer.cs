namespace AvaliacaoProcessoSeletivo.View
{
    partial class CalculoFolhaPagamentoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoFolhaPagamentoView));
            this.textBox_SalarioHora = new System.Windows.Forms.TextBox();
            this.textBox_HorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.label_Funcionario = new System.Windows.Forms.Label();
            this.painelFolhaPagamento = new System.Windows.Forms.Panel();
            this.textBox_SalarioLiquido = new System.Windows.Forms.TextBox();
            this.textBox_DescontoINSS = new System.Windows.Forms.TextBox();
            this.textBox_SalarioBruto = new System.Windows.Forms.TextBox();
            this.comboBox_Funcionarios = new System.Windows.Forms.ComboBox();
            this.label_SalarioLiquido = new System.Windows.Forms.Label();
            this.label_DescontoINSS = new System.Windows.Forms.Label();
            this.label_SalarioBruto = new System.Windows.Forms.Label();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.label_SalarioHora = new System.Windows.Forms.Label();
            this.label_HorasTrabalhadas = new System.Windows.Forms.Label();
            this.painelFolhaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_SalarioHora
            // 
            this.textBox_SalarioHora.Location = new System.Drawing.Point(258, 119);
            this.textBox_SalarioHora.Name = "textBox_SalarioHora";
            this.textBox_SalarioHora.Size = new System.Drawing.Size(216, 23);
            this.textBox_SalarioHora.TabIndex = 1;
            this.textBox_SalarioHora.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_HorasTrabalhadas
            // 
            this.textBox_HorasTrabalhadas.Location = new System.Drawing.Point(36, 119);
            this.textBox_HorasTrabalhadas.Name = "textBox_HorasTrabalhadas";
            this.textBox_HorasTrabalhadas.Size = new System.Drawing.Size(216, 23);
            this.textBox_HorasTrabalhadas.TabIndex = 2;
            // 
            // button_Calcular
            // 
            this.button_Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Calcular.Location = new System.Drawing.Point(505, 118);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(180, 23);
            this.button_Calcular.TabIndex = 3;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // label_Funcionario
            // 
            this.label_Funcionario.AutoSize = true;
            this.label_Funcionario.Location = new System.Drawing.Point(36, 18);
            this.label_Funcionario.Name = "label_Funcionario";
            this.label_Funcionario.Size = new System.Drawing.Size(70, 15);
            this.label_Funcionario.TabIndex = 4;
            this.label_Funcionario.Text = "Funcionário";
            this.label_Funcionario.Click += new System.EventHandler(this.label1_Click);
            // 
            // painelFolhaPagamento
            // 
            this.painelFolhaPagamento.Controls.Add(this.textBox_SalarioLiquido);
            this.painelFolhaPagamento.Controls.Add(this.textBox_DescontoINSS);
            this.painelFolhaPagamento.Controls.Add(this.textBox_SalarioBruto);
            this.painelFolhaPagamento.Controls.Add(this.comboBox_Funcionarios);
            this.painelFolhaPagamento.Controls.Add(this.label_SalarioLiquido);
            this.painelFolhaPagamento.Controls.Add(this.label_DescontoINSS);
            this.painelFolhaPagamento.Controls.Add(this.label_SalarioBruto);
            this.painelFolhaPagamento.Controls.Add(this.label_Resultado);
            this.painelFolhaPagamento.Controls.Add(this.label_SalarioHora);
            this.painelFolhaPagamento.Controls.Add(this.label_HorasTrabalhadas);
            this.painelFolhaPagamento.Controls.Add(this.button_Calcular);
            this.painelFolhaPagamento.Controls.Add(this.label_Funcionario);
            this.painelFolhaPagamento.Controls.Add(this.textBox_HorasTrabalhadas);
            this.painelFolhaPagamento.Controls.Add(this.textBox_SalarioHora);
            this.painelFolhaPagamento.Location = new System.Drawing.Point(35, 21);
            this.painelFolhaPagamento.Name = "painelFolhaPagamento";
            this.painelFolhaPagamento.Size = new System.Drawing.Size(720, 350);
            this.painelFolhaPagamento.TabIndex = 5;
            // 
            // textBox_SalarioLiquido
            // 
            this.textBox_SalarioLiquido.Location = new System.Drawing.Point(152, 309);
            this.textBox_SalarioLiquido.Name = "textBox_SalarioLiquido";
            this.textBox_SalarioLiquido.Size = new System.Drawing.Size(100, 23);
            this.textBox_SalarioLiquido.TabIndex = 14;
            // 
            // textBox_DescontoINSS
            // 
            this.textBox_DescontoINSS.Location = new System.Drawing.Point(152, 271);
            this.textBox_DescontoINSS.Name = "textBox_DescontoINSS";
            this.textBox_DescontoINSS.Size = new System.Drawing.Size(100, 23);
            this.textBox_DescontoINSS.TabIndex = 13;
            // 
            // textBox_SalarioBruto
            // 
            this.textBox_SalarioBruto.Location = new System.Drawing.Point(152, 233);
            this.textBox_SalarioBruto.Name = "textBox_SalarioBruto";
            this.textBox_SalarioBruto.Size = new System.Drawing.Size(100, 23);
            this.textBox_SalarioBruto.TabIndex = 12;
            // 
            // comboBox_Funcionarios
            // 
            this.comboBox_Funcionarios.FormattingEnabled = true;
            this.comboBox_Funcionarios.Location = new System.Drawing.Point(36, 36);
            this.comboBox_Funcionarios.Name = "comboBox_Funcionarios";
            this.comboBox_Funcionarios.Size = new System.Drawing.Size(649, 23);
            this.comboBox_Funcionarios.TabIndex = 11;
            this.comboBox_Funcionarios.SelectedIndexChanged += new System.EventHandler(this.comboBox_Funcionarios_SelectedIndexChanged);
            this.comboBox_Funcionarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox_Funcionarios_MouseDown);
            // 
            // label_SalarioLiquido
            // 
            this.label_SalarioLiquido.AutoSize = true;
            this.label_SalarioLiquido.Location = new System.Drawing.Point(36, 312);
            this.label_SalarioLiquido.Name = "label_SalarioLiquido";
            this.label_SalarioLiquido.Size = new System.Drawing.Size(88, 15);
            this.label_SalarioLiquido.TabIndex = 10;
            this.label_SalarioLiquido.Text = "Salário Liquido:";
            // 
            // label_DescontoINSS
            // 
            this.label_DescontoINSS.AutoSize = true;
            this.label_DescontoINSS.Location = new System.Drawing.Point(36, 274);
            this.label_DescontoINSS.Name = "label_DescontoINSS";
            this.label_DescontoINSS.Size = new System.Drawing.Size(87, 15);
            this.label_DescontoINSS.TabIndex = 9;
            this.label_DescontoINSS.Text = "Desconto INSS:";
            this.label_DescontoINSS.Click += new System.EventHandler(this.label_DescontoINSS_Click);
            // 
            // label_SalarioBruto
            // 
            this.label_SalarioBruto.AutoSize = true;
            this.label_SalarioBruto.Location = new System.Drawing.Point(36, 236);
            this.label_SalarioBruto.Name = "label_SalarioBruto";
            this.label_SalarioBruto.Size = new System.Drawing.Size(77, 15);
            this.label_SalarioBruto.TabIndex = 8;
            this.label_SalarioBruto.Text = "Salario Bruto:";
            this.label_SalarioBruto.Click += new System.EventHandler(this.label_SalarioBruto_Click);
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(36, 184);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(59, 15);
            this.label_Resultado.TabIndex = 7;
            this.label_Resultado.Text = "Resultado";
            this.label_Resultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_SalarioHora
            // 
            this.label_SalarioHora.AutoSize = true;
            this.label_SalarioHora.Location = new System.Drawing.Point(258, 101);
            this.label_SalarioHora.Name = "label_SalarioHora";
            this.label_SalarioHora.Size = new System.Drawing.Size(90, 15);
            this.label_SalarioHora.TabIndex = 6;
            this.label_SalarioHora.Text = "Salário por hora";
            // 
            // label_HorasTrabalhadas
            // 
            this.label_HorasTrabalhadas.AutoSize = true;
            this.label_HorasTrabalhadas.Location = new System.Drawing.Point(36, 101);
            this.label_HorasTrabalhadas.Name = "label_HorasTrabalhadas";
            this.label_HorasTrabalhadas.Size = new System.Drawing.Size(163, 15);
            this.label_HorasTrabalhadas.TabIndex = 5;
            this.label_HorasTrabalhadas.Text = "Número de horas trabalhadas";
            this.label_HorasTrabalhadas.Click += new System.EventHandler(this.label2_Click);
            // 
            // CalculoFolhaPagamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.painelFolhaPagamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculoFolhaPagamentoView";
            this.ShowIcon = false;
            this.Text = "CalculoFolhaPagamento";
            this.Load += new System.EventHandler(this.CalculoFolhaPagamento_Load);
            this.painelFolhaPagamento.ResumeLayout(false);
            this.painelFolhaPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel painelFolhaPagamento;
        private TextBox textBox_SalarioHora;
        private TextBox textBox_HorasTrabalhadas;
        private Button button_Calcular;
        private Label label_Funcionario;
        private Label label_SalarioHora;
        private Label label_HorasTrabalhadas;
        private Label label_SalarioLiquido;
        private Label label_DescontoINSS;
        private Label label_SalarioBruto;
        private Label label_Resultado;
        private ComboBox comboBox_Funcionarios;
        private TextBox textBox_SalarioLiquido;
        private TextBox textBox_DescontoINSS;
        private TextBox textBox_SalarioBruto;
    }
}