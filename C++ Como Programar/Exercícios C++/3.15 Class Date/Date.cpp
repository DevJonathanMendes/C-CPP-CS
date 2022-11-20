#include <iostream>
using std::cout;
using std::endl;

#include "Date.h"

int main(){
    Date jonathanBirthday(18, 1, 2001);
    cout << "Jonathan's birthday" << endl;
    jonathanBirthday.displayDate();
    return 0;
}