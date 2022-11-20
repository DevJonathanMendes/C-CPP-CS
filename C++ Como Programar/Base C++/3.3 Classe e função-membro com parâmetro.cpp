// Definindo uma classe com uma função-membro.
// Define a classe GradeBook com uma função-membro que aceita um parâmetro.
// Cria um objeto GradeBook e chama sua função Message.

#include <iostream>

using std::cout;
using std::cin;
using std::endl;

#include <string>   // Programa utiliza classe de string padrão C++.
using std::string;  // programa utiliza string.
using std::getline; // programa utiliza getline.

class GradeBook{
    public:
		void Message(string Name){
			cout << "Welcome to the Grade Book, " << Name << "!" << endl;
		}
};

int main(){
    string YourName; // String de caracteres para armazenar o nome.
    GradeBook myGradeBook; // Cria um objeto GradeBook chamado myGradeBook.
    cout << "Please enter the name:" << endl;
    getline(cin, YourName); // Lê o nome com espaço em branco.
    cout << endl;
    myGradeBook.Message(YourName); // Chama a função-membro com parâmetro;
    return 0;
}