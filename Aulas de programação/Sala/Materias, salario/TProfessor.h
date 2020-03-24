#ifndef TPROFESSOR_H
#define TPROFESSOR_H
#include "TMateria.h"
#include <string>

using namespace std;

class TProfessor
{
    public:
        TProfessor();
        string GetNome ();
        float GetSalario ();
        TMateria GetMaterias [];
        void SetNome (string n);
        void SetSalario (float s);
        void Cadastrar ();
        void CalculaSalario ();
        ~TProfessor();

    protected:

    private:
        string nome;
        float salario;
        TMateria materias [];
};

#endif // TPROFESSOR_H
