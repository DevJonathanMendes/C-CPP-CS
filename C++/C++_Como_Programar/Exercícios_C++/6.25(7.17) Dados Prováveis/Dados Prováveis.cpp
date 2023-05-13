#include <iostream>
using std::cout;
using std::endl;

#include <cstdlib>
using std::srand;
using std::rand;

#include <ctime>
using std::time;

int main(){
    srand(time(0));
    static int dies[13] = {0};

    for(int counter = 0; counter < 32000; counter++){
        int die1 = 1 + rand() % 6;
        int die2 = 1 + rand() % 6;
        int soma = die1 + die2;
        dies[soma] += 1;
    }

    for(int i = 2; i <= 12; i++)
        cout << "Dies[" << i << "]: " << dies[i] << endl;
}