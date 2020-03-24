#include <stdio.h>
#include <stdlib.h>

int main()
{
    int v1, v2;
    printf("Ola! Por favor, digite os valores pedidos. \n");
    printf ("Valor 1: ");
    scanf ("%i", &v1);
    printf ("Valor 2: ");
    scanf ("%i", &v2);
        if ( v1 > v2)
        {
            printf (" %i -- %i", v2,v1);
        }
        else
        {
            printf ("%i -- %i", v1, v2);
        }
    return 0;
}
