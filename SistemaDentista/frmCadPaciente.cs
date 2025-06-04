using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace SistemaDentista
{
    public partial class frmCadPaciente : Form
    {
        PacienteService service = new PacienteService();
        public frmCadPaciente()
        {
            InitializeComponent();
            txtNome.Text = txtCelular.Text;
        }


        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome!";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo Email!";
            }
            else if (txtTelefone.Text == string.Empty)
            {
                return "Preencha o campo Telefone!";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo Celular!";
            }
            else if (textCEP.Text == string.Empty)
            {
                return "Preencha o campo CEP!";
            }
            else if (textEndereco.Text == string.Empty)
            {
                return "Preencha o campo Endereço!";
            }
            else if (txtComplemento.Text == string.Empty)
            {
                return "Preencha o campo Complemento!";
            }
            else if (txtNascimento.Text == string.Empty)
            {
                return "Preencha o campo Data Nasc!";
            }
            else if (textSexo.Text == string.Empty)
            {
                return "Preencha o campo Sexo!";
            }

            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso";
            }


        }
        

        public Paciente objGerado()
        {
            Paciente obj = new Paciente();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.Complemento = txtComplemento.Text;
            obj.CEP = textCEP.Text;
            obj.Sexo = txtSexo.Text;
            
            obj.Endereco = txtEndereco.Text;


            return obj;
        }



        public void Limpar()
        {
            txtNome.Text = " ";
            txtEmail.Text = " ";
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtComplemento.Text = "";
            textEndereco.Text = "";
            txtNascimento.Text = "";
            textSexo.Text = "";
            textCEP.Text = "";
            
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";

            try
            {
                ts.Text = ValidarCad();

                if (ts.Text == "Sucesso")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Cadastro Efeituado com Sucesso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            FrmConPaciente frm = new FrmConPaciente();
            frm.ShowDialog();
        }
    }
}
