#include <iostream>
using std::cout;
using std::endl;

#include <string>
using std::string;

class Employee{
    public:
        Employee(string name, string surname, int salary){
            setName(name);
            setSurname(surname);
            setSalary(salary);
        }

        void setName(string setName){
            name = setName;
        }

        void setSurname(string setSurname){
            surname = setSurname;
        }

        void setSalary(int setSalary){
            if(setSalary >= 0)
                salary += setSalary;
            if(setSalary < 0){
                //salary = 0;
                cout << "The amount provided does not correspond to the minimum wage (R$ 1200). No changes were made." << endl;
            }
        }

        string getName(){
            return name;
        }

        string getSurname(){
            return surname;
        }

        int getSalary(){
            return salary;
        }

    private:
        string name, surname;
        int salary = 0;
};