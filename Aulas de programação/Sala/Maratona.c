#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

int numeromaiorVetor (int n)
{   int i, V[10], maior = 0;
    if (n < 0)
    {
        n *= -1;
    }
    for (i = 0; i < 10; i++)
    {
        V [i] = n % 10;
        n = n/10;
            if (V[maior] < V[i])
            {
                maior = i;
            }
    }
    return V [maior];
}
int main()
{   int n;
    setlocale(LC_ALL, "Portuguese");
    printf("Por favor, dê um número de no máximo 10 dígitos: ");
    scanf ("%i", &n);
    printf ("Então, meu querido(a), o maior dígito deste número é %i", numeromaiorVetor (n));
    return 0;
}
