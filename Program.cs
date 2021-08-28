using System;

namespace upn_T1_q_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal salario, salario_temp;
            Int16 temp, number_200bills, number_100bills, number_50bills, number_20bills, number_10bills;
            Console.WriteLine("Cantidad de billetes de 10,20,50,100 y 200 nuevos soles recibirá un empleado como pago por su trabajo");
            Console.Write("Ingrese salario: ");
            salario = Convert.ToDecimal(Console.ReadLine());
            
            temp = Convert.ToInt16(Math.Truncate(salario / 200));
            salario_temp = salario - (temp * 200); 
            number_200bills = temp;

            temp = Convert.ToInt16(Math.Truncate(salario_temp / 100));
            salario_temp = salario_temp - (temp * 100);
            number_100bills = temp;

            temp = Convert.ToInt16(Math.Truncate(salario_temp / 50));
            salario_temp = salario_temp - (temp * 50);
            number_50bills = temp;
            
            temp = Convert.ToInt16(Math.Truncate(salario_temp / 20));
            salario_temp = salario_temp - (temp * 20);
            number_20bills = temp;

            temp = Convert.ToInt16(Math.Truncate(salario_temp / 10));
            salario_temp = salario_temp - (temp * 10);
            number_10bills = temp;

            Console.WriteLine("Cantidad de billetes de 200: " + Convert.ToString(number_200bills));
            Console.WriteLine("Cantidad de billetes de 100: " + Convert.ToString(number_100bills));
            Console.WriteLine("Cantidad de billetes de 50: " + Convert.ToString(number_50bills));
            Console.WriteLine("Cantidad de billetes de 20: " + Convert.ToString(number_20bills));
            Console.WriteLine("Cantidad de billetes de 10: " + Convert.ToString(number_10bills));










        }
    }
}
