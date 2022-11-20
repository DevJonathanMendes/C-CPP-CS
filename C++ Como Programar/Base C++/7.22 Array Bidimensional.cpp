#include <iostream>
#include <iomanip>
using namespace std;

void printArray(const int[][3]);

int main(){
    srand(time(0));
    int array1[2][3] = {{1, 2, 3}, {4, 5, 6}};
    int array2[2][3] = {1, 2, 3, 4, 5};
    int array3[2][3] = {{1, 2}, {4}};

    cout << "Values in array1 by row are:" << endl;
    printArray(array1);

    cout << "\nValues in array2 by row are:" << endl;
    printArray(array2);

    cout << "\nValues in array2 by row are:" << endl;
    printArray(array2);

    return 0;
}

// Gera saída do array com duas linhas e três colunas.
void printArray(const int a[][3]){

    // Faz um loop pelas linhas do array.
    for(int i = 0; i < 2; i++){

        // Faz um loop pelas colunas da linha atual.
        for(int j = 0; j < 3; j++)
            cout << a[i][j] << ' ';
        
        cout << endl; // Inicia nova linha de saída.
    }
}