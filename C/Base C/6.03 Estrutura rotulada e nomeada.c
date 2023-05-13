// Criando uma estrutura rotulada e nomeada.

// Rótulo da struct.
typedef struct data{
	int dia;
	int mes;
	int ano;
} DATA; // Nome da struct "data".

int main(void){
	// Não é necessário usar "struct" quando a struct é nomeada.
	DATA nascimento;
	DATA ontem, amanha;

	// Atribuindo valores para os membros da struct da variável "hoje".
	nascimento.dia = 18;
	nascimento.mes = 1;
	nascimento.ano = 2001;
	
	// Prompt para exibir os valores na tela.
	printf("Nascimento: %.2d/%.2d/%.4d\n", nascimento.dia, nascimento.mes, nascimento.ano);
}

// [Se o tipo de estrutura não é recursivo, podemos omitir seu rótulo e declarar apenas seu nome.]