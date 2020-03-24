#include "TCarro.h"
#include <string>
#include <iostream>

using namespace std;

TCarro::TCarro()
{
    //ctor
}

void TCarro:: SetTurbo (float t)
{
    this -> turbo = t;
}
float TCarro:: GetTurbo ()
{
    return this -> turbo;
}

void TCarro :: Cadastrar ()
{
    cout << "--- CADASTRO DE CARRO ---" << endl;
    cout << "Modelo: ";
    getline (cin, this -> modelo);
    cout << endl << "Motor: ";
    this -> SetMotor ();
    cout << "Velocidade Media: ";
    cin >> this -> velmed;
    cout << endl << "Turbo: ";
    cin >> this -> turbo;

}

float TCarro:: Correr (float distancia)
{
    float novav, novaa;
    novav = this -> velmed - (this -> turbo * this -> velmed);
    novaa = this -> GetMotor().GetAceleracao() + (this -> turbo * this -> GetMotor().GetAceleracao());
}

TCarro::~TCarro()
{
    //dtor
}
