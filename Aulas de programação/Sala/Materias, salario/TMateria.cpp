#include "TMateria.h"
#include <iostream>
#include <string>

using namespace std;

TMateria::TMateria()
{
    //ctor
}

string TMateria :: GetMateria ()
{
    return this -> materia;
}

void TMateria :: SetMateria (string m)
{
    this -> materia = m;
}

float TMateria :: GetCarga ()
{
    return this -> carga;
}

void TMateria :: SetCarga (float c)
{
    this -> carga = c;
}

float TMateria :: GetHoraaula ()
{
    return this -> horaaula;
}

void TMateria :: SetHoraaula (float h)
{
    this -> horaaula = h;
}

void TMateria :: Cadastrar ()

{
    string m;
    float c;
    float h;
    cout << "Materia: " << endl;
    cin.ignore();
    getline(cin, m);
    SetMateria (m);
    cout << "Carga Horaria: " << endl;
    cin >> c;
    SetCarga (c);
    cout << "Hora/Aula: " << endl;
    cin >> h;
    SetHoraaula (h);
}

TMateria::~TMateria()
{
    //dtor
}
