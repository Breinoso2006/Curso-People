#ifndef TVEICULO_H
#define TVEICULO_H
#include "TMotor.h"
#include <string>

using namespace std;

class TVeiculo
{
    public:
        TVeiculo();
        void SetModelo (string m);
        void SetVelmed (float v);
        void SetMotor ();
        string GetModelo ();
        float GetVelmed ();
        TMotor GetMotor ();
        ~TVeiculo ();
    protected:
        string modelo;
        TMotor motor;
        float velmed;
};

#endif // TVEICULO_H

