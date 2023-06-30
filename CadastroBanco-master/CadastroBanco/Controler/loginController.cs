using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroBanco.Model;
using CadastroBanco.Classes;

namespace CadastroBanco.Controler
{
    class loginController
    {
        public bool tem;
        public string mensagem;

        public bool Entrar(string usuario, string senha)
        {
            Login login = new Login();
            tem = login.VerificarLogin(usuario, senha);
            if (!login.mensagem.Equals(""))
            {
                this.mensagem = login.mensagem;
            }
            return tem;
        }
    }
}
