#include <iostream>

int main(){
    static double lastVal = 99.99;
    std::cout << lastVal;
}