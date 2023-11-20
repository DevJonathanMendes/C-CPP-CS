// Fig. 10.17: Tree.cs
// A classe Tree contém o número de anéis correspondentes a sua idade.

using System;

// Cole a interface IAge (Fig-10.15 - IAge.cs) aqui.

public class Tree : IAge
{
	private int rings;

	public Tree(int yearPlanted)
	{ rings = DateTime.Now.Year - yearPlanted; }

	public void AddRing()
	{ rings++; }

	public int Age
	{ get { return rings; } }

	public string Name
	{ get { return "Tree"; } }
}
