using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();

        while (true)
        {


            {
                //Wybór zadania

                Console.WriteLine(" Podaj numer zadania ");
                Console.WriteLine(" 1. Prosty kalkulator dwóch liczb ");
                Console.WriteLine(" 2. Konwerter temperatur (Celsjusz ↔ Fahrenheit)");
                Console.WriteLine(" 3. Średnia ocen ucznia ");
                Console.WriteLine();

                string? wybor = Console.ReadLine();

                if (wybor == "1")
                {


                    {


                        Console.WriteLine();
                        Console.WriteLine(" Uruchamiam zadnie z kalkulatorem ");
                        Console.WriteLine();

                        Console.WriteLine("Wybierz operację: 1(+) 2(-) 3(*) 4(/) ");
                        Console.WriteLine();

                        string? operacja = Console.ReadLine();



                        if (operacja == "1" || operacja == "2" || operacja == "3" || operacja == "4")
                        {

                            Console.WriteLine(" Podaj liczbę a ");
                            double a = double.Parse(Console.ReadLine()!);

                            Console.WriteLine(" Podaj liczbę b ");
                            double b = double.Parse(Console.ReadLine()!);



                            if (operacja == "1")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"A + B = {a + b} ");
                                Console.WriteLine();
                            }


                            else if (operacja == "2")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"A - B = {a - b} ");
                                Console.WriteLine($"B - A = {b - a} ");
                                Console.WriteLine();

                            }

                            else if (operacja == "3")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"A * B = {a * b} ");
                                Console.WriteLine();
                            }

                            else if (operacja == "4")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"A / B = {a / b} ");
                                Console.WriteLine($"B / A = {b / a} ");
                                Console.WriteLine();
                            }



                        }

                        else
                        {
                            Console.WriteLine(" Wpisz poprawną liczbę ! ");
                            Console.WriteLine();
                        }


                    }

                }

                else if (wybor == "2")
                {

                    {

                        Console.WriteLine();
                        Console.WriteLine(" \n Uruchamiam zadanie z konwerterem temperatury ");
                        Console.WriteLine(" \n Wpisz c jeśli chcesz przeliczyć stopnie Celsjusza na Fahrenheity ");
                        Console.WriteLine(" \n Wpisz f jeśli chce przeliczyć stopnie Fahrenheita na Celsjusze ");
                        Console.WriteLine();

                        string? temp = Console.ReadLine();

                        if (temp == "c")
                        {
                            Console.WriteLine(" Podaj temp w Celcjuszach ");
                            double c = double.Parse(Console.ReadLine()!);
                            Console.WriteLine();

                            Console.WriteLine($"Temperatura w Fahrenheitach to: {c * 1.8 + 32} ");
                            Console.WriteLine();


                        }

                        else if (temp == "f")
                        {
                            Console.WriteLine(" Podaj temp w Fahrenheitach ");
                            double f = double.Parse(Console.ReadLine()!);
                            Console.WriteLine();

                            Console.WriteLine($"Temperatura w Celcjuszach to: {(f - 32) / (1.8)}");
                            Console.WriteLine();

                        }

                        else
                        {
                            Console.WriteLine(" Wpisz poprawną literę ! ");
                            Console.WriteLine();
                        }

                    }

                }

                else if (wybor == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine(" \n Uruchamiam zadanie z Średnia ocen ucznia ");
                    Console.WriteLine(" Podaj liczbę ocen ");

                    int iloscOcen = int.Parse(Console.ReadLine()!);

                    double suma = 0;


                    for (int i = 0; i < iloscOcen; i++)
                    {
                        Console.WriteLine(" Podaj ocenę ");
                        double ocena = double.Parse(Console.ReadLine()!);
                        suma = suma + ocena;

                    }



                    Console.WriteLine($" Średnia ocen ucznia to: {(suma) / (iloscOcen)}");
                    Console.WriteLine();


                    double srednia = suma / iloscOcen;

                    if (srednia >= 3)
                    {
                        Console.WriteLine(" Uczen zdał przedmiot ");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(" Uczen nie zdał przedmiotu ");
                        Console.WriteLine();
                    }



                }

                else
                {
                    Console.WriteLine(" Nie ma takiego zadania ");
                    break;
                }

            }


        }

    }
}