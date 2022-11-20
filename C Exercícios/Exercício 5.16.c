/* Exercício 5.16.
 *
 * Codifique a função scat(s,t), que concatena a string t ao final da string s.
 * Por exemplo, se x armazena "facil" e y armazena "idade", após a chamada scat(x,y), x estará armazenando "facilidade".
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>

#define tam 150

void scat(char s[], char t[]){
    int i = 0;
    while(t[i] != '\0'){
        i++;
        if(s[i] == '\0')
            for(int j = 0; t[j] != '\0'; j++)
                s[i + j] = t[j];
    }
}

int main(void){
    char x[tam] = "facil", y[tam] = "idade";
    scat(x, y);
    printf("%s", x);
}