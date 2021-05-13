using System;

namespace IRPF
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o salário");
          
                double sal = double.Parse(Console.ReadLine());
                if (sal < 1) {
                    Console.WriteLine("Salário inválido.");
                    Environment.Exit(0);
                }
                if (sal <= 1903.98)
                {
                    Console.WriteLine("Você contribuirá com R$" + sal);
                }
                else if (sal >= 1903.99 && sal < 2826.65)
                {
                    Console.WriteLine("Você contribuirá com R$" + ( (sal * 0.075) - 142.80));
                }
                else if (sal >= 2826.66 && sal < 3751.05)
                {
                    Console.WriteLine("Você contribuirá com R$" + ((sal * 0.15) - 354.80));
                }
                else if (sal >= 3751.06 && sal < 4664.68)
                {
                    Console.WriteLine("Você contribuirá com R$" + ((sal * 0.225) - 636.13));
                }
                else if(sal > 4664.68)
                {
                    Console.WriteLine("Você contribuirá com R$" + ((sal * 0.275) - 869.36));
                }            
                Environment.Exit(0);
        }
    }
}
