using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class TFilme
    {
        public int id;
        public String nome;
        public String sinopse;
        public int duracao;
        public int lancamento;
        public String genero;
        public int classificacao;

        public void SetId (int i)
        {
            id = i;
        }
        public int GetId ()
        {
            return id;
        }

        public void SetNome (String n)
        {
            nome = n;
        }
        public String GetNome ()
        {
            return nome;
        }

        public void SetSinopse (String s)
        {
            sinopse = s;
        }

        public String GetSinopse ()
        {
            return sinopse;
        }

        public void SetDuracao (int d)
        {
            duracao = d;
        }
        public int GetDuracao ()
        {
            return duracao;
        }

        public void SetLancamento (int l)
        {
            lancamento = l;
        }
        public int GetLancamento ()
        {
            return lancamento;
        }

        public void SetGenero (String g)
        {
            genero = g;
        }
        public String GetGenero ()
        {
            return genero;
        }

        public void SetClassificacao (int c)
        {
            classificacao = c;
        }
        public int GetClassificacao ()
        {
            return classificacao;
        }
    }
}
