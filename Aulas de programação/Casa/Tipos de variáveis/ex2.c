#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    int divisor, dividendo, resto, quociente;
    printf("Digite o numero desejado e o seu divisor: ");
    scanf ("%i %i", &dividendo , &divisor);
    resto = dividendo % divisor;
    quociente = dividendo / divisor;
    printf ("O quociente desta divisao eh %i e seu resto eh %i", quociente, resto);
    return 0;
}
