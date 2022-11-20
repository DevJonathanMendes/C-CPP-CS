/**************************************************************************************
 * Exercício 2.4.
 * 
 * Uma empresa determinou um reajuste salarial de 5% a todos os seus funcionários.
 * Além disto, concedeu um abono de R$ 100,00 para aqueles que recebem até R$ 750,00.
 * Dado o valor do salário de um funcionário, informar para quanto ele será reajustado. 
 * 
 * Jonathan B. Mendes.
 **************************************************************************************/

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    // Coleta o salário.
    float salario, multi, final;
    printf("Salario para reajuste de 5%%: ");
    scanf("%f", &salario);
    
    // Reajusta o salário.
    multi = 0.05 * salario;
    final = multi + salario;
    
    // Verifica se pode ter o abono.
    if(final <= 750.00)
        printf("Seu novo salario: R$ %.2f\nPermitido abono de R$ 100.00", final);
    
    else
        printf("Seu novo salario sem abono: R$ %.2f", final);
    
    getch();
    return 0;
}