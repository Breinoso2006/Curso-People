#include <stdio.h>
#include <stdlib.h>

int fatorial (int n)
{
    int resultado = 1, i;
    for (i = n; i>= 1; i--)
    {
        resultado *=i;
    }
    return resultado;
}
int main()
{   int n;
    printf("Escreva um numero \n");
    scanf ("%i", &n);
    printf ("%i", fatorial (n));
    return 0;
}
