// Fig. 8.16: Indexer
// Os indexadores fornecem acesso aos membros
// de um objeto por meio de um operador de índice.

namespace console;

using System;

public class Box
{
    private string[] names = { "length", "width", "height" };
    private double[] dimensions = new double[3];

    public Box(double length, double width, double height)
    {
        dimensions[0] = length;
        dimensions[1] = width;
        dimensions[2] = height;
    }

    // Acessa as dimensões pelo número de índice inteiro.
    public double this[int index]
    {
        get
        {
            return (index < 0 || index >= dimensions.Length)
            ? -1 : dimensions[index];
        }
        set
        {
            if (index >= 0 && index < dimensions.Length)
                dimensions[index] = value;
        }
    }

    // Acessa as dimensões por seus nomes de string.
    public double this[string name]
    {
        get
        {
            int i = 0;

            while (i < names.Length && name.ToLower() != names[i])
                i++;

            return (i == names.Length) ? -1 : dimensions[i];
        }
        set
        {
            int i = 0;

            while (i < names.Length && name.ToLower() != names[i])
                i++;

            if (i != names.Length)
                dimensions[i] = value;
        }
    }
}

static class Program
{
    static void Main(string[] args)
    {
        Box TestBox = new Box(1.0, 2.0, 3.0);

        TestBox[0] = 3.99;
        TestBox["width"] = 99.99;

        Console.WriteLine(TestBox[0]);
        Console.WriteLine(TestBox["width"]);
    }
}
