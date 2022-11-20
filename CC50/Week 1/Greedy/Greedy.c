#include <stdio.h>
#include <stdlib.h>

int
main(void)
{
	// CENTAVOS DE TROCO E QUANTIDADE DE MOEDA.
    float a = 0.25;
    float b = 0.10;
    float c = 0.05;CENTAVOS DE TROCO E QUANTIDADE DE MOEDA.
    float d = 0.01;
    int moedas = 0;
    
    // PERGUNTA AO USUÁRIO QUAL É O TROCO DELE.
	float f;
    printf("Quanto troco voc%c deve?\n", 136);
    scanf("%f", &f);
    
    // SE O VALOR FOR MENOR OU IGUAL A ZERO.
    while(f <= 0)
    {
        printf("Desculpe? Quanto voc%c disse?\n", 136);
        scanf("f", &f);
    }
    
    // PROCESSO PARA SABER O MENOR NÚMERO DE MOEDAS.
    while(f >= a)
    {
        f -= a;
        moedas++;
    }
    while(f >= b)
    {
        f -= b;
        moedas++;
    }
    while(f >= c)
    {
        f -= c;
        moedas++;
    }
    while(f >= d)
    {
        f -= d;
        moedas++;
    }
    
    // IMPRIME QUANTAS MOEDAS FORAM NECESSÁRIAS.
    printf("MOEDAS: %d\n", moedas);
    return 0;
}