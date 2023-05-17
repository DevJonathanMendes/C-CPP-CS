// Fig. 8.9: Employee.cs.
// A definição da classe Employee encapsula o primeiro nome,
// o sobrenome, data de nascimento e a data de contratação do funcionário.

namespace console;

using System;

public class Employee
{
    private string firstName, lastName;
    private Date birthDate, hireDate;

    public Employee(string first, string last,
        int birthDay, int birthMonth, int birthYear,
        int hireDay, int hireMonth, int hireYear)
    {
        firstName = first;
        lastName = last;

        birthDate = new Date(birthDay, birthMonth, birthYear);
        hireDate = new Date(hireDay, hireMonth, hireYear);
    }

    public string ToEmployeeString()
    {
        return $"Employee: {firstName} {lastName}\n"
        + $"Birthday: {birthDate.ToDateString()}\n"
        + $"Hired: {hireDate.ToDateString()}\n";
    }
}