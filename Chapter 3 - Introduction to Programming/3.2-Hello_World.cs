// Fig. 3.1: Hello, world!
// Primeiro programa.

/*
Sequências de scape:  
	\n: Nova linha.
	\t: Tabulação horizontal.
	\r: Retorna o cursor.
	\\: Barra invertida.
	\": Aspas.
*/

/*
Formatos Numéricos:
"C": Formata um número como uma moeda.
"D": Formata um número como um inteiro decimal.
"E": Formato de um número em notação científica.
"F": Formata um número como um número de ponto flutuante com uma.
"G": Formato geral. Usa a formatação mais adequada para o tipo num.
"N": Formato um número com separadores de milhares e casas decimais.
"P": Formata um número como uma porcentagem.
"X": Formata um número como uma representação hexadecimal.

Formatos de dados e hora:
"d": Formata dados no formato curto.
"D": Formato de dados sem formato longo.
"f": Formata os dados por hora.
"F": Formato de dados e hora no formato longo com detalhes de frações
"g": Formato geral para dados e hora.
"G": Formato geral para dados e hora longa.
"M": Formata os dados no formato mês e dia.
"Y": Formata os dados no formato ano e mês.

Outros formatos:
"s": Formato um valor de dados e hora como uma string no formato padrão ISO 8601.
"0.00": Formata um número com exatamente duas vezes.
*/

// Palavra reservada "using" indica que estamos usando tal espaço de nomes.
using System; 

static class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, world!\nAll are welcome!");
	}
}
