#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{   setlocale(LC_ALL, "Portuguese");
    int n, i, div = 0;
    printf ("Escreva um número: \n");
    scanf ("%i", &n);
    for (i=1; i <= n; i ++)
    {
        if (n % i == 0)
        {
            div++;
        }
    }
    if (div == 2)
    {
        printf ("Este número é primo");
    }
    else
        {
            printf ("Este número não é primo");
        }
    return 0;
}
