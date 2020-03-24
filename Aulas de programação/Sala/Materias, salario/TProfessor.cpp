#include "TProfessor.h"
#include <string>
#include "TMateria.h"
#include <iostream>

using namespace std;

TProfessor::TProfessor()
{
    //ctor
}

string TProfessor::GetNome()
{
    return this -> nome;
}

void TProfessor::SetNome(string n)
{
    this -> nome = n;
}

float TProfessor::GetSalario ()
{
    return this -> salario;
}

void TProfessor:: SetSalario (float s)
{
    this -> salario = s;
}

void TProfessor:: Cadastrar ()
{
    string n;
    float s;
    TMateria m;
    cout << "Nome: " << endl;
    cin.ignore();
    getline(cin, n);
    SetNome (n);
    for (int i =0; i <3 ; i++)
    {
        this -> materias[i].Cadastrar();
    }
    CalculaSalario();

}

void TProfessor :: CalculaSalario ()
{
    float s;
    s = 0;
    for (int i =0; i<3; i++)
    {
        s+= (this -> materias[i].GetHoraaula () * this -> materias[i].GetCarga());
    }
    this -> salario = s;
}
TProfessor::~TProfessor()
{
    //dtor
}
