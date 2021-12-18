using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAlunoClasse
{
    public partial class Tela2 : Form
    {
        internal static Form1 telinha;
        public List<Aluno> alunos;
        public Tela2()
        {
            InitializeComponent();
        

        }


        private void Tela2_Load(object sender, EventArgs e)
        {

            lblQtdAlunos.Text = alunos.Count.ToString();
            double soma = 0, media = 0;
            for (int i = 0; i < alunos.Count; i++)
            {
                soma += alunos[i].Notas[0] +
                    alunos[i].Notas[1] +
                    alunos[i].Notas[2];
            }
            media = soma / (alunos.Count * 3);
            lblSoma.Text = soma.ToString();
            lblMedia.Text = media.ToString();
        }
    }
}
