#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    int tamanho;
    tamanho = 3;
    int vetor [tamanho];
    int x;
    for (x = 0; x <tamanho; x++)
    {
        printf ("Digite o elemento na posicao %i\n", x);
        scanf ("%i", &vetor[x]);
    }
    printf ("===================================");
    x = 0;
    while (x < tamanho)
    {
        printf ("\n%i\n", vetor [x]);
        x++;
    }
    return 0;
}
