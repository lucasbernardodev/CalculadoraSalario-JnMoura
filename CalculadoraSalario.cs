using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class CalculadoraSalario
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Calculadora Salário--");
            Console.WriteLine("---Seja bem vindo!---\n");

            Console.Write("Digite o valor que você ganha por hora: R$");
            double qtdPorHora;
            bool validadorQtdPorHora = double.TryParse(Console.ReadLine(), out qtdPorHora);
            while (!validadorQtdPorHora || qtdPorHora <= 0) {
                Console.Write("Por favor, digite um valor válido: R$");
                validadorQtdPorHora = double.TryParse(Console.ReadLine(), out qtdPorHora);
            }


            Console.Write("Agora digite o número de horas trabalhada no mês: ");
            double horasPorMes;
            bool validadorHorasPorMes = double.TryParse(Console.ReadLine(), out horasPorMes);
            while (!validadorHorasPorMes || horasPorMes <= 0)
            {
                Console.Write("Por favor, digite um valor válido: ");
                validadorHorasPorMes = double.TryParse(Console.ReadLine(), out horasPorMes);
            }

            Console.WriteLine("\n--Informações salvas--");
            Console.WriteLine($"Valor da hora trabalhada: R${qtdPorHora:F2}");
            Console.WriteLine($"Quantidade de horas trabalhadas no mês: {horasPorMes} horas\n");

            Console.WriteLine("--Descritivo do salário--");

            double salarioBruto = qtdPorHora * horasPorMes;
            Console.WriteLine($"+ : Salário BRUTO: R${salarioBruto:F2}");

            double valorIr = salarioBruto * 0.11;
            Console.WriteLine($"- : Valor pago ao IR (11%): R${valorIr:F2}");

            double valorInss = salarioBruto * 0.08;
            Console.WriteLine($"- : Valor pago ao INSS (8%): R${valorInss:F2}");

            double valorSindicato = salarioBruto * 0.05;
            Console.WriteLine($"- : Valor pago ao SINDICATO (5%): R${valorSindicato:F2}");

            double desconto = valorIr + valorInss + valorSindicato;
            double salarioLiquido = salarioBruto - desconto;
            Console.WriteLine($"= : Salário Líquido: R${salarioLiquido:F2}\n");

            Console.WriteLine("--Baseado no seguinte cálculo--");
            Console.WriteLine("Salário Bruto - Descontos = Salário Líquido");
            Console.WriteLine($"Sendo R${desconto:F2} o valor total dos descontos\n");

            Console.WriteLine("Digite ENTER para sair do PROGRAMA...");
            Console.ReadLine();
        }
    }
