/* Exercício 4.1.
 *
 * Inclua diretivas #define no programa a seguir de modo que ele possa ser compilador corretamente.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>

#define programa int main()
#define inicio {
#define fim }
#define diga printf


programa
inicio
    diga("Hello, World!");
fim