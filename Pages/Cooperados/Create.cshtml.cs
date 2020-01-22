using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoopManagement.Models;
using CoopManagement.ViewsModels.Cooperados;

namespace CoopManagement.Pages.Cooperados
{
    public class CreateModel : PageModel
    {
        private readonly CoopManagementDbContext _context;

        public CreateModel(CoopManagementDbContext context)
        {
            _context = context;
            CooperadoVM = new CooperadoCreateEditViewModel();
        }

        public IActionResult OnGet()
        {
            ViewData["CursoId"] = new SelectList(_context.Curso, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public CooperadoCreateEditViewModel CooperadoVM { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                var cooperado = new Cooperado()
                {
                    Id = CooperadoVM.Id,
                    Nome = CooperadoVM.Nome,
                    Sexo = CooperadoVM.Sexo,
                    EstadoCivil = CooperadoVM.EstadoCivil,
                    DataNascimento = CooperadoVM.DataNascimento,
                    RacaCor = CooperadoVM.RacaCor,
                    NecessidadeEspecial = CooperadoVM.NecessidadeEspecial,
                    Cpf = CooperadoVM.Cpf,
                    Rg = CooperadoVM.Rg,
                    OrgaoExpedidorRg = CooperadoVM.OrgaoExpedidorRg,
                    DataExpedicaoRg = CooperadoVM.DataExpedicaoRg,
                    Naturalidade = CooperadoVM.Naturalidade,
                    Nacionalidade = CooperadoVM.Nacionalidade,
                    NomePai = CooperadoVM.NomePai,
                    NomeMae = CooperadoVM.NomeMae,
                    RendaFamiliar = CooperadoVM.RendaFamiliar,
                    Matricula = CooperadoVM.Matricula,
                    Curso = CooperadoVM.Curso,
                    Turma = CooperadoVM.Turma,
                    Escolaridade = CooperadoVM.Escolaridade,
                    Rua = CooperadoVM.Rua,
                    Bairro = CooperadoVM.Bairro,
                    Cidade = CooperadoVM.Cidade,
                    Cep = CooperadoVM.Cep,
                    Estado = CooperadoVM.Estado,
                    TelefoneResidencial = CooperadoVM.TelefoneResidencial,
                    TelefoneCelular = CooperadoVM.TelefoneCelular,
                    Email = CooperadoVM.Email,
                    DataMatricula = CooperadoVM.DataMatricula,
                    DataDesligamento = CooperadoVM.DataDesligamento,
                    CotaParte = CooperadoVM.CotaParte,
                    StatusMatricula = CooperadoVM.StatusMatricula
                };
            }
            catch (Exception)
            {
                return Page();
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
