#include <cc50.h>
#include <conio.h>
#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int
main(void)
{
    // FORMULA c[i] = (p[i] + k[i]) % 26
    // a = 97 | z = 122
    
    printf("TEXTO: ");
    string p = GetString();
    printf("\nPALAVRA-CHAVE: ");
    string k = GetString();
    
    for(int i = 0; i < strlen(p); i++)
    {
        printf("");
    }
    
    // FINAL DO PROGRAMA.
    printf("\n");
    system("pause");
}