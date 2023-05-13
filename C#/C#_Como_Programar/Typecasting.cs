// Conversão de tipos (Typecasting).

using System;

class CPU
{
    public double MHz;
    public int YearManufacture;
}

class Intel8086 : CPU
{
    public Intel8086()
    {
        MHz = 4.77;
        YearManufacture = 1981;
    }
}

class Intel286 : Intel8086
{
    public bool ProtectedMode = false;

    public Intel286()
    {
        MHz = 20.0;
        YearManufacture = 1984;
    }
}

class CheckProtectedMode
{
    public void ActiveProtectedMode(CPU cpu)
    {
        if (cpu is Intel286)
        {
            (cpu as Intel286).ProtectedMode = true; // Observe o type cast nesta linha.
            Console.WriteLine("Protected mode has been activated.");
        }
        else if (cpu is Intel8086)
        {
            Console.WriteLine("Protected mode not available.");
        }
    }
}

class Program
{
    static void Main()
    {
        Intel8086 p18086 = new Intel8086();
        Intel286 p1286 = new Intel286();
        CheckProtectedMode Mode = new CheckProtectedMode();

        Mode.ActiveProtectedMode(p18086);
        Mode.ActiveProtectedMode(p1286);
    }
}