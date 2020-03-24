#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    float n1, n2, n3, mediaParcial, provaFinal, mediaFinal; //ver se precisa da final mesmo
    printf ("Por favor, digite as 3 primeiras notas do aluno: \n");
    scanf ("%f %f %f", &n1, &n2, &n3);
    mediaParcial = (n1 + n2 + n3)/3;
    printf ("A media parcial deste aluno foi: %f \n", mediaParcial);
        if (mediaParcial >= 7)
        {
            printf ("Este aluno foi aprovado diretamente, com uma media de %f", mediaParcial);
        }
        else
        {
            if (mediaParcial < 4)
            {
                printf ("Este aluno foi reprovado diretamente, com uma media de %f", mediaParcial);
            }
            else
            {
                printf("Este aluno fez a prova final. Qual foi a nota dele nesta prova?\n");
                scanf ("%f", &provaFinal);
                mediaFinal = (mediaParcial + provaFinal)/2;
                    if (mediaFinal >= 7)
                    {
                        printf ("Este aluno foi aprovado com uma media final de %f.", mediaFinal);
                    }
                    else
                    {
                        printf ("Este aluno foi reprovado e ficou com uma media final de %f", mediaFinal);
                    }
        }
        }
    return 0;
}
