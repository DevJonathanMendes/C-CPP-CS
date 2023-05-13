#include <iostream>
using std::cout;
using std::endl;

#include "Employee.h"

int main(){
    Employee JonathanMendes("Jonathan", "Mendes", 3200), JohnMendes("John", "Mendes", 1200);

    cout << "Employee: " << JonathanMendes.getName() << " " << JonathanMendes.getSurname() << endl;
    cout << "Current annual salary: R$ " << JonathanMendes.getSalary() * 12 << endl;
    JonathanMendes.setSalary(0.1 * JonathanMendes.getSalary());
    cout << "New annual salary: R$ " << JonathanMendes.getSalary() * 12 << endl;

    cout << "\nEmployee: " << JohnMendes.getName() << " " << JohnMendes.getSurname() << endl;
    cout << "Current annual salary: R$ " << JohnMendes.getSalary() * 12 << endl;
    JohnMendes.setSalary(0.1 * JohnMendes.getSalary());
    cout << "New annual salary: R$ " << JohnMendes.getSalary() * 12 << endl;

    return 0;
}