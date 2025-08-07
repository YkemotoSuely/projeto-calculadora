using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Caclculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)

        {   //valida��o de campos 


            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("O primeiro campo est� vazio. Digite um n�mero.");
            } 
           
            else if (!double.TryParse(txtNumero1.Text, out _))
            {
                MessageBox.Show("O primeiro campo cont�m caracteres inv�lidos. Digite apenas n�meros.");
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O segundo campo est� vazio. Digite um n�mero.");
            }

            else if (!double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show("O segundo campo cont�m caracteres inv�lidos. Digite apenas n�meros.");
            }
            /*Explica��o:
            string.IsNullOrWhiteSpace(...): verifica se o campo est� vazio ou s� tem espa�os.
            double.TryParse(...): tenta converter o texto para n�mero. Se falhar, significa que o conte�do n�o � um n�mero v�lido.
            Se voc� quiser aceitar apenas inteiros, pode usar int.TryParse no lugar de double.TryParse.*/

            //Verifica se os campos de entrada est�o preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            // Realiza a soma dos n�meros e exibe o resultado
            lblResultado.Text = (numero1 + numero2).ToString();


        }

        private void btnSubtrair_Click(object sender, EventArgs e)

        {
            {   //valida��o de campos 


                if (string.IsNullOrWhiteSpace(txtNumero1.Text))
                {
                    MessageBox.Show("O primeiro campo est� vazio. Digite um n�mero.");
                }

                else if (!double.TryParse(txtNumero1.Text, out _))
                {
                    MessageBox.Show("O primeiro campo cont�m caracteres inv�lidos. Digite apenas n�meros.");
                }

                if (string.IsNullOrWhiteSpace(txtNumero2.Text))
                {
                    MessageBox.Show("O segundo campo est� vazio. Digite um n�mero.");
                }

                else if (!double.TryParse(txtNumero2.Text, out _))
                {
                    MessageBox.Show("O segundo campo cont�m caracteres inv�lidos. Digite apenas n�meros.");
                }

                //Verifica se os campos de entrada est�o preenchidos
                double numero1 = Convert.ToDouble(txtNumero1.Text);
                double numero2 = Convert.ToDouble(txtNumero2.Text);

                // Realiza a subtra��o dos n�meros e exibe o resultado
                lblResultado.Text = (numero1 - numero2).ToString();
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //valida��o de campos 


            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("O primeiro campo est� vazio. Digite um n�mero.");
            }

            else if (!double.TryParse(txtNumero1.Text, out _))
            {
                MessageBox.Show("O primeiro campo cont�m caracteres inv�lidos. Digite apenas n�meros.");
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O segundo campo est� vazio. Digite um n�mero.");
            }

            else if (!double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show("O segundo campo cont�m caracteres inv�lidos. Digite apenas n�meros.");
            }
            //Verifica se os campos de entrada est�o preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            //Realiza a multiplica��o dos n�meros e exibe o resultado
            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //valida��o de campos 


            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("O primeiro campo est� vazio. Digite um n�mero.");
            }

            else if (!double.TryParse(txtNumero1.Text, out _))
            {
                MessageBox.Show("O primeiro campo cont�m caracteres inv�lidos. Digite apenas n�meros.");
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O segundo campo est� vazio. Digite um n�mero.");
            }

            else if (!double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show("O segundo campo cont�m caracteres inv�lidos. Digite apenas n�meros.");
            }

            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 / numero2).ToString();
        }
    }
}
