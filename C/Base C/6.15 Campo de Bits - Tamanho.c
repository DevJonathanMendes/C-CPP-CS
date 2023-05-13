// Campos de Bits

#include <stdio.h>

typedef struct{
    unsigned a : 1; // 1 bit
    signed   b : 3; // 3 bit
    unsigned c : 8; // 8 bit
} amostra;

int main(void){
    static amostra x = {14, 14, 14};
    printf("%d  %d  %d", x.a, x.b, x.c);
}