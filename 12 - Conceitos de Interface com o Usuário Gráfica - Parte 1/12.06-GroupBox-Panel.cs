// 12.06: GroupBox e Panel.
// Organizam componentes em uma GUI.

// Principal diferença entre as classes:
// GroupBox podem exibir uma legenda.
// Panels podem ter barras de rolagem.

// Algumas propriedades comuns.

// GroupBox
// Controls: Os controles que contém.
// Text: O texto exibido na parte superior (legenda).


// Panel
// AutoScroll: Indica se barras de rolagem aparecem quando é pequeno demais.
// BorderStyle: Estilo da borda.
// Controls: Os controles que o panel contém.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class WinForm : Form
{
	private GroupBox? groupBox;
	private Button? addButton;
	private Panel? panel;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.groupBox = new GroupBox();
		this.addButton = new Button();
		this.panel = new Panel();
		this.groupBox.SuspendLayout();
		this.SuspendLayout();

		// groupBox
		this.groupBox.Text = "Exemplo de GroupBox e Panel";
		this.groupBox.Controls.Add(this.addButton);
		this.groupBox.Controls.Add(this.panel);
		this.groupBox.Location = new Point(12, 12);
		this.groupBox.Size = new Size(300, 200);

		// addButton
		this.addButton.Location = new Point(10, 20);
		this.addButton.Size = new Size(100, 30);
		this.addButton.Text = "Adicionar Botão";
		this.addButton.Click += new EventHandler(this.addButton_Click);

		// panel
		this.panel.Location = new Point(10, 60);
		this.panel.Size = new Size(280, 130);

		// Program
		this.Text = "Exemplo de GroupBox e Panel";
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(324, 226);
		this.Controls.Add(this.groupBox);
		this.groupBox.ResumeLayout(false);
		this.ResumeLayout(false);
	}
	#endregion

	private void addButton_Click(object? sender, EventArgs e)
	{
		Button button = new Button();
		button.Text = "Novo Botão";
		button.Size = new Size(100, 30);

		if (panel is not null)
			panel.Controls.Add(button);
	}
}

partial class WinForm
{
	private IContainer? components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}

	public WinForm()
	{
		InitializeComponent();
	}
}

static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new WinForm());
	}
}
