﻿using Entidades;
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
    public partial class FrmConDentista : Form
    {
        DentistaService service = new DentistaService();
        public FrmConDentista()
        {
            InitializeComponent();
            IniciarFormulario();
        }
        public void IniciarFormulario()
        {
           

            var lista = service.Listar();
                if(lista == null)
                {
                    MessageBox.Show("Não existem dentistas cadastrados");
                }
                else
                {
                    char letraAnterior = '#';
                    int numTabela = -1;
                    DataGridView data = new DataGridView();

                    foreach(var dado in lista)
                    {
                        char primeiraLetra = dado.Nome.Trim()[0];
                        if (primeiraLetra.ToString() == letraAnterior.ToString().ToUpper()) 
                        {
                            GerarLinha(data, dado);
                        }
                        else
                        {
                            numTabela = numTabela + 1;
                            tc.TabPages.Add(primeiraLetra.ToString().ToUpper());
                            DataGridView dg = new DataGridView();
                            data = dg;
                            tc.TabPages[numTabela].Controls.Add(dg);
                            GerarTabela(dg);
                            GerarLinha(dg, dado);
                        }

                        letraAnterior = primeiraLetra;
                    }

                    
                }

        }

        private void GerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            dg.BackgroundColor = Color.White;
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;


            dg.Columns.Add("Codigo", "Código");
            dg.Columns[0].Visible = false;

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Nome";

            link.Name = "Nome";
            dg.Columns.Add(link);

            dg.Columns.Add("Telefone", "Telefone");
            dg.Columns.Add("Celular", "Celular");

            dg.CellContentClick += new DataGridViewCellEventHandler(this.tb_click);

        }

        

        private void GerarLinha(DataGridView data, Entidades.Dentista dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells[0].Value = dado.Id;
            data.Rows[linhaAtual].Cells[1].Value = dado.Nome;
            data.Rows[linhaAtual].Cells[2].Value = dado.Telefone.ToString("(00) 0000-0000");
            data.Rows[linhaAtual].Cells[3].Value = dado.Celular.ToString("(00) 00000-0000");
        }

        private void tb_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            try
            {
                if(e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    var id = dg.Rows[e.RowIndex].Cells[0].Value;
                    Dentista obj = service.Buscar(Convert.ToInt32(id));

                    var form = new FrmEditarDentista(obj);
                    form.ShowDialog();
                    
                    if(form.status == "apagado")
                    {
                        this.Close();
                        FrmConDentista frm = new FrmConDentista();
                        frm.ShowDialog();
                    }
                    if(form.status == "editado")
                    {
                        dg.Rows.RemoveAt(e.RowIndex);
                        GerarLinha(dg, obj);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao selecionar o Dentista " + ex.Message);
            }
        }
    }
}
