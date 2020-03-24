#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    float base, altura, p;
    printf("Para saber o perimetro do retangulo, digite o tamanho da base e da altura do mesmo: ");
    scanf ("%f %f", &base, &altura);
    p = 2 *(base + altura);
    printf ("Seu perimetor eh: %f", p);
    return 0;
}
