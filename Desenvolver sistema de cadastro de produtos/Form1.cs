using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desenvolver_sistema_de_cadastro_de_produtos
{
    public partial class Form1 : Form
    {
        List<Produto> ListadeProdutos = new List<Produto>();

        List<Produto> ListadeCategorias = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string categoria = txtCategoria.Text;
            decimal preco = decimal.Parse(txtPreco.Text);
            
            if (nome != "" && categoria != "" && preco != null)
            {
                Produto sobreCategorias = new Produto( nome,  categoria,  preco);

                sobreCategorias.cadastrarProduto();

                ListadeCategorias.Add(sobreCategorias);

                Produto novoProduto = new Produto(nome, categoria, preco);
                ListadeProdutos.Add(novoProduto);

                AtualizarLista();
                MessageBox.Show("Produto cadastrado com sucesso!");

                cBoxCatego.Items.Add(txtCategoria.Text);

                LimparCampos();

            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
                LimparCampos();

            }
        }
        public void AtualizarLista()
        {
            ListadeProdutosData.DataSource = null;
            ListadeProdutosData.DataSource = ListadeProdutos;

        }
        public void LimparCampos()
        {
            txtNome.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
        }   
    }
}
