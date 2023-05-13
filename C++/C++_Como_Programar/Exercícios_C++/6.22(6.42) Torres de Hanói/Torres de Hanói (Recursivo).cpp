#include <iostream>
using namespace std;

void hanoi(int n, int pinoInicial, int pinoFinal, int pinoTemp){
    if(n > 0){
    hanoi(n - 1, pinoInicial, pinoTemp, pinoFinal);
    cout << "Disco do pino " << pinoInicial << " para o pino " << pinoFinal << endl;
    hanoi(n - 1, pinoTemp, pinoFinal, pinoInicial);
    }
}

int main(){
    int n;
    cout << "Quantos discos? ";
    cin >> n;
    hanoi(n, 1, 3, 2);
}