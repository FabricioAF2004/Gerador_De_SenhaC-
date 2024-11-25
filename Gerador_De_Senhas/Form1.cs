using System;
using System.Text;
using System.Windows.Forms;


namespace Gerador_De_Senhas
{
    public partial class GeradorDeSenhas : Form
    {
        private object numericUpDownComprimento;
        private object numComprimento;

        public GeradorDeSenhas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se o campo de comprimento não está vazio e é um número válido
            if (string.IsNullOrWhiteSpace(txtComprimento.Text) || !int.TryParse(txtComprimento.Text, out int comprimento) || comprimento <= 0)
            {
                MessageBox.Show("Por favor, insira um comprimento válido para a senha.");
                return;
            }

            // Obtém as configurações dos checkboxes
            bool incluirMaiusculas = chkMaiusculas.Checked;
            bool incluirMinusculas = chkMinusculas.Checked;
            bool incluirNumeros = chkNumeros.Checked;
            bool incluirEspeciais = chkEspeciais.Checked;

            // Gera e exibe a senha
            txtSenhaGerada.Text = GerarSenha(comprimento, incluirMaiusculas, incluirMinusculas, incluirNumeros, incluirEspeciais);
        }

        private string GerarSenha(int comprimento, bool maiusculas, bool minusculas, bool numeros, bool especiais)
        {
            const string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            const string digitos = "0123456789";
            const string caracteresEspeciais = "!@#$%^&*()-_=+[]{}|;:,.<>?";

            StringBuilder caracteres = new StringBuilder();
            if (maiusculas) caracteres.Append(letrasMaiusculas);
            if (minusculas) caracteres.Append(letrasMinusculas);
            if (numeros) caracteres.Append(digitos);
            if (especiais) caracteres.Append(caracteresEspeciais);

            if (caracteres.Length == 0)
                return "Selecione pelo menos uma opção!";

            StringBuilder senha = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < comprimento; i++)
            {
                senha.Append(caracteres[rnd.Next(caracteres.Length)]);
            }

            return senha.ToString();
        }
    }
}
