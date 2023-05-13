#include <iostream>
using std::cout;
using std::endl;

// Protótipo de função que especifica argumentos-padrão.
int boxVolume(int length = 1, int width = 1, int height = 1);

int main(){
    // Nenhum argumento (Utiliza valores-padrão para todas as dimensões)
    cout << "The default box volume is: " << boxVolume();

    // Especifica o compimento; largura e altura é padrão.
    cout << "\n\nThe volume of a box with length 10,\n"
         << "width 1 and height 1 is: " << boxVolume(10);

    // Especifica o comprimento e largura; altura é padrão.
    cout << "\n\nThe volume of a box with length 10,\n"
         << "width 5 and height 1 is: " << boxVolume(10, 5);

    // Especifica todos os argumentos.
    cout << "\n\nThe volume of a box with length 10,\n"
         << "width 5 and height 2 is: " << boxVolume(10, 5, 2)
         << endl;
    return 0;
}

// Função boxVolume calcula o volume de uma caixa.
int boxVolume(int length, int width, int height){
    return length * width * height;
}