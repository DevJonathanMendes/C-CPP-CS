/**************************
 * CRIPTOGRAFIA DE CAESAR *
 *    JONATHAN MENDES     *
 **************************/

#include <cc50.h>
#include <conio.h>
#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int
main(int argc, char *argv[])
{
    // FORMULA c[i] = (p[i] + k) % 26
    // a = 097 | A = 065
    // z = 122 | Z = 090 | SPACE = 32
    
    // INÍCIO.
    printf("TEXTO PARA CRIPTOGRAFAR: ");
    string p = GetString();
    printf("\nCHAVE: ");
    int k = GetInt();
    printf("\n");

    // SE O USUÁRIO NÃO DAR UM TEXTO E UM NÚMERO POSITIVO, O PROGRAMA PARA.
    if(k < 0)
    {
        printf("O PROGRAMA PRECISA DE UM TEXTO E UM INTEIRO DE 1 A 26");
        system("pause");
        return 1;
    }
    
    // PROCESSO DE CRiPTOGRAFIA.
    for(int i = 0, n = strlen(p); i < n; i++)
    { 
        // LETRAS MAIÚSCULAS + TRATAMENTO DE ESPAÇO
        if(isupper(p[i]) || isspace(p[i]))
        {
        if(p[i] + k > 90 && p[i] + k != 45)
        {
            p[i] -= 26;
        }
        if(p[i] + k < 65 && p[i] + k != 45)
        {
            p[i] += 26;
        }       
        if(p[i] == 32)
        {
            printf("%c", p[i]);
        }
        if(p[i] + k != 45)
        {
        printf("%c", p[i] + k);
        }
        }
            
        //LETRAS MINÚSCULAS
        if(islower(p[i]))
        {
        if(p[i] + k > 122)
        {
            p[i] -= 26;
        }
        if(p[i] + k < 97)
        {
            p[i] += 26;
        }
        if(p[i] + k)
        {
        printf("%c", p[i] + k);
        }
        }
    }
    
    // FINAL DO PROGRAMA.
    printf("\n");
    system("pause");
    return 0;
}