// Função square utilizada para demonstrar a pilha
// de chamadas de função e os registros de ativação.


#include <iostream>
using std::cin;
using std::cout;
using std::endl;

int square(int);

int main(){
    int a = 10; // Valor para square (variável automática local em main)

    cout << a << " Squared: " << square(a) << endl; // Exibe o quadrado de um int
    return 0;
}

// Retorna o quadrado de um inteiro
int square(int x){
    return x * x;
}