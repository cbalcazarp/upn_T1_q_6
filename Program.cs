using System;

namespace upn_T1_q_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal salario, salario_temp_1, salario_temp_2;
            Console.WriteLine("Cantidad de billetes de de 10,20,50,100 y 200 nuevos soles recibirá un empleado como pago por su trabajo");
            Console.Write("Ingrese salario: ");
            salario = Convert.ToDecimal(Console.ReadLine());
            salario_temp_1 = Math.Truncate(salario / 200);
            salario_temp_2 = salario - (salario_temp_1 * 200); 
            Console.WriteLine(salario_temp_2);
            
        }
    }
}
