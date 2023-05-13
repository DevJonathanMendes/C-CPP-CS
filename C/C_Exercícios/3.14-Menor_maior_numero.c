/* Exercício 3.14.
 * 
 * Dada uma série de números positivos que representam idades, determine a idade da pessoas mais nova e a mais velha.
 * (finalizada com um valor nulo)
 * 
 * Jonathan B. Mendes.
 */

 #include <stdio.h>
 #include <string.h>
 #include <stdlib.h>
 #include <conio.h>

 int main(void)
 {
     unsigned char velha, nova, idade[101];
     while(1)
     {
         system("cls");
         printf("Adicionar idades(1)\n");
         printf("Verificar a mais velha e a nova(2)\n");
         printf("Verificar idades(4)\n");
         printf("Sair(0)\n");

         switch(getch())
         {
            case '1':
            for(int i = 0; i < sizeof(idade); i++)
            {
                system("cls");
                printf("Tamanho de idade = %d\n", strlen(idade));
                printf("idade(%d): ", i);
                scanf("%i", &idade[i]);
                 
                if(idade[i] > 122)
                {
                    printf("Deve ser menor que 122.");
                    i--; getch();
                }
                if(idade[i] == 0)
                    break;
            } break;
             
            case '2':
            velha = 0;
            for(int i = 0; i < strlen(idade); i++)
            {
                velha = velha > idade[i] ? velha : idade[i];
                nova = nova < idade[i] ? nova : idade[i];
            }
            system("cls");
            printf("Pessoa mais velha: %d\nPessoa mais nova: %d", velha, nova);
            getch(); break;

            case '4':
            system("cls");
            for(int i = 0; i < strlen(idade); i++)
            {
                printf("Idade(%d) = %d\n", i, idade[i]);
            } getch(); break;
             
            case '0': exit(1);
         }
     }
 }