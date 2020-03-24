#include <iostream>

using namespace std;

class TPessoa
{
private:
    string nome;
    int idade;
    float altura;
public:
    TPessoa ();
    void Setnome (string n);
    string Getnome ();
    void Setidade (int i);
    string Getidade ();
    void Setaltura (float a);
    float Getaltura ();
    ~TPessoa ();
}
