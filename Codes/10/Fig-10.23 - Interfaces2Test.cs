// Fig. 10.23: Interfaces2Test.cs
// Demonstrando polimorfismo com interfaces na hierarquia Point-Circle-Cylinder.

using System;
using System.Windows.Forms;

// Cole a interface IShape (Fig-10.19 - IShape.cs) aqui.

// Cole a classe Point3 (Fig-10.20 - Point3.cs) aqui.

// Cole a classe Circle3 (Fig-10.21 - Circle3.cs) aqui.

// Cole a classe Cylinder3 (Fig-10.21 - Cylinder3.cs) aqui.

public class Interfaces2Test
{
	public static void Main(string[] args)
	{
		Point3 point = new Point3(7, 11);
		Circle3 circle = new Circle3(22, 8, 3.5);
		Cylinder3 cylinder = new Cylinder3(10, 10, 3.3, 10);

		// Cria array de referências a IShape.
		IShape[] arrayOfShapes = new IShape[3];

		arrayOfShapes[0] = point;
		arrayOfShapes[1] = circle;
		arrayOfShapes[2] = cylinder;

		string output = point.Name + ": " + point + "\n" +
			circle.Name + ": " + circle + "\n" +
			cylinder.Name + ": " + cylinder;

		foreach (IShape shape in arrayOfShapes)
		{
			output += "\n\n" + shape.Name + ":\nArea = " +
				shape.Area() + "\nVolume = " + shape.Volume();
		}

		MessageBox.Show(output, "Demonstrating Polymorphism");
	}
}
