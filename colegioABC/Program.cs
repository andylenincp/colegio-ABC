using System;

namespace colegioABC
{
    class Program
    {
        static bool validateDecimal(float number)
        {
            string num = number.ToString();
            string[] decimals = num.Split(',');
            if (decimals.Length > 1 && decimals[1].Length > 1)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    float periodOne = 0, periodTwo = 0, periodThree = 0, exam = 0;
                    string message = "";
                    // Primer periodo
                    while (true)
                    {
                        Console.WriteLine("Nota del primer periodo: ");
                        periodOne = Single.Parse(Console.ReadLine());
                        if (periodOne < 0 || periodOne > 10)
                        {
                            Console.WriteLine("La nota no puede ser menor a 0 o mayor a 10");
                        } else if (!validateDecimal(periodOne))
                        {
                            Console.WriteLine("La nota puede tener máximo un decimal");
                        } else
                        {
                            break;
                        }
                    }
                    // Segundo periodo
                    while (true)
                    {
                        Console.WriteLine("Nota del segundo periodo: ");
                        periodTwo = Single.Parse(Console.ReadLine());
                        if (periodTwo < 0 || periodTwo > 10)
                        {
                            Console.WriteLine("La nota no puede ser menor a 0 o mayor a 10");
                        } else if (!validateDecimal(periodTwo))
                        {
                            Console.WriteLine("La nota puede tener máximo un decimal");
                        } else
                        {
                            break;
                        }
                    }
                    // Aprueba o Reprueba
                    if (periodOne > 9 && periodTwo > 9)
                    {
                        message = "APROBADO";
                    } else if (periodOne < 2 && periodTwo < 2)
                    {
                        message = "REPROBADO";
                    } else
                    {
                        // Tercer periodo
                        while (true)
                        {
                            Console.WriteLine("Nota del tercer periodo: ");
                            periodThree = Single.Parse(Console.ReadLine());
                            if (periodThree < 0 || periodThree > 10)
                            {
                                Console.WriteLine("La nota no puede ser menor a 0 o mayor a 10");
                            } else if (!validateDecimal(periodThree))
                            {
                                Console.WriteLine("La nota puede tener máximo un decimal");
                            } else
                            {
                                break;
                            }
                        }
                        // Promedio
                        float average = (periodOne + periodTwo + periodThree)/3;
                        // Aprueba o reprueba
                        if (average < 3)
                        {
                            message = "REPROBADO";
                        } else if (average >= 7)
                        {
                            message = "APROBADO";
                        } else
                        {
                            // Examen de recuperación
                            while (true)
                            {
                                Console.WriteLine("Nota del examen de recuperación: ");
                                exam = Single.Parse(Console.ReadLine());
                                if (exam < 0 || exam > 10)
                                {
                                    Console.WriteLine("La nota no puede ser menor a 0 o mayor a 10");
                                } else if (!validateDecimal(exam))
                                {
                                    Console.WriteLine("La nota puede tener máximo un decimal");
                                } else
                                {
                                    break;
                                }
                            }
                            // Aprueba o Reprueba
                            if (exam < 5)
                            {
                                message = "REPROBADO";
                            } else
                            {
                                message = "APROBADO";
                            }
                        }
                    }
                    Console.WriteLine(message);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error has occurred! {e}");
                }
            }
        }
    }
}
