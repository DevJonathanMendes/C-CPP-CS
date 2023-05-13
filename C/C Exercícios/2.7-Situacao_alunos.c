/* Exercício 2.7.
 *
 * Numa faculdade, os alunos com média pelo menos 7,0 são aprovados, aqueles com média inferior a 3,0 são reprovados e os demais ficam de recuperação.
 * Dadas as duas notas de um aluno, informe sua situação.
 * Use as cores azul, vermelho e amarelo para as mensagens aprovado, reprovado e recuperação, respectivamente.
 * 
 * ["textcolor(COR);" e "cprintf("");" da biblioteca ''<conio.h>'' não está funcionando neste compilador, programa e terminal.]
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <conio.h>

int
main(void)
{
 // Coleta os dados.
 float nota1, nota2, media;
 printf("Sua nota 1: ");
 scanf("%f", &nota1);
 printf("Sua nota 2: ");
 scanf("%f", &nota2);
 
 // Processa os dados.
 media = (nota1 + nota2) / 2;
 if(media >= 7.0)
    printf("Media final: %.2f\nAprovado!", media);
 
 else if(media > 3.0 && media < 7.0)
    printf("Media final: %.2f\nRecuperacao", media);
 
 else
    printf("Media final: %.2f\nReprovado", media);
 
 getch(); 
 return 0;
}