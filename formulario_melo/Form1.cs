using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using formulario_melo.Classes;

namespace formulario_melo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cpf.MaxLength = 12;
            cpf.Mask = "000.000.000-00";
            rg.MaxLength = 12;
            rg.Mask = "000.00.00";
            nome.MaxLength = 100;
            pai.MaxLength = 100;
            mae.MaxLength = 100;
            endereco.MaxLength = 80;
            numero.MaxLength = 20;
            complemento.MaxLength = 60;
            bairro.MaxLength = 60;
            cidade.MaxLength = 60;
            try {
                Funcionario f = new Funcionario();
                List<Funcionario> lista = f.lista();
                gridlista.Rows.Clear();
                gridlista.ColumnCount = 14;
                foreach (Funcionario funcionario in lista)
                {
                    gridlista.Rows.Add(
                       funcionario.codigo,
                       funcionario.nome,
                       funcionario.rua,
                       funcionario.numero,
                       funcionario.complemento,
                       funcionario.bairro,
                       funcionario.cidade,
                       funcionario.uf,
                       funcionario.pais,
                       funcionario.data,
                       funcionario.cpf,
                       funcionario.rg,
                       funcionario.pai,
                       funcionario.mae
                    );
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        public String estado(String uf)
        {
            switch (uf)
            {
                case "Acre":
                    uf = "ac";
                    break;
                case "Alagoas":
                    uf = "al";
                    break;
                case "Amazonas":
                    uf = "am";
                    break;
                case "Amapá":
                    uf = "ap";
                    break;
                case "Bahia":
                    uf = "ba";
                    break;
                case "Ceará":
                    uf = "ce";
                     break;
                case "Distrito Federal":
                    uf = "df";
                    break;
                case "Espírito Santo":
                    uf = "es";
                    break;
                case "Goiás":
                    uf = "go";
                    break;
                case "Maranhão":
                    uf = "ma";
                    break;
                case "Mato Grosso":
                    uf = "mt";
                    break;
                case "Mato Grosso do Sul":
                    uf = "ms";
                    break;
                case "Minas Gerais":
                    uf = "mg";
                    break;
                case "Pará":
                    uf = "pa";
                    break;
                case "Paraíba":
                    uf = "pb";
                    break;
                case "Paraná":
                    uf = "pr";
                    break;
                case "Pernambuco":
                    uf = "pe";
                    break;
                case "Piauí":
                    uf = "pi";
                    break;
                case "Rio de Janeiro":
                    uf = "rj";
                    break;
                case "Rio Grande do Norte":
                    uf = "rn";
                    break;
                case "Rondônia":
                    uf = "ro";
                    break;
                case "Rio Grande do Sul":
                    uf = "rs";
                    break;
                case "Roraima":
                    uf = "rr";
                    break;
                case "Santa Catarina":
                    uf = "sc";
                    break;
                case "Sergipe":
                    uf = "se";
                    break;
                case "São Paulo":
                    uf = "sp";
                    break;
                case "Tocantins":
                    uf = "to";
                    break;
            }
            return uf;
        }
        private void bt_cadastra_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario f = new Funcionario();
                f.nome = nome.Text;
                f.cpf = cpf.Text;
                f.rg = rg.Text;
                f.data = nascimento.Text;
                f.pai = pai.Text;
                f.mae = mae.Text;
                f.pais = pais.Text;
                f.uf = estado(uf.Text);
                f.rua = endereco.Text;
                f.numero = int.Parse(numero.Text);
                f.complemento = complemento.Text;
                f.bairro = bairro.Text;
                f.cidade = cidade.Text;

                f.inserir(f);
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void pesquisa_Click(object sender, EventArgs e)
        {
            try {
                Funcionario f = new Funcionario();
                List<Funcionario> lista = f.Pesquisa(lCpf.Text, int.Parse(codigo.Text), lrg.Text);
                gridlista.Rows.Clear();
                gridlista.ColumnCount = 14;
                foreach (Funcionario funcionario in lista)
                {
                    gridlista.Rows.Add(
                       funcionario.codigo,
                       funcionario.nome,
                       funcionario.rua,
                       funcionario.numero,
                       funcionario.complemento,
                       funcionario.bairro,
                       funcionario.cidade,
                       funcionario.uf,
                       funcionario.pais,
                       funcionario.data,
                       funcionario.cpf,
                       funcionario.rg,
                       funcionario.pai,
                       funcionario.mae
                    );
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void listar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario f = new Funcionario();
                List<Funcionario> Pesquisa = f.Pesquisa("", int.Parse(codigoUpdate.Text), "");
                foreach (Funcionario funcionario in Pesquisa)
                {
                    nomeUpdate.Text = funcionario.nome;
                    cpfUpdate.Text = funcionario.cpf;
                    rgUpdate.Text = funcionario.rg;
                    dataUpdate.Text = funcionario.data;
                    paiUpdate.Text = funcionario.pai;
                    maeUpdate.Text = funcionario.mae;
                    paisUpdate.Text = funcionario.pais;
                    endercoUpdate.Text = funcionario.rua;
                    numeroUpdate.Text = funcionario.numero.ToString();
                    complemento.Text = funcionario.complemento;
                    bairroUpdate.Text = funcionario.bairro;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
