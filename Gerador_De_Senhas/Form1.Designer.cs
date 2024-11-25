namespace Gerador_De_Senhas
{
    partial class GeradorDeSenhas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkMaiusculas = new CheckBox();
            chkMinusculas = new CheckBox();
            chkNumeros = new CheckBox();
            chkEspeciais = new CheckBox();
            btnGerar = new Button();
            txtSenhaGerada = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtComprimento = new TextBox();
            SuspendLayout();
            // 
            // chkMaiusculas
            // 
            chkMaiusculas.AutoSize = true;
            chkMaiusculas.Location = new Point(12, 161);
            chkMaiusculas.Name = "chkMaiusculas";
            chkMaiusculas.Size = new Size(124, 29);
            chkMaiusculas.TabIndex = 0;
            chkMaiusculas.Text = "Maiusculas";
            chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkMinusculas
            // 
            chkMinusculas.AutoSize = true;
            chkMinusculas.Location = new Point(12, 196);
            chkMinusculas.Name = "chkMinusculas";
            chkMinusculas.Size = new Size(125, 29);
            chkMinusculas.TabIndex = 1;
            chkMinusculas.Text = "Minusculas";
            chkMinusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            chkNumeros.AutoSize = true;
            chkNumeros.Location = new Point(12, 231);
            chkNumeros.Name = "chkNumeros";
            chkNumeros.Size = new Size(111, 29);
            chkNumeros.TabIndex = 2;
            chkNumeros.Text = "Numeros";
            chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkEspeciais
            // 
            chkEspeciais.AutoSize = true;
            chkEspeciais.Location = new Point(12, 266);
            chkEspeciais.Name = "chkEspeciais";
            chkEspeciais.Size = new Size(108, 29);
            chkEspeciais.TabIndex = 3;
            chkEspeciais.Text = "Especiais";
            chkEspeciais.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(26, 301);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(117, 35);
            btnGerar.TabIndex = 4;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += button1_Click;
            // 
            // txtSenhaGerada
            // 
            txtSenhaGerada.Location = new Point(12, 124);
            txtSenhaGerada.Name = "txtSenhaGerada";
            txtSenhaGerada.Size = new Size(161, 31);
            txtSenhaGerada.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(276, 24);
            label1.TabIndex = 6;
            label1.Text = "Insira a quantidade de digitos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(131, 24);
            label2.TabIndex = 8;
            label2.Text = "Senha Gerada";
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new Point(12, 63);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(161, 31);
            txtComprimento.TabIndex = 7;
            // 
            // GeradorDeSenhas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 450);
            Controls.Add(label2);
            Controls.Add(txtComprimento);
            Controls.Add(label1);
            Controls.Add(txtSenhaGerada);
            Controls.Add(btnGerar);
            Controls.Add(chkEspeciais);
            Controls.Add(chkNumeros);
            Controls.Add(chkMinusculas);
            Controls.Add(chkMaiusculas);
            Name = "GeradorDeSenhas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMaiusculas;
        private CheckBox chkMinusculas;
        private CheckBox chkNumeros;
        private CheckBox chkEspeciais;
        private Button btnGerar;
        private TextBox txtSenhaGerada;
        private Label label1;
        private Label label2;
        private TextBox txtComprimento;
    }
}
