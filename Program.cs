using System.Linq.Expressions;
using EspacioCalculadora;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Calculadora calculadora = new Calculadora();
            
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese una operación (1-suma, 2-resta, 3-multiplicacion, 4-division, 5-limpiar, 6-salir):");
                int operacion;
                int.TryParse(Console.ReadLine(), out operacion);

                switch (operacion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el valor a sumar:");
                        if (double.TryParse(Console.ReadLine(), out double valorSuma))
                        {
                            calculadora.Sumar(valorSuma);
                            Console.WriteLine("Resultado: " + calculadora.Resultado);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el valor a restar:");
                        if (double.TryParse(Console.ReadLine(), out double valorResta))
                        {
                            calculadora.Restar(valorResta);
                            Console.WriteLine("Resultado: " + calculadora.Resultado);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el valor a multiplicar:");
                        if (double.TryParse(Console.ReadLine(), out double valorMultiplicacion))
                        {
                            calculadora.Multiplicar(valorMultiplicacion);
                            Console.WriteLine("Resultado: " + calculadora.Resultado);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el valor a dividir:");
                        if (double.TryParse(Console.ReadLine(), out double valorDivision))
                        {
                            if (valorDivision != 0)
                            {
                                calculadora.Dividir(valorDivision);
                                Console.WriteLine("Resultado: " + calculadora.Resultado);
                            }
                            else
                            {
                                Console.WriteLine("Error: División por cero.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 5:
                        calculadora.Limpiar();
                        Console.WriteLine("Resultado limpiado.");
                        break;

                    case 6:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Comando no reconocido.");
                        break;
                }
            }

            Console.WriteLine("¡Adiós!");
