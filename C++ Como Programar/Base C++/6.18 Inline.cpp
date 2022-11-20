// O qualificador inline deve ser utilizado somente com funções pequenas, frequentemente utilizadas.
// Utilizar funções inline pode reduzir o tempo de execução, mas pode aumentar o tamanho do programa.

#include <iostream>
using std::cout;
using std::cin;
using std::endl;

inline double cube(const double side){
    return side * side * side; // Calcula o cubo.
}

int main(){
    register double sideValue; // Armazena o valor inserido pelo usuário.
    cout << "Enter the side of your cube: ";
    cin >> sideValue; // Lê o valor fornecido pelo usuário.

    // Calcula o cubo de sideValue e exibe o resultado.
    cout << "Volume if cube with side "
        << sideValue << " is " << cube(sideValue) << endl;
    return 0;
}

// inline gera uma cópia da função.