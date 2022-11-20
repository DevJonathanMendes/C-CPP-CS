#include <iostream>
using std::cout;
using std::cin;
using std::endl;

#include <ctime>

unsigned long fibonacci(unsigned long);

int main(){
    // Calcula os valores de fibonacci de 0 a 10.
    for(int counter = 0; counter <= 40; counter++)
        cout << "Fibonacci(" << counter << ") = "
             << fibonacci(counter) << " Clock: " << clock() << endl;
    return 0;
}

// Função fibonacci recursiva.
unsigned long fibonacci(unsigned long number){
    if((number == 0) || (number == 1)) // Casos básicos.
        return number;
    else // Passo recursão.
        return fibonacci(number - 1) + fibonacci(number - 2);
}