#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    int n1, n2, n3;
    printf("Digite 3 numeros: ");
    scanf ("%i, %i, %i", &n1, &n2, &n3);
    if ( n1 < n2 && n1 < n3 && n2 < n3)
    {
        printf ("%i - %i - %i", n1, n2, n3);
    }
    else
    {
        if (n1 < n2 && n1 < n3 && n3 < n2)
        {
            printf ("%i - %i - %i", n1, n3, n2);
        }
        else
        {
                if (n2 < n3 && n2 < n1 && n1 < n3)
                {
                    printf ("%i - %i - %i",n2, n1, n3);
                }
                else
                {
                    if (n2 < n3 && n2 < n1 && n3 < n1)
                    {
                        printf ("%i - %i - %i", n2, n3, n1);
                    }
                    else
                    {
                        if (n3 < n1 && n3 < n2 && n1 < n2)
                        {
                            printf ("%i - %i - %i", n3, n1, n2);
                        }
                        else
                            printf ("%i - %i - %i",n3, n2, n1);
                    }
                }
        }
    }
    return 0;
}
