#ifndef TMOTOR_H
#define TMOTOR_H
#include <string>

using namespace std;

class TMotor
{
    public:
        TMotor();
        void SetModelo (string m);
        void SetAceleracao (float a);
        string GetModelo ();
        float GetAceleracao ();
        void Cadastrar ();
        ~TMotor();

    private:
        float aceleracao;
        string modelo;

};

#endif // TMOTOR_H
