// Fig. 16.26: ChessGame.cs
// Código gráfico do jogo de xadrez.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;

// Permite que dois jogadores joguem xadrez.
partial class ChessGame : Form
{
	private PictureBox pieceBox;
	private MenuStrip GameMenu;
	private ToolStripMenuItem gameItem;
	private ToolStripMenuItem newGameItem;

	// ArrayList para imagens de casa do tabuleiro.
	ArrayList chessTile = new ArrayList();

	// ArrayList para peças de xadrez.
	ArrayList chessPieces = new ArrayList();

	// Define o índice da peça selecionada.
	int selectedIndex = -1;
	int[,] board = new int[8, 8]; // Array board.

	// Define o tamanho da casa do xadrez, em pixels.
	private const int TILESIZE = 75;

	private void InitializeComponent()
	{
		this.pieceBox = new PictureBox();
		this.GameMenu = new MenuStrip();
		this.gameItem = new ToolStripMenuItem();
		this.newGameItem = new ToolStripMenuItem();

		// pieceBox.
		this.pieceBox.Name = "pieceBox";
		this.pieceBox.Text = "pieceBox";
		this.pieceBox.Size = new Size(100, 100);
		this.pieceBox.Location = new Point(10, 10);
		this.pieceBox.Paint += new PaintEventHandler(pieceBox_Paint);
		this.pieceBox.MouseUp += new MouseEventHandler(pieceBox_MouseUp);
		this.pieceBox.MouseMove += new MouseEventHandler(pieceBox_MouseMove);
		this.pieceBox.MouseDown += new MouseEventHandler(pieceBox_MouseDown);

		// GameMenu.
		this.GameMenu.Name = "GameMenu";
		this.GameMenu.Text = "GameMenu";
		this.GameMenu.AutoSize = true;
		this.GameMenu.Items.Add(this.gameItem);

		// gameItem.
		this.gameItem.Name = "gameItem";
		this.gameItem.Text = "Game";
		this.gameItem.AutoSize = true;
		this.gameItem.DropDownItems.Add(this.newGameItem);

		// newGameItem.
		this.newGameItem.Name = "newGameItem";
		this.newGameItem.Text = "Game";
		this.newGameItem.AutoSize = true;
		this.newGameItem.Click += new EventHandler(newGameItem_Click);

		// ChessGame.
		this.Load += new EventHandler(ChessGame_Load);
		this.Paint += new PaintEventHandler(ChessGame_Paint);
		this.Controls.AddRange(new Control[]{
			this.GameMenu,  this.pieceBox
		});
		this.Name = "ChessGame";
		this.Text = "ChessGame";
		this.AutoSize = true;
		// this.ResumeLayout(false);
	}

	// Carrega as imagens das casas e inicializa o jogo.
	private void ChessGame_Load(object? sender, EventArgs e)
	{
		// Carrega as casas do tabuleiro de xadrez.
		chessTile.Add(Bitmap.FromFile("lightTile.jpg"));
		chessTile.Add(Bitmap.FromFile("darkTile.jpg"));

		ResetBoard(); // Inicializa o tabuleiro.
		Invalidate(); // Atualiza o formulário.
	}

	// Inicializa as peças para começar e reconstrói o tabuleiro.
	private void ResetBoard()
	{
		int current = -1;
		ChessPiece piece;
		Random random = new Random();
		bool light = true;
		int type;

		// Garante ArrayList vazio.
		chessPieces = new ArrayList();

		// Carrega imagem das peças brancas.
		Bitmap whitePieces = (Bitmap)Image.FromFile("whitePieces.png");

		// Carrega imagem das peças pretas.
		Bitmap blackPieces = (Bitmap)Image.FromFile("blackPieces.png");

		// Configura as peças brancas desenhadas primeiro.
		Bitmap selected = whitePieces;

		// Percorre as linhas do tabuleiro, no laço externo.
		for (int row = 0; row <= board.GetUpperBound(0); row++)
		{
			// Se estiver nas linhas inferiores configura como pretas as imagens das peças.
			if (row > 5)
				selected = blackPieces;

			// Percorre as colunas do tabuleiro, no laço interno.
			for (int column = 0; column <= board.GetLowerBound(1); column++)
			{
				// Se for a primeira ou última linha, organiza as peças.
				if (row == 0 || row == 7)
				{
					switch (column)
					{
						case 0:
						case 7: // Configura a peça atual como torre.
							current = (int)ChessPiece.Types.ROOK;
							break;
						case 1:
						case 6: // Configura a peça atual como cavalo.
							current = (int)ChessPiece.Types.KNIGHT;
							break;
						case 2:
						case 5: // Configura a peça atual como bispo.
							current = (int)ChessPiece.Types.BISHOP;
							break;
						case 3: // Configura a peça atual como rei.
							current = (int)ChessPiece.Types.KING;
							break;
						case 4: // Configura a peça atual como rainha.
							current = (int)ChessPiece.Types.QUEEN;
							break;
					}

					// Cria a peça atual na posição inicial.
					piece = new ChessPiece(current, column * TILESIZE, row * TILESIZE, selected);

					// Adiciona a peça a ArrayList.
					chessPieces.Add(piece);
				}

				// Se for a segunda ou a sétima linha, organiza os peões.
				if (row == 1 || row == 6)
				{
					piece = new ChessPiece(
						(int)ChessPiece.Types.PAWN,
						column * TILESIZE, row * TILESIZE, selected);

					// Adiciona a peça a ArrayList.
					chessPieces.Add(piece);
				}

				// Determina o tipo de peça do tabuleiro.
				type = random.Next(0, 2);

				if (light)
				{
					// Configura a casa clara.
					board[row, column] = type;
					light = false;
				}
				else
				{
					// Configura a casa escura
					board[row, column] = type + 2;
					light = true;
				}
			}

			// Leva em conta a nova troca de cor de casa de linha.
			light = !light;
		}
	}

