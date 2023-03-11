using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitarioConsole.Classes
{
    public class ValidacoesString
    {
        public int QuantidadeDeCaractere (string s){
            return s.Length;
        }

        public bool ContemCaractere(string n1, string n2){
            return n1.Contains(n2);
        }
        public bool TerminaCom(string n1, string n2){
            return n1.EndsWith(n2);
        }
    }
}