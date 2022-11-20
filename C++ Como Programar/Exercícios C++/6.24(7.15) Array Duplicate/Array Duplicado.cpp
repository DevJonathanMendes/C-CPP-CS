#include <iostream>
#include <iomanip>
using namespace std;

int main(){
    srand(time(0));
    const int size = 20;
    int numbers[size];

    for(int i = 0; i < size; i++){
        numbers[i] = 10 + rand() % 90;
        for(int j = i; j > 0; j--)
            if(numbers[i] == numbers[j - 1])
                i--;
    }

    for(int i = 0; i < size; i++)
        cout << numbers[i] << endl;
}