	// Exibe o tabuleiro no evento OnPaint do formulário.
	private void ChessGame_Paint(object? sender, PaintEventArgs e)
	{
		// Obtém o objeto gráfico.
		Graphics graphicsObject = e.Graphics;

		for (int row = 0; row <= board.GetUpperBound(0); row++)
		{
			for (int column = 0; column <= board.GetUpperBound(1); column++)
			{
				// Desenha a imagem específica no array board.
				graphicsObject.DrawImage(
					(Image)chessTile[board[row, column]],
					new Point(TILESIZE * column, TILESIZE * row));
			}
		}
	}

	// Retorna o índice da peça que intercepta o ponto opcionalmente, exclui um valor.
	private int CheckBounds(Point point, int exclude)
	{
		Rectangle rectangle; // Retângulo delimitador atual.

		for (int i = 0; i < chessPieces.Count; i++)
		{
			//Obtém o retângulo da peça.
			rectangle = GetPiece(i).GetBounds();

			// Verifica se o retângulo contém ponto.
			if (rectangle.Contains(point) && i != exclude)
				return i;
		}

		return -1;
	}

	// Manipula o evento de pintura de pieceBox.
	private void pieceBox_Paint(object? sender, PaintEventArgs e)
	{
		// Desenha todas as peças.
		for (int i = 0; i < chessPieces.Count; i++)
			GetPiece(i).Draw(e.Graphics);
	}

	private void pieceBox_MouseDown(object? sender, MouseEventArgs e)
	{
		// Determina a peça selecionada.
		selectedIndex = CheckBounds(new Point(e.X, e.Y), -1);
	}

	// Se a peça está selecionada, move-a.
	private void pieceBox_MouseMove(object? sender, MouseEventArgs e)
	{
		if (selectedIndex > -1)
		{
			Rectangle region = new Rectangle(
				e.X - TILESIZE * 2, e.Y - TILESIZE * 2, TILESIZE * 4, TILESIZE * 4);

			// Configura o centro da peça no mouse.
			GetPiece(selectedIndex).SetLocation(e.X - TILESIZE / 2, e.Y - TILESIZE / 2);

			// Atualiza a área imediata.
			pieceBox.Invalidate(region);
		}
	}

	// Quando o botão do mouse é liberado, cancela a seleção da peça e remove a peça tomada.
	private void pieceBox_MouseUp(object? sender, MouseEventArgs e)
	{
		int remove = -1;

		// Se a peça do xadrez foi selecionada.
		if (selectedIndex > -1)
		{
			Point current = new Point(e.X, e.Y);
			Point newPoint = new Point(
				current.X - (current.X % TILESIZE),
				current.Y - (current.Y % TILESIZE)
			);

			// Verifica os limites com o ponto, exclui a pela selecionada.
			remove = CheckBounds(current, selectedIndex);

			// Coloca a peça no centro do quadrado mais próximo.
			GetPiece(selectedIndex).SetLocation(newPoint.X, newPoint.Y);

			// Retira a seleção da peça.
			selectedIndex = -1;
			if (remove > -1)
				chessPieces.RemoveAt(remove);
		}

		// Atualiza pieceBox para garantir a remoção da peça.
		pieceBox.Invalidate();
	}

	// Função auxiliar para converter objeto ArrayList em ChessPiece.
	private ChessPiece GetPiece(int i)
	{
		return (ChessPiece)chessPieces[i];
	}

	// Manipula os cliques da opção do menu NewGame.
	private void newGameItem_Click(object? sender, EventArgs e)
	{
		ResetBoard(); // Reinicializa o tabuleiro.
		Invalidate(); // Atualiza o formulário.
	}
}

partial class ChessGame
{
	private Container? components = null;

	public ChessGame()
	{ InitializeComponent(); }

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}
}

static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new ChessGame());
	}
}
