#include <stdio.h>

// Função que aceita um parâmetro.
void displayMessage(char *name){ // Poderia ser "(char name[])" também.
    printf("\nWelcome to the Grade Book, %s!\n", name);
}

int main(void){
    char YourName[20];
    printf("Please enter the name:\n");
    gets(YourName);
    displayMessage(YourName); // Chama a função com parâmetro/argumento.
    return 0;
}