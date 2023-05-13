// Matemática com linha de argumento.

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){
    float x = 0;
    switch(*argv[2]){
        case '+': x = atof(argv[1]) + atof(argv[3]); break;
        case '-': x = atof(argv[1]) - atof(argv[3]); break;
        case 'x': x = atof(argv[1]) * atof(argv[3]); break;
        case 'd': x = atof(argv[1]) / atof(argv[3]); break;
    }
    printf("VALOR: %.2f", x);
}