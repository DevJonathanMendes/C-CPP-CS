/**************************************************************************************************************************
 * Exercício 1.4.
 * 
 * Dados uma distância e o total de litros de combustível gasto por um automóvel para percorrê-la, informe o consumo médio.
 * 
 * Jonathan B. Mendes.
 **************************************************************************************************************************/

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    // Coleta os dados.
    float km, l;
    printf("Quantos km? ");
    scanf("%f", &km);
    printf("Quantos litros gastos? ");
    scanf("%f", &l);
    
    // Faz o cálculo médio de consumo.
    float media = km / l;
    printf("Consumo medio: %.2f", media);
    getch();
    return 0;
}