using Microsoft.AspNetCore.Mvc;
using Projeto1.Repository;

namespace Projeto1.Controllers
{
    public class UsuarioController : Controller
    {
        // Declarando uma variável privada somente para leitura do tipo UsuarioRepository chamada _UsuarioRepository
        private readonly UsuarioRepository _usuarioRepository;

        // Definindo o construtor da classe UsuarioController que vai receber uma instancia de UsuarioRepository.
        public UsuarioController(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            /* Chama o método ObterUsuario do _usuarioRepositorio, passando o email fornecido pelo usuário.
     Isso buscará um usuário no banco de dados com o email correspondente.*/
            var usuario = _usuarioRepository.ObterUsuario(email);
            // Verifica se um usuário foi encontrado for diferente de vazio e se a senha fornecida corresponde à senha do usuário encontrado.
            if (usuario != null && usuario.Senha == senha)
            {
                // Autenticação bem-sucedida
                // Redireciona o usuário para a action "Index" do Controller "Cliente".
                return RedirectToAction("Cliente", "Cliente");
            }

            /* Se a autenticação falhar (usuário não encontrado ou senha incorreta):
    Adiciona um erro ao ModelState. ModelState armazena o estado do modelo e erros de validação.
    O primeiro argumento ("") indica um erro
    O segundo argumento é a mensagem de erro que será exibida ao usuário.*/

            ModelState.AddModelError("", "Email ou senha inválidos.");

            //retorna view Login 
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
    }
}
