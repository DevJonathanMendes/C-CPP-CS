/*********************************************************
 * PROGRAMA SKITTLES                                     *
 * GERA UM VALOR PSEUDO-ALEATÓRIO PARA O USUÁRIO ACERTAR *
 *********************************************************/

#include <cc50.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int
main(void)
{
    // SEED PARA "rand() % 'argumento'".
    srand(time(NULL));
    
    // GERA UM NÚMERO PSEUDO-ALEATÓRIO ENTRE [0, 1023].
    int skittles = rand() % 1024;
    
    // PEDE PARA O USUÁRIO UM INTEIRO.
    printf("Ol%c! Eu sou uma m%cquina de skittles falante!\n"
            "Adivinhe quantos skittles eu tenho.\n"
            "Dica: Est%c entre 0 e 1023.\n"
            "Qual %c?\n", 160, 160, 160, 130);
    
    // INPUT
    int x = GetInt();
    while(x != skittles) 
    {
    if(x > skittles) // SE MAIOR, FAÇA ISSO.
    {
        printf("Ok, eles n%co s%co tantos assim. Tente novamente.\n", 198, 198);
        x = GetInt();
    }
    else if(x < skittles) // SE MENOR, FAÇO AQUILO.
    {
        printf("Haha! Tenho muito mais skittles do que isso. Tente novamente.\n");
        x = GetInt();
    }
    }
    // SE O USUÁRIO ACERTAR O NÚMERO.
    printf("Voc%c est%c certo!\nEra %d mesmo.\n", 136, 160, x);
    
    // FINAL DO PROGRAMA.
    system("pause");
    return 0;
}