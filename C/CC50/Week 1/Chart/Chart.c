/*PROGRAMA QUE GERA UMA BARRA DE ACORDO COM OS INPUTS DO USUÁRIO*
 *                        JONATHAN MENDES                       *
 ****************************************************************/

#include <stdio.h>
#include <stdlib.h>

int
main(void)
{
    //INTERAÇÃO COM O USUÁRIO.
    float a = 12;
    float b = 14;
    float c = 26;   
    float d = 18;
    
    //SOMA OS ELEMENTOS.
    float soma = a + b + c + d;
    
    //BARRA: M PROCURANDO F.
    printf("M procurando F\n");
    float x0 = a * 100 / soma;
    int f0 = x0 / 100 * 80;
    for(int i0 = 0; i0 < f0; i0++)
    {
        printf("#");
    }
    printf("\n");
    
    //BARRA: F PROCURANDO M.
    printf("\nF procurando M\n");
    float x1 = b * 100 / soma;
    int f1 = x1 / 100 * 80;
    for(int i1 = 0; i1 < f1; i1++)
    {
        printf("#");
    }
    printf("\n");
    
    //BARRA: F PROCURANDO F.
    printf("\nF procurando F\n");
    float x2 = c * 100 / soma;
    int f2 = x2 / 100 * 80;
    for(int i2 = 0; i2 < f2; i2++)
    {
        printf("#");
    }
    printf("\n");
    
    //BARRA: M PROCURANDO M.
    printf("\nM procurando M\n");
    float x3 = d * 100 / soma;
    int f3 = x3 / 100 * 80;
    for(int i3 = 0; i3 < f3; i3++)
    {
        printf("#");
    }
    
    //FINAL DO PROGRAMA.
    printf("\n");
    system("pause");
    return 0;
}