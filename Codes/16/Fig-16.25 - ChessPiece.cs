// Fig. 16.25: ChessPiece.cs
// Classe de armazenamento para atributos de peças de xadrez.

using System;
using System.Drawing;

// Representa uma peça de xadrez.
public class ChessPiece
{
	// Define constantes de tipo de peça de xadrez.
	public enum Types
	{
		KING, QUEEN,
		BISHOP, KNIGHT,
		ROOK, PAWN
	}
	private int currentType;    // O tipo desse objeto.
	private Bitmap pieceImage; // A imagem desse objeto.

	// Localização de exibição padrão.
	private Rectangle targetRectangle = new Rectangle(0, 0, 75, 75);

	// Constrói a peça.
	public ChessPiece(int type, int xLocation, int yLocation, Bitmap sourceImage)
	{
		currentType = type; // Configura o tipo atual.
		targetRectangle.X = xLocation; // Configura a localização x atual.
		targetRectangle.Y = yLocation; // Configura a localização y atual.

		// Obtém pieceImage a partir da seção de sourceImage.
		pieceImage = sourceImage.Clone(
			new Rectangle(type * 75, 0, 75, 75),
			System.Drawing.Imaging.PixelFormat.DontCare);
	}

	// Desenha a peça de xadrez.
	public void Draw(Graphics graphicsObject)
	{
		graphicsObject.DrawImage(pieceImage, targetRectangle);
	}

	// Obtém o retângulo de localização da peça.
	public Rectangle GetBounds()
	{ return targetRectangle; }

	// Configura a posição dessa peça.
	public void SetLocation(int xLocation, int yLocation)
	{
		targetRectangle.X = xLocation;
		targetRectangle.Y = yLocation;
	}
}
