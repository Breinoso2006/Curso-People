using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    
    public class TUsuario
    {
        public String nome;
        public char sexo;
        public int nivel;
        public String endereco;
        public DateTime nascimento;
        public int id;

        public void SetId(int i)
        {
            id = i;
        }
        public int GetId()
        {
            return id;
        }
        public void SetNome(String n)
        {
            nome = n;
        }
        public String GetNome ()
        {
            return nome;
        }

        public void SetNivel (int n)
        {
            nivel = n;
        }
        public int GetNivel ()
        {
            return nivel;
        }

        public void SetSexo (char s)
        {
            sexo = s;
        }
        public char GetSexo ()
        {
            return sexo;
        }

        public void SetNascimento (DateTime n)
        {
            nascimento = n;
        }
        public DateTime GetNascimento ()
        {
            return nascimento;
        }

        public void SetEndereco (String e)
        {
            endereco = e;
        }
        public String GetEndereco ()
        {
            return endereco;
        }
    }
}
