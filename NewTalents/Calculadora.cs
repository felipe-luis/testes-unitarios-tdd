using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string Data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            Data = data;

        }

        public int Somar(int num1, int num2)
        {
            int soma = num1 + num2;

            listaHistorico.Insert(0, "Resultado: " + soma + " - Data: " + Data);
            return soma;
        }

        public int Subtrair(int num1, int num2)
        {
            int subtracao = num1 - num2;
            listaHistorico.Insert(0, "Resultado: " + subtracao + " - Data: " + Data);

            return subtracao;
        }

        public int Multiplicar(int num1, int num2)
        {
            int multiplicacao = num1 * num2;

            listaHistorico.Insert(0, "Resultado: " + multiplicacao + " - Data: " + Data);

            return multiplicacao;
        }

        public int Dividir(int num1, int num2)
        {
            int divisao = num1 / num2;

            listaHistorico.Insert(0, "Resultado: " + divisao +" - Data: " + Data);

            return divisao;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
