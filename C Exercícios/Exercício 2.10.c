/* Exercício 2.10.
 *
 * Dados a altura e o sexo de uma pessoa, determine seu peso ideal de acordo com as fórmulas a seguir:
 * • para homens o peso ideal é 72.7∗altura − 58
 * • para mulheres o peso ideal é 62.1∗altura − 44.7
 * 
 * Mostra o uso de switch's.
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <conio.h>

int
main(void)
{
 // Coleta os dados.
 float altura;
 char sexo;
 
 printf("Qual a sua altura e o seu sexo (M/m ou F/f): ");
 scanf("%f %c", &altura, &sexo);


 switch(sexo)
 {
     case 'M':
     case 'm': printf("Peso idela para homens: %.2f", (72.2 * altura) - 58); break;
     case 'F':
     case 'f': printf("Peso ideal para mulheres: %.2f", (65.1 * altura) - 44.7); break;
     default: printf("Erro"); break;
 }
 
 getch(); 
 return 0;
}