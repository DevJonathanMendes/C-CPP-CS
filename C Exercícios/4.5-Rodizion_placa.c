/* Exercício 4.5.
 *
 * Codifique a função rodízio(placa), que recebe o número da placa de um veículo e exibe o dia em que ele está no rodízio.
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>

void rodizio(placa)
{
    if(placa == 1 || placa == 2)
        printf("RODIZIO NA SEGUNDA-FEIRA.");
    if(placa == 3 || placa == 4)
        printf("RODIZIO NA TERCA-FEIRA.");
    if(placa == 5 || placa == 6)
        printf("RODIZIO NA QUARTA-FEIRA.");
    if(placa == 7 || placa == 8)
        printf("RODIZIO NA QUINTA-FEIRA.");
    if(placa == 9 || placa == 0)
        printf("RODIZIO NA SEXTA-FEIRA.");
}

int main(void)
{
    char x;
    printf("FINAL DA PLACA DO CARRO: ");
    scanf("%i", &x);
    rodizio(x);
}