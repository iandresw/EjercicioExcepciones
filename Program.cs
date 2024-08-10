
using EjercicioExcepciones;


Operaciones operaciones = new Operaciones();
bool salir = false;

while (!salir)

{
    Console.WriteLine("Seleccione una Opcion Valida");
    Console.WriteLine("1. SUMAR");
    Console.WriteLine("2. RESTAR");
    Console.WriteLine("3. MULTIPLICAR");
    Console.WriteLine("4. DIVIDIR");
    Console.WriteLine("5. SALIR");

    string opcion = Console.ReadLine();
    try
    {
        double num1, num2;
        switch (opcion)
        {
            case "1":
                Console.WriteLine("Ingrese el primer numero");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Suma(num1, num2)}");
                break;
            case "2":
                Console.WriteLine("Ingrese el primer numero");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Resta(num1, num2)}");
                break;
            case "3":
                Console.WriteLine("Ingrese el primer numero");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Multiplicacion(num1, num2)}");
                break;
            case "4":
                Console.WriteLine("Ingrese el primer numero");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Divide(num1, num2)}");
                break;
            case "5":
                salir = true;
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Entrada no valida");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error inesperado: {ex.Message}");
    }
}