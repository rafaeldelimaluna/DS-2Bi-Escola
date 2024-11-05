using System;
using System.Windows.Forms;
using Formulario.DAO;
using Model;
using Model.Entidades;

namespace WindowsFormsApp1.Formularios
{
    public partial class Login : Form
    {
        private UsuariosDAO conn;
        public Login()
        {
            InitializeComponent();
            conn = new UsuariosDAO();
        }

        public UsuariosEntidade Cadastro
        {
            get
            {
                var entidade = new UsuariosEntidade();
                entidade.Senha = SenhaTbx.Text;
                entidade.Nome=NomeTbx.Text;
                return entidade;
            }
            set
            {
                SenhaTbx.Text = value.Senha;
                NomeTbx.Text =value.Nome;
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var entidade = Cadastro;
            var login = conn.Login(entidade);

            MessageLbl.Text = $"{entidade.Nome} | {entidade.Senha}";
        }
    }
}
