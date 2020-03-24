#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

float Media (float x, float y)
{
    return ((x+y)/2);
}
void Conceito (float n)
{
    if (n>=7)
    {
        printf ("\nAprovado");
    }
    else
    {
        printf ("\nReprovado");
    }
}
int main()
{
    float n1, n2, media;
    printf ("digite um valor: ");
    scanf ("%f", &n1);
    printf ("digite outro valor: ");
    scanf ("%f", &n2);
    media = Media (n1,n2);
    printf ("A media entre %f e %f eh igual a %f", n1, n2, media);
    Conceito (media);
    return 0;
}
