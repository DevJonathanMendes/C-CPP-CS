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
    int num1, num2, result, hits = 0;
    srand(time(0));

    cout << "Dificulty is " << dificulty << endl;
    for(int counter = 1; counter <= 3; counter++){
        // Gera dois números para multiplicação.
        num1 = 1 + rand() % dificulty;
        num2 = 1 + rand() % dificulty;

        cout << "What is " << num1 << " times " << num2 << "?" << endl;

        // Repete até que a resposta esteja certa.
        while(1){
            cin >> result;
            if(result == num1 * num2){
                switch(rand() % 4){
                    case 0:
                    cout << "Very good!" << endl;
                    break;

                    case 1:
                    cout << "Excellent!" << endl;
                    break;

                    case 2:
                    cout << "Good job!" << endl;
                    break;

                    case 3:
                    cout << "Keep it up!" << endl;
                    break;
                }
                hits++;
                break;
            }
            else
                switch(rand() % 4){
                    case 0:
                    cout << "No. Try again." << endl;
                    break;

                    case 1:
                    cout << "Wrong. Try one more time." << endl;
                    break;

                    case 2:
                    cout << "Do not give up!" << endl;
                    break;

                    case 3:
                    cout << "No. Keep trying." << endl;
                    break;
                }
                break;
        }
    }
    cout << "You got " << hits << " out of 10 right." << endl;
    if(hits >= 7)
        cout << "Congratulations!" << endl;
    if(hits < 7)
        cout << "Ask your teacher for extra help.";
}
