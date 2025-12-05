using System;

class AnalisisVentas
{
    // Función para calcular total
    static int CalcularTotal(int[] ventas)
    {
        int total = 0;
        for (int i = 0; i < ventas.Length; i++)
        {
            total += ventas[i];
        }
        return total;
    }

    // Función para encontrar el mayor y su día
    static (int mayor, int diaMayor) CalcularMayor(int[] ventas)
    {
        int mayor = ventas[0];
        int diaMayor = 1;

        for (int i = 1; i < ventas.Length; i++)
        {
            if (ventas[i] > mayor)
            {
                mayor = ventas[i];
                diaMayor = i + 1;
            }
        }
        return (mayor, diaMayor);
    }

    // Función para encontrar el menor y su día
    static (int menor, int diaMenor) CalcularMenor(int[] ventas)
    {
        int menor = ventas[0];
        int diaMenor = 1;

        for (int i = 1; i < ventas.Length; i++)
        {
            if (ventas[i] < menor)
            {
                menor = ventas[i];
                diaMenor = i + 1;
            }
        }
        return (menor, diaMenor);
    }

    // Función para calcular promedio
    static double CalcularPromedio(int total, int n)
    {
        return (double)total / n;
    }

    // Función para mostrar días > 20
    static void MostrarMayores20(int[] ventas)
    {
        Console.WriteLine("\nDías con ventas mayores a 20 unidades:");
        for (int i = 0; i < ventas.Length; i++)
        {
            if (ventas[i] > 20)
            {
                Console.WriteLine($"Día {i + 1}: {ventas[i]} unidades");
            }
        }
    }

    static void Main()
    {
        Console.Write("Ingrese la cantidad de días del mes (n): ");
        int n = int.Parse(Console.ReadLine());

        int[] ventas = new int[n];

        // Leer valores del arreglo
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese las ventas del día {i + 1}: ");
            ventas[i] = int.Parse(Console.ReadLine());
        }

        // Cálculos
        int total = CalcularTotal(ventas);
        var (mayor, diaMayor) = CalcularMayor(ventas);
        var (menor, diaMenor) = CalcularMenor(ventas);
        double promedio = CalcularPromedio(total, n);

        // Mostrar resultados
        Console.WriteLine("\n--- RESULTADOS DEL ANÁLISIS ---");
        Console.WriteLine($"Total vendido en el mes: {total}");
        Console.WriteLine($"Día con mayor venta: Día {diaMayor} con {mayor} unidades");
        Console.WriteLine($"Día con menor venta: Día {diaMenor} con {menor} unidades");
        Console.WriteLine($"Promedio diario: {promedio:F2}");

        MostrarMayores20(ventas);

        Console.WriteLine("\nFin del programa.");
    }
}
