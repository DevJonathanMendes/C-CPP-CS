// Fig. 10.8: AbstractShapesTest.cs
// Demonstra o polimorfismo na hierarquia Point-Circle-Cylinder.

using System;
using System.Windows.Forms;

// Cole a classe Shape (Fig-10.04 - Shape.cs) aqui.

// Cole a classe Point2 (Fig-10.05 - Point2.cs) aqui.

// Cole a classe Circle2 (Fig-10.06 - Circle2.cs) aqui.

// Cole a classe Cylinder2 (Fig-10.07 - Cylinder2.cs) aqui.

public class AbstractShapesTest
{
	public static void Main(string[] args)
	{
		Point2 point = new Point2(7, 11);
		Circle2 circle = new Circle2(22, 8, 3.5);
		Cylinder2 cylinder = new Cylinder2(10, 10, 3.3, 10);

		// Cria array vazio de referências à classe base Shape.
		Shape[] arrayOfShapes = new Shape[3];

		arrayOfShapes[0] = point;
		arrayOfShapes[1] = circle;
		arrayOfShapes[2] = cylinder;

		string output = point.Name + ": " + point + "\n" +
			circle.Name + ": " + circle + "\n" +
			cylinder.Name + ": " + cylinder;

		foreach (Shape shape in arrayOfShapes)
		{
			output += "\n\n" + shape.Name + ": " + shape +
				"\nArea = " + shape.Area().ToString("F") +
				"\nVolume = " + shape.Volume().ToString("F");
		}

		MessageBox.Show(output, "Demonstrating Polymorphism");
	}
}
