#include <iostream>
using std::cin;
using std::cout;
using std::endl;

int main(){
    int accountNumber;
    double balance, fees, credits, creditLimit;

    while(1){
        // Solicita o número da conta.
        cout << "[-1 to finish]\n" << "Enter account number: ";
        cin >> accountNumber;
        if(accountNumber == -1)
            return 1;

        // Solicita o saldo inicial.
        cout << "Enter the opening balance: ";
        cin >> balance;
        if(balance == -1)
            return 2;

        // Solicita o total de taxas.
        cout << "Enter the total fees: ";
        cin >> fees;
        if(fees == -1)
            return 3;

        // Solicita o total de créditos.
        cout << "Enter your total credits: ";
        cin >> credits;
        if(credits == -1)
            return 4;

        // Solicita o limite de créditos.
        cout << "Enter the credit limit: ";
        cin >> creditLimit;
        if(creditLimit == -1)
            return 5;

        // Processa os dados.
        cout << "New balance : " << balance + fees - credits << endl;
        if(balance + fees - credits > creditLimit)
            cout << "Account     : " << accountNumber << endl;
            cout << "Credit limit: " << creditLimit << endl;
            cout << "Balance     : " << balance + fees - credits << endl;
            cout << "Credit limit exceeded." << endl;
    }
    return 0;
}