// Soma os elementos de um array unidimensional recursivamente.

#include <iostream>
using namespace std;

int whatIsThis(int[], int);

int main(){
    const int size = 10;
    int a[size] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int result = whatIsThis(a, size);

    cout << "Result is " << result << endl;
    return 0;
}

int whatIsThis(int b[], int size){
    if (size == 1)
        return b[0];
    else
        return b[size - 1] + whatIsThis(b, size - 1);
}