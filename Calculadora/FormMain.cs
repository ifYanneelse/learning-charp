namespace Calculadora
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void btnSomar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = n1 + n2;
            lblResultado.Text = resultado.ToString("F2"); //f2 = 2 casas decimais
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = n1 - n2;
            lblResultado.Text = resultado.ToString("F2"); //f2 = 2 casas decimais
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = n1 * n2;
            lblResultado.Text = resultado.ToString("F2"); //f2 = 2 casas decimais
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = n1 / n2;
            lblResultado.Text = resultado.ToString("F2"); //f2 = 2 casas decimais
        }
    }
}