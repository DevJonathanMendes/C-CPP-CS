#include <iostream>
using std::cout;
using std::cin;
using std::endl;

#include <cstdlib>
using std::srand;
using std::rand;

#include <ctime>
using std::time;

// Dificuldade das perguntas.
const int dificulty = 10;

int main(){
    int num1, num2, result;
    srand(time(0));

    cout << "Dificulty is " << dificulty << endl;
    for(int counter = 1; counter <= 10; counter++){
        // Gera dois números para multiplicação.
        num1 = 1 + rand() % dificulty;
        num2 = 1 + rand() % dificulty;

        cout << "What is " << num1 << " times " << num2 << "?" << endl;

        // Repete até que a resposta esteja certa.
        while(1){
            cin >> result;
            if(result == num1 * num2){
                cout << "Very good!" << endl;
                break;
            }
            else
                cout << "No. Try again." << endl;
        }
    }

}
