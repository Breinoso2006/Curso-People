#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    int vetor [5], j, aux, i;
    vetor [0] = 4;
    vetor [1] = 1;
    vetor [2] = 3;
    vetor [3] = 5;
    vetor [4] = 2;
    for (j = 0; j <=4; j++)
    {
        for (i = 0; i <= 4; i++)
        {
            if (vetor [i] > vetor [i + 1])
            {
                aux = vetor [i];
                vetor [i] = vetor [i+1];
                vetor [i + 1] = aux;
            }
        }
    }
    for (i = 0; i <= 4; i++)
    {
        printf ("%i", vetor [i]);
    }
    return 0;
}
