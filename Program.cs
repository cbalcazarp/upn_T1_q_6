using System;

namespace upn_T1_q_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal salario, salario1;
            Console.WriteLine("Cantidad de billetes de de 10,20,50,100 y 200 nuevos soles recibirá un empleado como pago por su trabajo");
            Console.Write("Ingrese salario: ");
            salario = Convert.ToDecimal(Console.ReadLine());
            salario1 = Math.Truncate(salario);
            Console.WriteLine(salario1);
            
        }
    }
}
