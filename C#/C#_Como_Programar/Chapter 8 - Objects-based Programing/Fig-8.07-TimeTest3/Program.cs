// Fig. 8.7: TimeTest3
// Demonstração.

namespace winforms;

using System;
using System.Windows.Forms;

static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new Form1());
	}
}
