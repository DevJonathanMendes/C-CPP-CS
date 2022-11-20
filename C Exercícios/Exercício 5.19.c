/* Exercício 5.19.
 *
 * Codifique a função strins(s,c,p), que insere o caracter s na posição p da string s.
 * Se a posição p não existe em s, o caracter deve ser inserido no final da string.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <string.h>
#define tam 15

void sdel(char s[], char c, int p){
    int i = 0;
    int go = 1;

    while(i < strlen(s)){
        s[i] = s[i];
        if(s[i] == s[p]){
            s[i] = c;
            go = 0;
        }
        i++;
    }
    if(go == 1){
        s[i] = c;
    }
    printf("%s", s);
}

int main(void){
    char nome[tam] = "Tico";
    sdel(nome, 'd', 2);
}