// Definindo uma classe com uma função-membro.
// Define a classe GradeBook com uma função-membro " void displayMessage()".
// Cria um objeto GradeBook e chama sua função displayMessage.

#include <iostream>
using std::cout; // Programa utiliza cout.
using std::cin;  // Programa utiliza cin.
using std::endl; // Programa utiliza endl.

// Definição da classe GradeBook.
class GradeBook{
    public: // Especificador de acesso - "Disponível ao público", pode ser chamada por outras funções no programa e por funções-membro de outras classes.
    
		// Função-membro de que exibe uma mensagem ao usuário do GradeBook.
		void displayMessage(){
			cout << "Welcome to the Grade Book!" << endl;
		}
};

int main(){
    GradeBook myGradeBook; // Cria um objeto GradeBook chamado myGradeBook.
    myGradeBook.displayMessage(); // Chama a função displayMessage do objeto.
    return 0; // Indica terminação bem-sucedida.
}