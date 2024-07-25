// Simulador de compra na maquininha de cartão
using System;
using System.Globalization;

namespace MaquininhaDeCartao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da compra: R$");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("[1] Para pagamento em Debito ");
            Console.WriteLine("[2] Para pagamento em credito ");
            Console.WriteLine("[3] Para pagamento em pix ( 10% De desconto ) ");
            int escolha = int.Parse(Console.ReadLine());
            while ((escolha < 1) || (escolha > 3))
            {
                Console.WriteLine("Opção Inválida!");
                Console.WriteLine("");
                Console.WriteLine("[1] Para pagamento em Debito ");
                Console.WriteLine("[2] Para pagamento em credito ");
                Console.WriteLine("[3] Para pagamento em pix ( 10% De desconto ) ");
                escolha = int.Parse(Console.ReadLine());

            }

            if (escolha == 1)
            {
                Console.WriteLine("Pagamento no Debito no valor de {0} realizado com sucesso \n",valor);
                Console.WriteLine("Obrigado, volte sempre!");
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Deseja parcelar [S/N]");
                char parcelamento = char.Parse(Console.ReadLine());
                while ((parcelamento != 'S' || parcelamento != 's') && (parcelamento != 's' || parcelamento != 's'))
                {
                    Console.WriteLine("Opção Inválida!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Deseja parcelar [S/N]");
                    parcelamento = char.Parse(Console.ReadLine());
                }
                if (parcelamento == 'n' || parcelamento == 'N')
                {
                    Console.WriteLine("Compra no valor de R${0} no credito realizado com sucesso\n", valor);
                    Console.WriteLine("Obrigado, volte sempre!");
                }
                else
                {
                    Console.WriteLine("Digite o numero de parcelas: ");
                    int parcela = int.Parse(Console.ReadLine());
                    double valorparcelado = valor / (double)parcela;
                    Console.WriteLine("O valor da compra é de R${2}\n parcela de {1} X R${0:F2}", valorparcelado, parcela, valor);
                }

            }
            else
            {
                valor = valor - (valor / 10);
                Console.WriteLine("Valor da compra Pix teve desconto de 10% \nTotal é de R${0:f2}",valor);
            }
        }
    }
}

