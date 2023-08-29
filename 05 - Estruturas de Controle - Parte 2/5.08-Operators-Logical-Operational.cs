// 5.08: Operadores lógicos e operacionais.

// &&: (E) Condicional.
// ||: (OU) Condicional.
// &: (E) Lógico.
// |: (OU) Lógico.
// ^: (OU) Exclusivo ou (XOR) Lógico.
// !: (NÃO) Lógico.

using System;

static class Program
{
	static void Main(string[] args)
	{
		// Operador E condicional (&&)
		Console.WriteLine("Conditional AND (&&)" +
		"\nfalse && false: " + (false && false) +
		"\nfalse && true: " + (false && true) +
		"\ntrue && false: " + (true && false) +
		"\ntrue && true: " + (true && true));

		// Operador OU condicional (||)
		Console.WriteLine("\nConditional OR (||)" +
		"\nfalse || false: " + (false || false) +
		"\nfalse || true: " + (false || true) +
		"\ntrue || false: " + (true || false) +
		"\ntrue || true: " + (true || true));

		// Operador E lógico (&)
		Console.WriteLine("\nLogical AND (&)" +
		"\nfalse & false: " + (false & false) +
		"\nfalse & true: " + (false & true) +
		"\ntrue & false: " + (true & false) +
		"\ntrue & true: " + (true & true));

		// Operador OU lógico (|)
		Console.WriteLine("\nLogical OR (|)" +
		"\nfalse | false: " + (false | false) +
		"\nfalse | true: " + (false | true) +
		"\ntrue | false: " + (true | false) +
		"\ntrue | true: " + (true | true));

		// Operador OU exclusivo lógico (*)
		Console.WriteLine("\nLogical exclusive OR (^)" +
		"\nfalse ^ false: " + (false ^ false) +
		"\nfalse ^ true: " + (false ^ true) +
		"\ntrue ^ false: " + (true ^ false) +
		"\ntrue ^ true: " + (true ^ true));

		// Operador NEO lógico (!)
		Console.WriteLine("\nLogical NOT (!)" +
		"\n!false: " + (!false) +
		"\n!true: " + (!true));
	}
}
