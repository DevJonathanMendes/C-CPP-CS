#include <stdio.h>

void BSort(int v[], int n){
    for(int i = 1; i < n; i++){
        for(int j = 0; j < n - i; j++){
            if(v[j] > v[j + 1]){
                int x = v[j];
                v[j] = v[j + 1];
                v[j + 1] = x;
            }
        }
    }
}

int main(void){
    int lista[9] = {92, 80, 71, 63, 55, 41, 39, 27, 14};
    BSort(lista, 9);
    printf("%d", lista[0]);
}