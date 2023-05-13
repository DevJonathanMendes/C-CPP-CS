#include <iostream>
using std::cout;
using std::endl;

class Account{
    public:
        Account(int money){
            if(money >= 0)
                accountBalance = money;
            if(money < 0){
                money = 0;
                cout << "The initial balance is not valid, we are turning it to zero!" << endl;
            }
        }

        void credit(int money){
            if(money >= 0)
                accountBalance += money;
            if(money < 0)
                cout << "Invalid value. No changes were made." << endl;
        }

        void debit(int money){
            if(money <= accountBalance)
                accountBalance -= money;
            if(money > accountBalance)
                cout << "Debit amount exceeded account balance." << endl;
        }

        int getBalance(){
            return accountBalance;
        }

    private:
        int accountBalance;
};