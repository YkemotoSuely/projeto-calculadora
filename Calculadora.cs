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

        {   //validação de campos 


            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("O primeiro campo está vazio. Digite um número.");
            } 
           
            else if (!double.TryParse(txtNumero1.Text, out _))
            {
                MessageBox.Show("O primeiro campo contém caracteres inválidos. Digite apenas números.");
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O segundo campo está vazio. Digite um número.");
            }

            else if (!double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show("O segundo campo contém caracteres inválidos. Digite apenas números.");
            }
            /*Explicação:
            string.IsNullOrWhiteSpace(...): verifica se o campo está vazio ou só tem espaços.
            double.TryParse(...): tenta converter o texto para número. Se falhar, significa que o conteúdo não é um número válido.
            Se você quiser aceitar apenas inteiros, pode usar int.TryParse no lugar de double.TryParse.*/

            //Verifica se os campos de entrada estão preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            // Realiza a soma dos números e exibe o resultado
            lblResultado.Text = (numero1 + numero2).ToString();


        }

        private void btnSubtrair_Click(object sender, EventArgs e)

        {
            {   //validação de campos 


                if (string.IsNullOrWhiteSpace(txtNumero1.Text))
                {
                    MessageBox.Show("O primeiro campo está vazio. Digite um número.");
                }

                else if (!double.TryParse(txtNumero1.Text, out _))
                {
                    MessageBox.Show("O primeiro campo contém caracteres inválidos. Digite apenas números.");
                }

                if (string.IsNullOrWhiteSpace(txtNumero2.Text))
                {
                    MessageBox.Show("O segundo campo está vazio. Digite um número.");
                }

                else if (!double.TryParse(txtNumero2.Text, out _))
                {
                    MessageBox.Show("O segundo campo contém caracteres inválidos. Digite apenas números.");
                }

                //Verifica se os campos de entrada estão preenchidos
                double numero1 = Convert.ToDouble(txtNumero1.Text);
                double numero2 = Convert.ToDouble(txtNumero2.Text);

                // Realiza a subtração dos números e exibe o resultado
                lblResultado.Text = (numero1 - numero2).ToString();
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //validação de campos 


            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("O primeiro campo está vazio. Digite um número.");
            }

            else if (!double.TryParse(txtNumero1.Text, out _))
            {
                MessageBox.Show("O primeiro campo contém caracteres inválidos. Digite apenas números.");
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O segundo campo está vazio. Digite um número.");
            }

            else if (!double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show("O segundo campo contém caracteres inválidos. Digite apenas números.");
            }
            //Verifica se os campos de entrada estão preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            //Realiza a multiplicação dos números e exibe o resultado
            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //validação de campos 


            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("O primeiro campo está vazio. Digite um número.");
            }

            else if (!double.TryParse(txtNumero1.Text, out _))
            {
                MessageBox.Show("O primeiro campo contém caracteres inválidos. Digite apenas números.");
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("O segundo campo está vazio. Digite um número.");
            }

            else if (!double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show("O segundo campo contém caracteres inválidos. Digite apenas números.");
            }

            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 / numero2).ToString();
        }
    }
}
