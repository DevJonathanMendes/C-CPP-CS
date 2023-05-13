// Simulação do jogo de dados Craps.

#include <iostream>
using std::cout;
using std::endl;

#include <cstdlib>
using std::rand;
using std::srand;

#include <ctime>
using std::time;

int rollDice();

int main(){
    // Enumeração em constantes que representam o status do jogo.
    enum Status{CONTINUE, WON, LOST}; // Todas as maiúsculas em constantes.

    int myPoint; // Pontos se não ganhar ou perder na primeira rolagem.
    Status gameStatus; // Pode conter CONTINUE, WON ou LOST.

    // Torna aleatório o gerador de número aleatório utilizando a hora atual.
    srand(time(0));

    int sumOfDice = rollDice(); // Primeira rolagem dos dados.

    // Determina status e pontuação do jogo (se Necessário) com base no primeiro lançamento de dados.
    switch(sumOfDice){
        case 7: // Ganha com 7 no primeiro lançamento.
        case 11: // Ganha com 11 no primeiro lançamento.
            gameStatus = WON;
            break;
        case 2: // Perde com 2 no primeiro lançamento.
        case 3: // Perde com 3 no primeiro lançamento.
        case 12: // Perde com 12 no primeiro lançamento.
            gameStatus = LOST;
            break;
        default: // Não ganhou nem perdeu, portanto registra a pontuação.
            gameStatus = CONTINUE; // Jogo não terminou.
            myPoint = sumOfDice; // Informa a pontuação.
            cout << "Point in " << myPoint << endl;
            break; // Opcional no final do switch.
    }

    // Enquanto o jogo não estiver completo.
    while(gameStatus == CONTINUE){ // Nem WON nem LOST.
        sumOfDice = rollDice();

        // Determina o status do jogo.
        if(sumOfDice == myPoint) // Vitória por pontuação.
            gameStatus = WON;
        else
            if(sumOfDice == 7) // Perde obtendo 7 antes de atingir a pontuação.
                gameStatus = LOST;
    }

    // Exibe uma mensagem ganhou ou perdeu.
    if(gameStatus == WON)
        cout << "Player wins" << endl;
    else
        cout << "Player loses" << endl;

    return 0;
}

// Lança os dados, calcula a soma e exibe os resultados.
int rollDice(){
    int die1 = 1 + rand() % 6; // Primeiro lançamento do dado.
    int die2 = 1 + rand() % 6; // Segundo lançamento do dado.

    int sum = die1 + die2; // Calcula a soma de valores do dado.

    // Exibe os resultados desse lançamento.
    cout << "Player rolled " << die1 << " + " << die2
         << " = " << sum << endl;
    return sum;
}