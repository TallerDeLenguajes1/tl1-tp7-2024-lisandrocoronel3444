namespace administracion;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    private string Nombre { get; set; }
    private string Apellido { get; set; }
    private DateTime FechaNacimiento { get; set; }
    private char EstadoCivil { get; set; }
    private DateTime FechaIngresoEmpresa { get; set; }
    private double SueldoBasico { get; set; }
    private Cargos Cargo { get; set; }

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngresoEmpresa, double sueldoBasico, Cargos cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        EstadoCivil = estadoCivil;
        FechaIngresoEmpresa = fechaIngresoEmpresa;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }

    public int Antiguedad 
    {
        get
        {
            return DateTime.Now.Year - FechaIngresoEmpresa.Year - (DateTime.Now.DayOfYear < FechaIngresoEmpresa.DayOfYear ? 1 : 0);
        }
    }

    public int CalcularEdad()
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - FechaNacimiento.Year;
        if (FechaNacimiento > hoy.AddYears(-edad))
        {
            edad--;
        }
        return edad;
    }

    // Método para calcular los años que faltan para la jubilación (considerando jubilación a los 65 años)
    public int AniosParaJubilacion()
    {
        const int edadJubilacion = 65;
        int edadActual = CalcularEdad();
        return edadJubilacion - edadActual;
    }

    // Método para calcular el salario del empleado según la fórmula especificada
    public double CalcularSalario()
    {
        // Calcular el Adicional
        double adicional = 0;

        // i) 1 % del sueldo básico por cada año de antigüedad hasta los 20 años, a partir de este, el porcentaje se fija en 25%.
        int antiguedad = Antiguedad;
        if (antiguedad <= 20)
        {
            adicional = SueldoBasico * (antiguedad * 0.01);
        }
        else
        {
            adicional = SueldoBasico * (0.2) + SueldoBasico * 0.25;
        }

        // ii) Si el cargo es Ingeniero o Especialista, el Adicional se incrementa en un 50%.
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional *= 1.5;
        }

        // iii) Si es casado al Adicional se le aumenta $150.000.
        if (EstadoCivil == 'C')
        {
            adicional += 150000;
        }

        // Calcular el salario total
        double salario = SueldoBasico + adicional;
        return salario;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Apellido: " + Apellido);
        Console.WriteLine("Fecha de Nacimiento: " + FechaNacimiento.ToShortDateString());
        Console.WriteLine("Estado Civil: " + EstadoCivil);
        Console.WriteLine("Fecha de Ingreso a la Empresa: " + FechaIngresoEmpresa.ToShortDateString());
        Console.WriteLine("Sueldo Básico: " + SueldoBasico);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Antigüedad en la empresa: " + Antiguedad + " años");
        Console.WriteLine("Edad: " + CalcularEdad() + " años");
        Console.WriteLine("Años para jubilación: " + AniosParaJubilacion() + " años");
        Console.WriteLine("Salario: " + CalcularSalario());
    }


    
}
