/* Exercício 2.11.
 *
 * Dada uma data de nascimento, informe o perfil correspondente.
 * Exemplo: 13/06/1970
 * 
 * 1306 + 1970 = 3276
 * 32 + 76 = 108
 * 108 / 5 = 21,6 [Resto 3]
 * 
 * R | Perfil
 * 0 | Tímido.
 * 1 | Sonhador.
 * 2 | Paquerador.
 * 3 | Atraente.
 * 4 | Irresistível.
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <conio.h>
#include <math.h>

int
main(void)
{
    // Coleta os dados.
    int dia, mes, ano, dm, dma, soma;
    char div;
    printf("Vamo dizer o seu perfil!\nData de Nascimento: ");
    scanf("%d %c %d %c %d", &dia, &div, &mes, &div, &ano);  
    
    // Processa os dados.
    dm = dia / 10 * pow(10,3) + dia % 10 * pow(10,2) + mes / 10 * pow(10,1) + mes % 10 * pow(10,0); // Separa, multiplica com a potencia e sua posição e depois soma para juntar tudo.
    dma = dm + ano;
    soma = ((dma / 100) + (dma % 100)) % 5; // Separa, soma e pega o resto da divisão.
    
    // 
    switch(soma)
    {
        case 0: printf("Seu perfil: Introvertido."); break;
        case 1: printf("Seu perfil: Sonhador."); break;
        case 2: printf("Seu perfil: Paquerador."); break;
        case 3: printf("Seu perfil: Atraente."); break;
        case 4: printf("Seu perfil: Irresistivel."); break;
        default: printf("Algo deu errado.");
    }
    
    getch();
    return 0;
}