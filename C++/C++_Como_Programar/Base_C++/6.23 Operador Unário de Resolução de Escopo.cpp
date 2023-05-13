#include <iostream>
using std::cout;
using std::endl;

int number = 7; // Variável global.

int main(){
    double number = 10.5; // Variável local.

    // Variável local e global.
    cout << "Local double value of number = " << number
         << "\nGlobal int value of number = " << ::number << endl;
         return 0;
}