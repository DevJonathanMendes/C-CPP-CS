#include <iostream>
using std::cout;
using std::endl;

void useLocal(void);
void useStaticLocal(void);
void useGlobal(void);

int x = 1; // Variável global.

int main(){
    int x = 5; // Variável global.

    cout << "Local x in main's outer scope is " << x << endl;

    { // Inicia novo escopo.
        int x = 7; // Oculta x no escopo externo.

        cout << "Local x in main's inner scope is " << x << endl;
    }

    cout << "Local x in main's outer scope is " << x << endl;

    useLocal(); // useLocal tem uma variável local x
    useStaticLocal(); // useStaticLocal tem x estático local
    useGlobal(); // useGlobal utiliza x global
    useLocal(); // useLocal reinicializa seu x local
    useStaticLocal(); // x estático local retém seu valor anterior
    useGlobal(); // x global também retém seu valor

    cout << "\nlocal x in main is " << x << endl;
    return 0;
}

// useLocal reinicializa a variável local x durante cada chamada
void useLocal(void){
    int x = 25; // Inicializa toda vez que useLocal é chamada.

    cout << "\nLocal x is " << x << " on entering useLocal" << endl;
    x++;
    cout << "local x is " << x << " on exiting useLocal" << endl;
}

// useStaticLocal inicializa a variável estática local x somente
// na primeira vez em que a função é chamada; o valor de x é salvo
// entre as chamadas a essa função

void useStaticLocal(void){
    static int x = 50; // Inicializada na primeira vez em que useStaticLocal é chamada.

    cout << "\nlocal static x is " << x << " on entering useStaticLocal" << endl;
    x++;
    cout << "local static x is " << x << " on exiting useStaticLocal" << endl;
}

void useGlobal(void){
    cout << "\nGlobal x is " << x << " on entering useGlobal" << endl;
    x *= 10;
    cout << "Global x is " << x << " on exiting useGlobal" << endl;
}