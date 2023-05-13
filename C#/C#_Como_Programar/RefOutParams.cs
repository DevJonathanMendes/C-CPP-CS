using System;

class RefOutParams
{
    public void methodByVal(int parameter) // Parâmetro só é alterado dentro do método (Padrão).
    { ++parameter; }

    public void methodByRef(ref int parameter) // Parâmetro é alterado na variável também.
    { ++parameter; }

    public void methodWithRefAndOut(ref int refParameter, out int outParameter) // Parâmetro não inicializado usamos out.
    { outParameter = refParameter++; }

    public int methodByParams(params int[] args) // Parâmetros podem variar no número de elementos.
    {
        int total = 0;

        foreach (int element in args)
            total += element;

        return total;
    }
}

class TestingRefOutParams
{
    static void Main()
    {
        RefOutParams TestClassValRefOut = new RefOutParams();
        int argValue = 1;
        int outValue;

        TestClassValRefOut.methodByVal(argValue);
        Console.WriteLine($"After methodByValue: argValue = {argValue}");

        TestClassValRefOut.methodByRef(ref argValue);
        Console.WriteLine($"After methodByReference: argValue = {argValue}");

        TestClassValRefOut.methodWithRefAndOut(ref argValue, out outValue);
        Console.WriteLine($"After methodWithRefAndOut: argValue = {argValue}, outValue = {outValue}");

        int total = TestClassValRefOut.methodByParams(2, 4, 6, 8);
        Console.WriteLine($"After methodByParams: total = {total}");
    }
}