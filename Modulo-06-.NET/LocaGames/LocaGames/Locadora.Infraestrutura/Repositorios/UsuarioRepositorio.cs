using Locadora.Dominio.Entidades;
using Locadora.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Repositorios
{
    public class UsuarioRepositorio
    {
        static readonly Dictionary<string, Usuario> _usuarios = new Dictionary<string, Usuario>();

        static UsuarioRepositorio()
        {
            // YWRtaW5AY3dpLmNvbS5icjoxMjM0NTY=
            var admin = new Usuario("admin", "admin@exemplo.com", "123456");
            admin.AtribuirPermissoes("Administrador");
            _usuarios.Add(admin.Email, admin);

            // Z2lvdmFuaUBjd2kuY29tLmJyOjEyMzQ1Ng==
            var funcionario = new Usuario("funcionario", "funcionario@exemplo.com", "123456");
            _usuarios.Add(funcionario.Email, funcionario);
        }

        public UsuarioRepositorio()  { }

        public void Criar(Usuario usuario)
        {
            _usuarios.Add(usuario.Email, usuario);
        }

        public void Alterar(Usuario usuario)
        {
            _usuarios[usuario.Email] = usuario;
        }
        public void Excluir(Usuario usuario)
        {
            _usuarios[usuario.Email] = usuario;
        }

        public IEnumerable<Usuario> Listar()
        {
            return _usuarios.Select(u => u.Value);
        }

        public Usuario Obter(string email)
        {
            return _usuarios.Where(u => u.Key == email).Select(u => u.Value).FirstOrDefault();
        }
    }
}