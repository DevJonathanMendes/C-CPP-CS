// Pesquisa linear de um array.
#include <iostream>
using namespace std;

int linearSearch(const int[], int, int);

int main(){
    const int arraySize = 100; // Tamanho do array.
    int a[arraySize];
    int searchKey; // Valor a localizar no array.

    for(int i = 0; i < arraySize; i++)
        a[i] = 2 * i; // Cria alguns dados.

    cout << "Enter integer search key: ";
    cin >>searchKey;

    // Tenta localizar a searchKey no array.
    int element = linearSearch(a, searchKey, arraySize);

    // Exibe os resultados.
    if(element != -1)
        cout << "Found value in element " << element << endl;
    else
        cout << "Value not found" << endl;
    
    return 0;
}

//Compara a chave com cada elemento do array.
int linearSearch(const int array[], int key, int sizeOfArray){
    for(int j = 0; j < sizeOfArray; j++)
        if(array[j] == key) // Se localizado
            return j; // retorna a localização da chave.

    return -1;
}