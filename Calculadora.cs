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
                MessageBox.Show("O primeiro campo est� vazio.Digite um n�mero");
            }

            if (string.IsNullOrEmpty(txtNumero2.Text))
            {
                MessageBox.Show("O segundo campo est� vazio. Digite um n�mero");
            }

                //Verifica se os campos de entrada est�o preenchidos
                double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            // Realiza a soma dos n�meros e exibe o resultado
            lblResultado.Text = (numero1 + numero2).ToString();


        }

        private void btnSubtrair_Click(object sender, EventArgs e)

        {   //Verifica se os campos de entrada est�o preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            // Realiza a subtra��o dos n�meros e exibe o resultado
            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos de entrada est�o preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            //Realiza a multiplica��o dos n�meros e exibe o resultado
            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 / numero2).ToString();
        }
    }
}
