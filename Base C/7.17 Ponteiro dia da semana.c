// Ponteiro dia da semana.

#include <stdio.h>

char *semana(int n)
{
    static char *dia[] = {"erro", "segunda", "terca", "quarta", "quinta", "sexta", "sabado", "domingo"};
    return dia[1 <= n && n <= 7 ? n : 0];
}

int main(void)
{
    semana(5);
    printf("Dia da semana: %s", semana(7));
}