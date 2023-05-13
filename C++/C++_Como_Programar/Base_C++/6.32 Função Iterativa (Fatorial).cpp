#include <iostream>
using std::cout;
using std::endl;

#include <iomanip>
using std::setw;

unsigned long factorial(unsigned long);

int main(){
    // Calcula o fatorial de 0 a 10,
    for(int counter = 0; counter <= 10; counter++)
        cout << setw(2) << counter << " ! = " << factorial(counter) << endl;
    
    return 0;
}

// Função fatorial iterativa.
unsigned long factorial(unsigned long number){
    unsigned long result = 1;

    // Declaração iterativa da função fatorial.
    for(unsigned long i = number; i >= 1; i--)
        result *= i;
    
    return result;
}