using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitarioConsole.Classes
{
    public class ValidacoesLista
    {
        public bool AcharNumeroX(List<int> List, int x){
            return List.Contains(x);
        }

        public List<int> MultiplicarPorX(List<int> List, int x){
            List<int> Multiplicada = new List<int>();
            foreach (var item in List){
                Multiplicada.Add(item*x);
            }
            return Multiplicada;
        }
        
        public int MaiorX(List<int> list){
            return list.Max();
        }
        public int MenorX(List<int> list){
            return list.Min();
        }

        public List<int> SemNegativos (List<int> list){
            List<int> newlist = new List<int>();
            foreach (var item in list)
            {
                if (item >0){
                    newlist.Add(item);
                }
            }
            return newlist;
        }





}

}
