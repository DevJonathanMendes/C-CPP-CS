/* Exercício 3.16.
 * 
 * Faça um programa que calcule o saldo de uma conta bancária tendo como entrada o saldo inicial e uma série de operações de crédito
 * e/ou débito finalizada com o valor zero.
 * O programa deve apresentar como saída o total de créditos, o total de débitos, a C.P.M.F. paga
 * (C.P.M.F. = 0,35% do total de débitos) e o saldo final.
 * 
 * Jonathan B. Mendes.
 */

 #include <stdio.h>
 #include <string.h>
 #include <stdlib.h>
 #include <conio.h>

 int main(void){
     float saldo = 0, op = 0, credito = 0, debito = 0, cpmf = 0;
     printf("Saldo inicial: R$ ");
     scanf("%f", &saldo);   
     if(saldo > 0){
         while(1){
             printf("Operacao:\nR$ ");
             scanf("%f", &op);
             if(op > 0)
                 credito += op;
             if(op < 0)
                 debito += op;
             if(op == 0){
                 cpmf = 0.0035 * -debito;
                 saldo += credito + debito;
                 break;
             }
         }
     }
     printf("\nTotal de creditos ....: R$ %3.2f", credito);
     printf("\nTotal de debitos .....: R$ %3.2f", -debito);
     printf("\nC.P.M.F. paga ........: R$ %3.2f", cpmf);
     printf("\nSaldo final ..........: R$ %3.2f", saldo);
 }