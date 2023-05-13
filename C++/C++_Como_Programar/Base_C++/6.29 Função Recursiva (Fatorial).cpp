// Testando a função fatorial.

#include <iostream>
using std::cout;
using std::endl;

#include <iomanip>
using std::setw;

unsigned long factorial(unsigned long);

int main(){
    // Calcula o fatorial de 0 a 10;
    for(int counter = 0; counter <= 10; counter++)
        cout << setw(2) << counter << "! = " << factorial(counter)
             << endl;
    
    return 0;
}

// Definição recursiva da função fatorial.
unsigned long factorial(unsigned long number){
    if(number <= 1) // Testa caso básico.
        return 1; // Casos básicos: 0! = 1 e 1! = 1
    else // Passo de recursão.
        return number * factorial(number - 1);
}