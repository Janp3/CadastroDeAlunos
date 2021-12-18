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
    public partial class Form1 : Form
    {
        public List<Aluno> alunos = new List<Aluno>();
    
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Aluno al = new Aluno();
         
            al.Nome = txtNome.Text;
            al.Materia = txtMateria.Text;
            al.Notas = new double[3];
            if (txtN1.Text == "" || txtN2.Text == "" || txtN3.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMateria.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Conferindo nota se maior que 10
            else if (double.Parse(txtN1.Text) > 10)
            {
                MessageBox.Show("Não aceitamos notas maior que 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtN2.Text) > 10)
            {
                MessageBox.Show("Não aceitamos notas maior que 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtN3.Text) > 10)
            {
                MessageBox.Show("Não aceitamos notas maior que 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // conferindo nota se menor que 0
            else if (double.Parse(txtN1.Text) < 0)
            {
                MessageBox.Show("Deve haver algum erro. Sua nota é menor que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtN2.Text) < 0)
            {
                MessageBox.Show("Deve haver algum erro. Sua nota é menor que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtN3.Text) < 0)
            {
                MessageBox.Show("Deve haver algum erro. Sua nota é menor que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                al.Notas[0] = double.Parse(txtN1.Text);
                al.Notas[1] = double.Parse(txtN2.Text);
                al.Notas[2] = double.Parse(txtN3.Text);
            }

            string resultado = al.Calcular();
            switch (resultado)
            {
                case "Aprovado":
                    MessageBox.Show("Você foi Aprovado",
                        "OK", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case "Recuperação":
                    MessageBox.Show("Você está de Recuperação",
                        "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
                case "Reprovado":
                    MessageBox.Show("Você foi Reprovado!",
                        "Deu Ruim", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
            }


        }
        
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Aluno al = new Aluno();

            if (txtN1.Text == "" || txtN2.Text == "" || txtN3.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMateria.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Conferindo nota se maior que 10
            else if (double.Parse(txtN1.Text) > 10)
            {
                MessageBox.Show("Não aceitamos notas maior que 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtN2.Text) > 10)
            {
                MessageBox.Show("Não aceitamos notas maior que 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtN3.Text) > 10)
            {
                MessageBox.Show("Não aceitamos notas maior que 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // conferindo nota se menor que 0
            else if (double.Parse(txtN1.Text) < 0)
            {
                MessageBox.Show("Deve haver algum erro. Sua nota é menor que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtN2.Text) < 0)
            {
                MessageBox.Show("Deve haver algum erro. Sua nota é menor que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtN3.Text) < 0)
            {
                MessageBox.Show("Deve haver algum erro. Sua nota é menor que 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                al.Nome = txtNome.Text;
                al.Materia = txtMateria.Text;
                al.Notas = new double[3];
                al.Notas[0] = double.Parse(txtN1.Text);
                al.Notas[1] = double.Parse(txtN2.Text);
                al.Notas[2] = double.Parse(txtN3.Text);
                alunos.Add(al);
            }

            txtNome.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtMateria.Text = "";

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            Tela2 telinha = new Tela2();
            telinha.alunos = alunos;
            telinha.Show();

        }
    }
}
