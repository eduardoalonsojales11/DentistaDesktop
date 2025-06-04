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
    public partial class FrmEditarPaciente : Form
    {
        
        public string status;
        Paciente obj = new Paciente();
        PacienteService service = new PacienteService();
        public FrmEditarPaciente(Paciente obj)
        {
            InitializeComponent();
            
        }
    }
    
}
