#include <iostream>
using std::cout;
using std::endl;

int integerPower(int, unsigned int);

int main(){
    cout << "intergerPower: " << integerPower(6, 4) << endl;
}

int integerPower(int base, unsigned int exponent){
    int x = 1;
    for(int counter = exponent; counter > 0; counter--){
        if(exponent == 0) return 1;
        if(exponent == 1) return base;
        x *= base;
    }
}