// Fig. 10.19: IShape.cs
// Interface IShape da hierarquia Point, Circle, Cylinder.

using System;

public interface IShape
{
	double Area();
	double Volume();
	string Name { get; }
}
