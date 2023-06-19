using System;
using System.Drawing;
using System.Windows.Forms;

namespace Faculdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal valorAtual = 0.00m;
        private void button1_Click(object sender, EventArgs e)

        {

            decimal salarioMensal, planoSaude, valeTransporte, valeRefeicao, outrosBeneficios;

            if (!decimal.TryParse(txtSalarioMensal.Text, out salarioMensal) ||
                !decimal.TryParse(txtPlanoSaude.Text, out planoSaude) ||
                !decimal.TryParse(txtValeTransporte.Text, out valeTransporte) ||
                !decimal.TryParse(txtValeRefeicao.Text, out valeRefeicao) ||
                !decimal.TryParse(txtOutrosBeneficios.Text, out outrosBeneficios))
            {
                MessageBox.Show("Favor preencher todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preencher os TextBoxes com valores incrementais
         
            // Redefinir o tamanho do Form
            this.Size = new Size(440, 770);

            // Calcular o salário bruto
            decimal salarioBruto = salarioMensal;

            // Calcular o desconto de vale transporte
            decimal descontoValeTransporte = salarioBruto * 0.06m * -1;

            // Calcular as provisões
            decimal provisaoDecimoTerceiro = salarioBruto / 12;
            decimal provisaoFerias = salarioBruto / 3 / 12;

            // Calcular o FGTS
            decimal fgts = salarioBruto * 0.08m;

            // Calcular o INSS
            decimal inss = salarioBruto * 0.20m; // 11% do salário bruto

            // Somar os valores dos textboxes
            decimal somaTextboxes = salarioBruto + valeTransporte + valeRefeicao + planoSaude + outrosBeneficios +
                provisaoDecimoTerceiro + provisaoFerias + fgts + inss;

            // Calcular a provisão de FGTS para o décimo terceiro
            decimal provisaoFGTSDecimoTerceiro = (provisaoDecimoTerceiro + provisaoFerias) * 0.08m; // 8% do total do décimo terceiro e férias

            // Calcular a provisão de INSS para o décimo terceiro
            decimal provisaoINSSDecimoTerceiro = (provisaoDecimoTerceiro + provisaoFerias) * 0.20m; // 20% do total do décimo terceiro e férias

            // Calcular o custo total do funcionário
            decimal custoTotalFuncionario = somaTextboxes + provisaoFGTSDecimoTerceiro + provisaoINSSDecimoTerceiro;
            txtProvisaoFGTSDecimoTerceiro.Text = provisaoFGTSDecimoTerceiro.ToString("C2");
            txtProvisaoINSSDecimoTerceiro.Text = provisaoINSSDecimoTerceiro.ToString("C2");
            txtSalarioBruto.Text = salarioBruto.ToString("C");
            txtValeTransporteEstimativa.Text = valeTransporte.ToString("C");
            txtDescontoValeTransporte.Text = descontoValeTransporte.ToString("C");
            txtValeRefeicaoEstimativa.Text = valeRefeicao.ToString("C");
            txtPlanoSaudeEstimativa.Text = planoSaude.ToString("C");
            txtOutrosBeneficiosEstimativa.Text = outrosBeneficios.ToString("C");
            txtProvisaoDecimoTerceiro.Text = provisaoDecimoTerceiro.ToString("C");
            txtProvisaoFerias.Text = provisaoFerias.ToString("C");
            txtFGTS.Text = fgts.ToString("C");
            txtINSS.Text = inss.ToString("C");

            // Exibir a soma dos textboxes em txtCustoTotalFuncionario
            txtCustoTotalFuncionario.Text = custoTotalFuncionario.ToString("C");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpar todos os textbox selecionado abaixo.
            txtSalarioBruto.Text = string.Empty;
            txtValeTransporteEstimativa.Text = string.Empty;
            txtDescontoValeTransporte.Text = string.Empty;
            txtValeRefeicaoEstimativa.Text = string.Empty;
            txtPlanoSaudeEstimativa.Text = string.Empty;
            txtOutrosBeneficiosEstimativa.Text = string.Empty;
            txtProvisaoDecimoTerceiro.Text = string.Empty;
            txtProvisaoFerias.Text = string.Empty;
            txtFGTS.Text = string.Empty;
            txtINSS.Text = string.Empty;
            txtSalarioMensal.Text = string.Empty;
            txtPlanoSaude.Text = string.Empty;
            txtValeTransporte.Text = string.Empty;
            txtValeRefeicao.Text = string.Empty;
            txtOutrosBeneficios.Text = string.Empty;
            txtCustoTotalFuncionario.Text = String.Empty;
            txtProvisaoINSSDecimoTerceiro.Text = String.Empty;
            txtProvisaoFGTSDecimoTerceiro.Text = String.Empty;
            //definir o tamanho do Form
            this.Size = new Size(440, 285);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
