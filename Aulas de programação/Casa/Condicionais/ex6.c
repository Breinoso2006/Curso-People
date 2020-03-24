#include <stdio.h>
#include <stdlib.h>

int main()
{
    float h;
    printf("Digite sua altura.\n(Ex: 1.68)\n");
    scanf ("%f", &h);
    if (h >= 1.7)
    {
        if (h >=1.8)
        {
            if (h >=1.9)
            {
                if (h >=2)
                {
                    printf ("Arranha-ceu!");
                }
                else
                {
                    printf ("Gigante!");
                }
            }
            else
            {
                printf ("Grande!");
            }
        }
    }
        else
        {
            if (h >= 1.6)
            {
                printf ("Normal");
            }
            else
            {
                if (h > 1.5)
                {
                    printf ("Reinoso!");
                }
                else
                {
                    printf ("Anao!");
                }
            }
        }
    return 0;
}
