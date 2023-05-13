// Função com ponteiros.

#include <stdio.h>

int minimax(int v[], int n, int *a, int *b){
    for(int i = 0; i < n; i++){
        *a = v[i] < *a ? v[i] : *a;
        *b = v[i] > *b ? v[i] : *b;
    }
}

int soma(int *y){
    *y += 75;
    return *y;
}

int main(void){
    int valores[5] = {2, 4, 6, 8, 10};
    int a = 5, b = 5;
	soma(&a);
    minimax(valores, 5, &a, &b);
    printf("Valor de A: %d\n", a);
    printf("Valor de B: %d", b);
}