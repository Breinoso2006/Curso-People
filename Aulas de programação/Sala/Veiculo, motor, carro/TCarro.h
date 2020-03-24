#ifndef TCARRO_H
#define TCARRO_H
#include <string>
#include "TVeiculo.h"

using namespace std;

class TCarro: public TVeiculo
{
    public:
        TCarro();
        void SetTurbo (float t);
        float GetTurbo ();
        void Cadastrar ();
        float Correr (float distancia);
        void Exibir ();
        ~TCarro ();

    private:
        float turbo;
};

#endif // TCARRO_H
