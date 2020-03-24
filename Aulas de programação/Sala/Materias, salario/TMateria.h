#ifndef TMATERIA_H
#define TMATERIA_H
#include <string>

using namespace std;

class TMateria
{
    public:
        TMateria();
        string GetMateria ();
        void SetMateria (string m);
        float GetCarga ();
        void SetCarga (float c);
        float GetHoraaula ();
        void SetHoraaula (float h);
        void Cadastrar ();
        ~TMateria();
    protected:

    private:
        string materia;
        float carga;
        float horaaula;
};

#endif // TMATERIA_H
