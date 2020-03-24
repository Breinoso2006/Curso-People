#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    int n1, n2, r;
    char comando;

    printf("Ola, por favor digite os valores pedidos. \n");
    printf ("Valor 1: ");
    scanf ("%i", &n1);
    printf ("Valor 2: ");
    scanf ("%i", &n2);
    printf ("Digite o sinal da operacao desejada:");
    scanf ("\n%c", &comando);
        switch (comando)
        {
            case '+': r = n1 + n2;
            break;
            case '-': r = n1 - n2;
            break;
            case '*': r = n1 * n2;
            break;
            case '/': r = n1 / n2;
            break;
            default: printf ("Voce eh retardado '-'");
        }
    printf ("resultado = %i", r);
    return 0;
}
