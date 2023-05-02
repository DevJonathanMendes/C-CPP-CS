#include <iostream>
using std::cout;
using std::cin;
using std::endl;

#include <cstdlib>
using std::srand;
using std::rand;

#include <ctime>
using std::time;

int flip(void){
    return rand() % 2;
}

int main(){
    int heads = 0, tails = 0;
    srand(time(0));

    for(int counter = 1; counter <= 100; counter++){
        switch(flip()){
        case 0:
            tails++;
            break;
            
        case 1:
            heads++;
            break;
        }
    }
    cout << "Heads: " << heads << endl;
    cout << "Tails: " << tails << endl;
}
