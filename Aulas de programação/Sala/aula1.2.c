#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{   int n;
    printf("Digite um numero: ");
    scanf ("%i", &n);
        if(n%2 == 0)
        {
            printf ("%i eh par!", n);
        }
        else
            printf ("%i nao eh par!", n);
    return 0;
}
