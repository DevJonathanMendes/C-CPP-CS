#include <iostream>
using std::cin;
using std::cout;
using std::endl;

#include "Account.h"

int main(){
    Account Jonathan(2500), Mendes(3500);
    int moneyJonathan, moneyMendes;

    cout << "Current balance of Jonathan: " << Jonathan.getBalance() << endl;
    cout << "Value to add for Jonathan: R$ ";
    cin >> moneyJonathan;
    Jonathan.credit(moneyJonathan);
    cout << "Jonathan Balance: R$ " << Jonathan.getBalance() << endl;
    cout << endl;

    cout << "Current balance of Mendes: " << Mendes.getBalance() << endl;
    cout << "Value to withdraw from Mendes: R$ ";
    cin >> moneyMendes;
    Mendes.debit(moneyMendes);
    cout << "Mendes balance: R$ " << Mendes.getBalance() << endl;

    return 0;
}