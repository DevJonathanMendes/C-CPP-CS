// Demonstrando o template de classe vector da C++ Standard Library.
#include <iostream>
using std::cout;
using std::cin;
using std::endl;

#include <iomanip>
using std::setw;

#include <vector>
using std::vector;

void outputVector(const vector<int> &); // Exibe o vetor.
void inputVector(vector<int> &); // Insere valores no vetor.

int main(){
    vector<int> integers1(7); // vector<int> de 7 elementos.
    vector<int> integers2(10); //vector<int> de 10 elementos.

    // Imprime o tamanho e o conteúdo de integers1.
    cout << "Size of vector integers1 is " << integers1.size()
         << "\nvector after initialization:" << endl;
         outputVector(integers1);

    // Imprime o tamanho e o conteúdo de integer2.
    cout << "\nSize of vector integers2 is " << integers2.size()
         << "\nvector after initialization:" << endl;
         outputVector(integers2);

    // Insere e imprime integers1 e integers2.
    cout << "\nEnter 17 integers:" << endl;
    inputVector(integers1);
    inputVector(integers2);

    cout << "\nAfter input, the vectors contain:\n"
         << "integers1:" << endl;
         outputVector(integers1);
         cout << "integers2:" << endl;
         outputVector(integers2);

    // Utiliza operador de desigualdade (!=) com objetos vector
    cout << "\nEvaluating: integers1 != integers2" << endl;

    if(integers1 != integers2)
        cout << "integers1 and integers2 are not equal" << endl;

    // Cria o vector integers3 utilizando integral como um
    // Inicializador; imprime tamanho e conteúdo
    vector<int> integers3(integers1); // Construtor de cópia.

    cout << "\nSize of vector integers3 is " << integers3.size()
         << "\nvector after initialization:" << endl;
         outputVector( integers3 );

    // utiliza operador atribuição (=) sobrecarregado
    cout << "\nAssigning integers2 to integers1:" << endl;
    integers1 = integers2; // integers1 é maior que integers2
    
    cout << "integers1:" << endl;
    outputVector( integers1 );
    cout << "integers2:" << endl;
    outputVector( integers2 );

    // utiliza operador de igualdade (==) com objetos vector
    cout << "\nEvaluating: integers1 == integers2" << endl;

    if ( integers1 == integers2 )
    cout << "integers1 and integers2 are equal" << endl;
    
    // utiliza colchetes para criar rvalue
    cout << "\nintegers1[5] is " << integers1[ 5 ];
    
    // utiliza colchetes para criar lvalue
    cout << "\n\nAssigning 1000 to integers1[5]" << endl;
    integers1[ 5 ] = 1000;
    cout << "integers1:" << endl;
    outputVector( integers1 );
    
    // tentativa de utilizar subscrito fora do intervalo
    cout << "\nAttempt to assign 1000 to integers1.at( 15 )" << endl;
    integers1.at( 15 ) = 1000; // ERRO: fora do intervalo
    return 0;
}

// gera saída do conteúdo do vetor
void outputVector( const vector< int > &array ){
    size_t i; // declara a variável de controle
    
    for ( i = 0; i < array.size(); i++ ){
        cout << setw( 12 ) << array[ i ];
        if ( ( i + 1 ) % 4 == 0 ) // 4 números por linha de saída
            cout << endl;
    }
    if ( i % 4 != 0 )
        cout << endl;
}

// insere o conteúdo de vetor
void inputVector( vector< int > &array ){
    for ( size_t i = 0; i < array.size(); i++ )
        cin >> array[ i ];
}