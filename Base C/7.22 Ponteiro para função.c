// Ponteiro para função.

#include <stdio.h>

int menor(int x, int y) {return x > y;}
int maior(int x, int y) {return x < y;}
int minimax(int v[], int n, int (*cmp)(int, int)){
    int x = v[0];
    for(int i = 0; i < n; i++)
        if(cmp(x, v[i]))
            x = v[i];
    return x;
}
int main(void){
    int w[5] = {78, 34, 12, 45, 51};
    printf("menor: %d\n", minimax(w, 5, menor));
    printf("maior: %d\n", minimax(w, 5, maior));
}