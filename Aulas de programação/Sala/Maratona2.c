#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    float fina, inicial, passo, celsius, fahrenheit, i;
    printf ("=====Conversor do Reinoso=====\n");
    printf ("\nPor favor, digite a temperatura inicial: ");
    scanf ("%f", &inicial);
    printf ("Por favor, agora digite a temperatura final: ");
    scanf ("%f", &fina);
    printf ("Agora, o passo: ");
    scanf ("%f", &passo);
    printf ("\n=====Celsius=====\n");
    celsius = inicial;
    while (celsius <= fina)
    {
        printf ("     %f\n", celsius);
        celsius += passo;
    }
    printf ("\n=====Fahrenheit=====\n");
    fahrenheit = (9*(inicial) + 160)/5;
    for (i = 0; fahrenheit <= (9*(fina)+ 160)/5; i++)
    {
        fahrenheit = (9*(inicial + passo*i) + 160)/5;
        printf ("     %f\n", fahrenheit);
    }
    return 0;
}
