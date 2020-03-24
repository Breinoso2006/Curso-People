#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ano;
    printf("Digite o ano: ");
    scanf ("%i", &ano);
    if ((ano % 100)%4 ==0)
    {
        printf ("Este ano eh bissexto!");
    }
    else
    {
        printf("Este ano nao eh bissexto!");
    }
    return 0;
}
