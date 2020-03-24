#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>2

int main()
{
    float km, mi;
    printf("Digite o valor desejado em km/h: ");
    scanf ("%f", &km);
    mi = km / 1.60934;
    printf ("Seu valor em mi/h eh: %f", mi);
    return 0;
}
