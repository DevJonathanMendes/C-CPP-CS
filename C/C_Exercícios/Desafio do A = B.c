/* Desafio: A = B.
 *
 * Escreva um programa que leia uma string, conte quantos caracteres desta string são iguais a "a" e substitua os que forem iguais a 'a' por 'b'.
 * O programa deve imprimir o número de caracteres modificados e a string modificada.
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    unsigned char p[20];
    unsigned short int x = 0;
    printf("String para modificar: ");
    fgets(p, 20, stdin);
    //scanf("%[^\n]", &p);
	
    // Caso não tenha uma string, o programa fecha.
    if(strlen(p) == 0)
    {
        printf("Sem string para modificar.");
        getch();
        return 1;
    }
	
    // Modifica a string e acrescenta 1 na contagem de "a".
    for(int i = 0; i < strlen(p); i++)
    {
        if(p[i] == 'a' || p[i] == 'A')
        {
            p[i]++;
            x++;
        }
    }
	
    // Final do programa.
    printf("Caracteres iguais a \"a\" para modificar: %u\n", x);
    printf("String modificada: %s", p);
    getch();
    return 0;
}