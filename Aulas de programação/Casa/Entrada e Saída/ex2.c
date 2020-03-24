#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>

int main()
{
    float raio, altura, volume;
    printf("Ola! Para calcular o volume de uma esfera precisarei que informe:\nRaio:");
    scanf ("%f", &raio);
    printf ("Altura: ");
    scanf ("%f", &altura);
    volume = M_PI * raio * raio * altura;
    printf ("Seu volume sera: %f", volume);
    return 0;
}
