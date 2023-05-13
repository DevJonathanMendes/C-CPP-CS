#include <iostream>
using namespace std;

int main(){
    const int arraySize = 11;
    int n[arraySize] = {0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1};

    cout << "Grade distribution:" << endl;

    // Para cada elemento do array n, gera saída de uma barra do gráfico.
    for(int i = 0; i < arraySize; i++){
        // Gera a saída do rótulo das barras ("0-9:", ..., "90-99:", "100:")
        if(i == 0)
            cout << "  0-9: ";
        else if(i == 10)
            cout << "  100: ";
        else
            cout << i * 10 << "-" << (i * 10) + 9 << ": ";

        // Imprime a barra de asteriscos
        for(int stars = 0; stars < n[i]; stars++)
            cout << "*";

        cout << endl;
    }
    return 0;
}