#include <iostream>
#include <iomanip>
using namespace std;

int main(){
    srand(time(0));
    const int arraySize = 10;
    static int bubble[arraySize];
    
    // Gera números aleatórios para o array.
    for(int i = 0; i < arraySize; i++)
        bubble[i] = 1 + rand() % 100;

    // Imprime o array gerado.
    for(int i = 0; i < arraySize; i++)
        cout << bubble[i] << endl;

    // Bubble Sort (Organiza o array).
    for(int i = 1; i < arraySize; i++){
        for(int j = 0; j < arraySize - 1; j++){
            if(bubble[j] > bubble[j + 1]){
                int x = bubble[j];
                bubble[j] = bubble[j + 1];
                bubble[j + 1] = x;
            }
        }
    }

    // Imprime o array organizado.
    cout << endl;
    for(int i = 0; i < arraySize; i++)
        cout << bubble[i] << endl;
}