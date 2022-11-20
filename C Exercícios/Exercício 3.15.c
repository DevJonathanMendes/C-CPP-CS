/* Exercício 3.15.
 * 
 * um programa que leia uma série de valores correspondendo ao preço.
 * (o valor zero finaliza a entrada)
 * Calcule o valor total, subtraia deste valor o desconto devido, mostre o valor.
 * 
 * abaixo de R$ 50 = 5%
 * até R$ 100 = 10%
 * até R$ 200 = 15%
 * acima de R$ 200 = 20%
 * 
 * Jonathan B. Mendes.
 */

 #include <stdio.h>
 #include <string.h>
 #include <stdlib.h>
 #include <conio.h>

 int main(void){
     float valor, mercadoria[30];
     for(int i = 0; i < 30; i++){
         system("cls");
         printf("Mercadoria(%d)\nTotal: R$ %.2f\nR$ ", i, valor);
         scanf("%f", &mercadoria[i]);
         valor += mercadoria[i];

         if(mercadoria[i] == 0){
             if(valor < 50){
                 system("cls");
                 valor = valor - 0.05 * valor;
                 printf("Valor total com desconto de 5%%\nR$ %.2f", valor);
                 break;
             }

             if(valor > 50 && valor < 100){
                 system("cls");
                 valor = valor - 0.10 * valor;
                 printf("Valor total com desconto de 10%%\nR$ %.2f", valor);
                 break;
             }

             if(valor >= 100 && valor < 200){
                 system("cls");
                 valor = valor - 0.15 * valor;
                 printf("Valor total com desconto de 15%%\nR$ %.2f", valor);
                 break;
             }
             system("cls");
             valor = valor - 0.20 * valor;
             printf("Valor total com desconto de 20%%\nR$ %.2f", valor);
             break;
         }
     }
     return 0;
 }