#include <iostream>
using namespace std;

int checkFirstClass(int[]);
int checkEconomicClass(int[]);

int firstClass(int[], int);
int economicClass(int[], int);

int main()
{
    const int arraySize = 10;
    int seats[arraySize] = {1, 1, 1, 0, 1, 1, 1, 1, 1, 1};
    int choice;

    cout << "Please type 1 for \"First Class\"" << endl;
    cout << "Please type 2 for \"Economy\"" << endl;
    cout << "Choice: ";
    cin >> choice;

    // VALIDA O COMANDO DO USUÁRIO.
    while (choice != 1 && choice != 2)
    {
        cout << "\nInvalid choice!" << endl;
        cout << "Choice: ";
        cin >> choice;
    }

    // VERIFICA ASSENTOS DISPONÍVEIS NA PRIMEIRA CLASSE.
    if (choice == 1)
    {
        if (checkFirstClass(seats) == 5)
        {
            if (checkEconomicClass(seats) == 5)
            {
                choice = 3;
            }
            else
            {
                cout << "\nFirst class packed!\nGo to economy class?" << endl;
                cout << "Press 2 for yes.\nPress 3 for no.\nChoice: ";
                cin >> choice;
                while (choice != 2 && choice != 3)
                {
                    cout << "\nInvalid choice!" << endl;
                    cout << "Choice: ";
                    cin >> choice;
                }
            }
        }
    }

    // VERIFICA ASSENTOS DISPONÍVEIS NA CLASSE ECONÔMICA.
    if (choice == 2)
    {
        if (checkEconomicClass(seats) == 5)
        {
            if (checkFirstClass(seats) == 5)
            {
                choice = 3;
            }
            else
            {
                cout << "\nEconomy class packed!\nGo to first class?" << endl;
                cout << "Press 1 for yes.\nPress 3 for no.\nChoice: ";
                cin >> choice;
                while (choice != 1 && choice != 3)
                {
                    cout << "\nInvalid choice!" << endl;
                    cout << "Choice: ";
                    cin >> choice;
                }
            }
        }
    }

    cout << endl;
    switch (choice)
    {
    case 1:
        cout << "FIRST CLASS" << endl;
        cout << "SEAT: " << firstClass(seats, 5) << endl;
        break;

    case 2:
        cout << "ECONOMIC CLASS" << endl;
        cout << "SEAT: " << economicClass(seats, 5) << endl;
        break;
    case 3:
        cout << "Next flight leaves in 3 hours." << endl;
        break;
    }
    return 0;
}

// FUNÇÕES.
int checkFirstClass(int array[])
{
    int counter = 0;
    for (int i = 0; i < 5; i++)
    {
        if (array[i] == 1)
        {
            counter++;
        }
    }
    return counter;
}

int checkEconomicClass(int array[])
{
    int counter = 0;
    for (int i = 5; i < 10; i++)
    {
        if (array[i] == 1)
            counter++;
    }
    return counter;
}

int firstClass(int array[], int size)
{
    for (int i = 0; i < size; i++)
    {
        if (array[i] != 1)
        {
            array[i] = 1;
            return i + 1;
        }
    }
}

int economicClass(int array[], int size)
{
    for (int i = 5; i < size + 5; i++)
    {
        if (array[i] != 1)
        {
            array[i] = 1;
            return i + 1;
        }
    }
}