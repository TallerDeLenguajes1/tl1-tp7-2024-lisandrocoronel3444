using System.Linq.Expressions;
using EspacioCalculadora;
using administracion;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Calculadora calculadora = new Calculadora();
            
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
*/


Empleado[] empleados = new Empleado[3];

        // Cargar datos para los empleados
        empleados[0] = new Empleado(
            "Juan",
            "Pérez",
            new DateTime(1990, 5, 15),
            'S',
            new DateTime(2015, 10, 1),
            650000.0,
            Cargos.Ingeniero
        );

        empleados[1] = new Empleado(
            "María",
            "Gómez",
            new DateTime(1985, 8, 20),
            'C',
            new DateTime(2010, 6, 12),
            600000.0,
            Cargos.Administrativo
        );

        empleados[2] = new Empleado(
            "Pedro",
            "Martínez",
            new DateTime(1982, 12, 3),
            'C',
            new DateTime(2005, 4, 5),
            700000.0,
            Cargos.Especialista
        );

        // Mostrar información de los empleados
        Console.WriteLine("Información de los empleados:");
        foreach (Empleado emp in empleados)
        {
            emp.MostrarInformacion();
            Console.WriteLine("=====================");
        }

            // Calcular el monto total de los salarios
            // Calcular el Monto Total de lo que se paga en concepto de Salarios
            double montoTotalSalarios = 0;
            foreach (Empleado emp in empleados)
            {
             montoTotalSalarios += emp.CalcularSalario();
            }
            Console.WriteLine("Monto Total de Salarios: " + montoTotalSalarios);

            // Encontrar el empleado más próximo a jubilarse
            int menorAniosParaJubilacion = 100;
            Empleado empleadoMasProximoAJubilarse = null;

            foreach (Empleado emp in empleados)
            {
                int aniosParaJubilacion = emp.AniosParaJubilacion();
                if (aniosParaJubilacion < menorAniosParaJubilacion)
                {
                    menorAniosParaJubilacion = aniosParaJubilacion;
                    empleadoMasProximoAJubilarse = emp;
                }
            }

// Mostrar los datos del empleado más próximo a jubilarse
            Console.WriteLine("Empleado más próximo a jubilarse:");
            empleadoMasProximoAJubilarse.MostrarInformacion();
        