// Fig. 8.19: AssemblyTest.cs
// Usando a classe Time3 do assembly TimeLibrary.

using System;
using TimeLibrary;

class AssemblyTest
{
	static void Main(string[] args)
	{
		Time3 time = new Time3(13, 27, 6);

		Console.WriteLine("Standard time: {0}\nUniversal time: {1}\n",
		time.ToStandardString(), time.ToUniversalString());
	}
}
