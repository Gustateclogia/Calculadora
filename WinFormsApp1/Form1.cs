using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form


    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }


        private Operacao OperacaoSelecionado { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
        }

        private void UM_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";

        }

        private void sete_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";

        }

        private void oito_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";

        }

        private void nove_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";

        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void mais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionado = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            txtsinal.Text = "+";




        }

        private void menos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionado = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            txtsinal.Text = "-";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionado = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            txtsinal.Text = "X";
        }

        private void r_Click(object sender, EventArgs e)
        {
            OperacaoSelecionado = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            txtsinal.Text = "/";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionado)
            {

                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtresultado.Text);
                    break;

            }
            txtresultado.Text = Convert.ToString(Resultado);
            txtsinal.Text = "=";
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains(","))
                txtresultado.Text += ",";
        }

        private void limpa_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtsinal.Text = "";
        }

        private void txtsinal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
