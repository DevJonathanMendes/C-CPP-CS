/* Exercício 3.10.
 *
 * Numa agência bancária, as contas são identificadas por nº de até 6 dígitos seguidos de um dígito verificador,
 * calculado conforme exemplificado a seguir.
 * Dado um número de conta n, exiba o número de conta completo correspondente.
 * 
 * Seja n = 7314 o número da conta.
 * 1º Adicionamos os dígitos de n e obtemos a soma s = 7+3+1+4 = 15;
 * 2º Calculamos o resto da divisão de s por 10 e obtemos o dígito d = 5.
 * Número de conta completo: 007314−5

 * 
 * Jonathan B. Mendes.
  */

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    unsigned int x, x2, y0, y1, z = 0;
    printf("SUA CONTA DO BANCO: ");
    scanf("%u", &x);
    if(x > 999999 || x == 0)
    {
        printf("DIGITOS INCORRETOS.\n");
        getch();
        return 1;
    }
    x2 = x;
    
    // Separa os digitos e depois soma.
    while(x != 0)
    {
        y0 = x % 10;
        x /= 10;
        y1 = x % 10;
        x /= 10;
        z += y0 + y1;
        //printf("X = %u\nY0 = %u\nY1 = %u\n\n", x, y0, y1);
    }
    printf("\nSUA CONTA COMPLETA: %.6u-%u", x2, z % 10);
    getch();
    return 0;
}