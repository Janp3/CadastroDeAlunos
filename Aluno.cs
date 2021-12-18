using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunoClasse
{
    public class Aluno
    {
        public string Nome;
        public string Materia;
        public double[] Notas;
        

        public string Calcular()
        {
            double media, soma = 0;
            //aprovado ou recuperação ou reprovado
            for (int i = 0; i < 3; i++)
                soma += Notas[i];
            
            media = soma / 3;
            if (media >= 7)
                return "Aprovado";
            else if (media > 5)
                return "Recuperação";
            else
                return "Reprovado";
        }
    }
}
