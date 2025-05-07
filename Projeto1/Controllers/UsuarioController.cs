﻿using Microsoft.AspNetCore.Mvc;
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

            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
    }
}
