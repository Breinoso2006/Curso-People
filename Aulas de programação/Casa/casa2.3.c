#include <stdio.h>
#include <stdlib.h>

int main()
{   int n1, n2;
    printf("Escreva um n\243meros:\n");
    scanf ("%i", &n1);
    printf ("Escreva outro n\243mero\n");
    scanf ("%i", &n2);
    if (n1 > n2)
        printf ("%i", n1);
    else
        printf ("%i", n2);
    return 0;
}
