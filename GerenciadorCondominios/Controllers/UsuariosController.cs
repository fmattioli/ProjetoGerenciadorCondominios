using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL.Interfaces;
using GerenciadorCondominios.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorCondominios.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public UsuariosController(IUsuarioRepositorio usuarioRepositorio, IWebHostEnvironment webHostEnvironment)
        {
            this._usuarioRepositorio = usuarioRepositorio;
            this._webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Registro(RegistroViewModel model, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                if (foto != null)
                {
                    string diretorioPasta = Path.Combine(_webHostEnvironment.WebRootPath, "Imagens");
                    string nomeFoto = Guid.NewGuid().ToString() + foto.FileName;
                    using (FileStream fileStream = new FileStream(Path.Combine(diretorioPasta, nomeFoto), FileMode.Create))
                    {
                        await foto.CopyToAsync(fileStream);
                        model.Foto = "~/Imagens/" + nomeFoto;
                    }
                }

                Usuario usuario = new Usuario();
                IdentityResult usuarioCriado;

                if (_usuarioRepositorio.VerificarSeExisteRegistro() == 0)
                {
                    usuario.UserName = model.Nome;
                    usuario.CPF = model.CPF;
                    usuario.Email = model.Email;
                    usuario.PhoneNumber = model.Telefone;
                    usuario.Foto = model.Foto;
                    usuario.PrimeiroAcesso = false;
                    usuario.Status = StatusConta.Aprovado;

                    usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);
                    if (usuarioCriado.Succeeded)
                    {
                        await _usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, "Administrador");
                        await _usuarioRepositorio.LogarUsuario(usuario, false);
                        return RedirectToAction("Index", "Usuarios");
                    }
                }


                usuario.UserName = model.Nome;
                usuario.CPF = model.CPF;
                usuario.Email = model.Email;
                usuario.PhoneNumber = model.Telefone;
                usuario.Foto = model.Foto;
                usuario.PrimeiroAcesso = true;
                usuario.Status = StatusConta.Analisando;

                usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);
                if (usuarioCriado.Succeeded)
                {
                    return View("Analise", usuario.UserName);
                }
                else
                {
                    foreach (IdentityError item in usuarioCriado.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(model);
                }

            }
            return View(model);
        }

        public IActionResult Analise(string nome)
        {
            return View(nome);
        }
    }
}
