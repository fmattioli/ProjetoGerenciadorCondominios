using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL;
using GerenciadorCondominios.DAL.Repositorios;
using GerenciadorCondominios.DAL.Interfaces;

namespace GerenciadorCondominios.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly IVeiculoRepositorio _veiculoRepositorio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public VeiculosController(IVeiculoRepositorio veiculoRepositorio, IUsuarioRepositorio usuarioRepositorio)
        {
            this._veiculoRepositorio = veiculoRepositorio;
            this._usuarioRepositorio = usuarioRepositorio;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VeiculoId,Nome,Marca,Cor,Placa,UsuarioId")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = await _usuarioRepositorio.PegarUsuarioPeloNome(User);
                veiculo.UsuarioId = usuario.Id;
                await _veiculoRepositorio.Inserir(veiculo);
                return RedirectToAction("MinhasInformacoes", "Usuarios");
            }
            return View(veiculo);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var veiculo = await _veiculoRepositorio.PegarPeloId(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return View(veiculo);
        }

        
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("VeiculoId,Nome,Marca,Cor,Placa,UsuarioId")] Veiculo veiculo)
        {
            if (id != veiculo.VeiculoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _veiculoRepositorio.Atualizar(veiculo);
                return RedirectToAction("MinhasInformacoes", "Usuarios");
            }
            return View(veiculo);
        }

        
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _veiculoRepositorio.Excluir(id);
            return Json("Veículo excluido com sucesso!!!");
        }

    }
}
