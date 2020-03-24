#include "TVeiculo.h"
#include <iostream>

using namespace std;

TVeiculo::TVeiculo()
{
    //ctor
}
 void TVeiculo:: SetModelo (string m)
{
    this -> modelo = m;
}

void TVeiculo:: SetMotor ()
{
    this -> motor.Cadastrar();
}
void TVeiculo :: SetVelmed (float v)
{
    this -> velmed = v;
}

string TVeiculo:: GetModelo ()
{
    return this -> modelo;
}

float TVeiculo:: GetVelmed ()
{
    return this -> velmed;
}

TMotor TVeiculo:: GetMotor ()
{
    return this -> motor;
}


TVeiculo::~TVeiculo()
{
    //dtor
}
