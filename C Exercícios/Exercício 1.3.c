/*************************************************************
 * Exercício 1.3.
 
 * Dadas as duas notas de um aluno, informe a sua média final.
 
 * Jonathan B. Mendes.                                      
 *************************************************************/

#include <stdio.h> // Contém funcões básicas da Linguagem C.
#include <conio.h> // Contém a função "getch();"

int
main(void)
{
    // Coleta as duas notas do aluno.
    float n1, n2;
    printf("Nota 1: ");
    scanf("%f", &n1);
    printf("Nota 2: ");
    scanf("%f", &n2);
    
    // Calcula a média.
    float media = n1 + n2 / 2;
    printf("Media final: %.2f", media);
    getch(); // Aguarda uma tecla ser precionada para concluir o programa.
    return 0;
}