#include <iostream>
#include <iomanip>
using namespace std;

int main(){
    srand(time(0));
    const int arraySize = 10;
    int data[arraySize];
    int insert;

    for(int i = 0; i < arraySize; i++)
        data[i] = rand() % 100;

    cout << "Unsorted array:\n";

    // Gera saída do array original.
    for(int i = 0; i < arraySize; i++)
        cout << setw(4) << data[i];

    // Classificação por inserção.
    // Itera pelos elementos do array.
    for(int next = 1; next < arraySize; next++){
        insert = data[next]; // Armazena o valor no elemento atual.
        int moveItem = next; // Inicializa a localização para colocar elemento.

        // Procura a localização em que colocar o elemento atual.
        while((moveItem > 0) && (data[moveItem - 1] > insert)){
            // Desloca o elemento uma posição para a direita.
            data[moveItem] = data[moveItem - 1];
            moveItem--;
        }

        data[moveItem] = insert; // Lugar em que o elemento é inserido no array.
    }

    cout << "\nSorted array:\n";

    // Gera a saída do array classificado.
    for(int i = 0; i < arraySize; i++)
        cout << setw(4) << data[i];

    cout << endl;
    return 0;
}