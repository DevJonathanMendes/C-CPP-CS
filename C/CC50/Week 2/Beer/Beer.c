/*****************************
 * CANTA A MÚSICA DA CERVEJA *
 *      JONATHAN MENDES      *
 *****************************/

#include <cc50.h>
#include <stdio.h>

int
main(void)
{
    printf("Quantas garrafas de cerveja voc%c quer? ", 136);
    int garrafas = GetInt();
    printf("\n");

    // SE MENOR QUE 1, O PROGRAMA FECHA COM UMA MENSAGEM.
    if (garrafas < 1)
    {
        printf("isso nao faz sentido\n");
        return 1;
    }
    // CANTA CORRETAMENTE.
    for (int i = garrafas; i > 0; i--)
    {
        if (i >= 3)
        {
            printf("%2d garrafas de cerveja no muro, bebo uma, jogo no lixo, ", i);
            printf("%d garrafas no muro...\n", i - 1);
        }
        if ( i == 2)
        {
            printf("%2d garrafas de cerveja no muro, bebo uma, jogo no lixo, ", i);
            printf("%d garrafa no muro...\n", i - 1);
        }
        if (i == 1)
        {
            printf("%2d garrafa de cerveja no muro, bebo uma, jogo no lixo, ", i);
            printf("nenhuma garrafa no muro...\n");
        }
    }
    // TÉRMINO DA MÚSICA.
    printf("Nossa, isso foi muito chato.\n");
    return 0;
}