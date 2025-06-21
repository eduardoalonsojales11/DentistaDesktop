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
    public partial class FrmCadConsulta : Form
    {
        ConsultaService service = new ConsultaService();
        DentistaService serviceD = new DentistaService();
        PacienteService serviceP = new PacienteService();
        public FrmCadConsulta()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            try
            {
                var lista2 = serviceP.Listar();
                var listaP = new Dictionary<int, string>();
                listaP.Add(0, "Selecione um Paciente");
                foreach (var item in lista2)
                {
                    listaP.Add(item.Id, item.Nome);
                }
                cbPaciente.DataSource = new BindingSource(listaP, null);
                cbPaciente.DisplayMember = "value";
                cbPaciente.ValueMember = "key";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }

            try
            {
                var lista = serviceD.Listar();
                var listaD = new Dictionary<int, string>();
                listaD.Add(0, "Selecione um Dentista");
                foreach (var item in lista)
                {
                    listaD.Add(item.Id, item.Nome);
                }
                cbdentista.DataSource = new BindingSource(listaD, null);
                cbdentista.DisplayMember = "value";
                cbdentista.ValueMember = "key";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }
        }



        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (Convert.ToInt32(cbdentista.SelectedValue) == 0)
            {
                return "Selecione um Dentista!";
            }
            else if (Convert.ToInt32(cbPaciente.SelectedValue) == 0)
            {
                return "Selecione um Paciente!";
            }
            else if (dtData.Text == String.Empty)
            {
                return "Escolha uma data!";
            }
            if (dthorario.Text == string.Empty)
            {
                return "Escolha um Horário!";
            }
            

            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso";
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";

            try
            {
                ts.Text = ValidarCad();

                if (ts.Text == "Sucesso")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Consuklta Efeituado com Sucesso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        public Consulta objGerado()
        {
            Consulta obj = new Consulta();
            obj.IdDentista = Convert.ToInt32(cbdentista.SelectedValue);
            obj.IdPaciente = Convert.ToInt32(cbPaciente.SelectedValue);
            obj.Data = Convert.ToDateTime(dtData.Value.ToString("dd/MM/yyyy"));
            obj.HoraMarcada = dthorario.Value;
            obj.HoraInicio = Convert.ToDateTime("00:00");
            obj.HoraFim = Convert.ToDateTime("00:00");
            obj.Observacao = txtAnotacoes.Text;
            obj.Status = "Nao confirmado";



            return obj;
        }
    }   
}
