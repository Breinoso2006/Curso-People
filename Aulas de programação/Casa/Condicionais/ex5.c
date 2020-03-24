#include <stdio.h>
#include <stdlib.h>

int main()
{
    int m, n;
    printf("Digite um numero: ");
    scanf ("%i", &m);
        if (m != 0)
        {
            if (m < 0)
            {
                n = -1;
            }
            else
            {
                n = 1;
            }
        }
        else
        {
            n = 0;
        }
    printf ("%i", n);
    return 0;
}
