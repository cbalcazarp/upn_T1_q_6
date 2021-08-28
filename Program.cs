using System;

namespace upn_T1_q_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal salario, salario_temp;
            Int16 temp;
            Console.WriteLine("Cantidad de billetes de de 10,20,50,100 y 200 nuevos soles recibirá un empleado como pago por su trabajo");
            Console.Write("Ingrese salario: ");
            salario = Convert.ToDecimal(Console.ReadLine());
            
            temp = Convert.ToInt16(Math.Truncate(salario / 200));
            salario_temp = salario - (temp * 200); 
            number_200bills

            temp = Convert.ToInt16(Math.Truncate(salario_temp / 100));
            salario_temp = salario_temp - (temp * 100);

            temp = Convert.ToInt16(Math.Truncate(salario_temp / 50));
            salario_temp = salario_temp - (temp * 50);
            
            temp = Convert.ToInt16(Math.Truncate(salario_temp / 20));
            salario_temp = salario_temp - (temp * 20);

            temp = Convert.ToInt16(Math.Truncate(salario_temp / 10));
            salario_temp = salario_temp - (temp * 10);




        }
    }
}
