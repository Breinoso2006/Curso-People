#include "TMotor.h"
#include <iostream>

using namespace std;

TMotor::TMotor()
{
    //ctor
}

void TMotor :: SetModelo (string m)
{
    this -> modelo = m;
}

void TMotor :: SetAceleracao (float a)
{
    this -> aceleracao = a;
}

string TMotor :: GetModelo ()
{
    return this -> modelo;
}

float TMotor:: GetAceleracao ()
{
    return this -> aceleracao;
}

void TMotor :: Cadastrar ()
{
    cout << "--- CADASTRO DE MOTOR ---" << endl;
    cout << "Modelo: ";
    getline (cin, this -> modelo);
    cout << endl << "Aceleracao: ";
    cin >> this -> aceleracao;
    cout << endl;
}

TMotor::~TMotor()
{
    //dtor
}
