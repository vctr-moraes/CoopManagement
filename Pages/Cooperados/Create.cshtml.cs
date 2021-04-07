using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoopManagement.Models.Cooperados;
using CoopManagement.Interfaces;
using CoopManagement.ViewsModels;

namespace CoopManagement.Pages.Cooperados
{
    public class CreateModel : PageModel
    {
        private readonly ICooperadoRepository _cooperadoRepository;
        private readonly ICursoRepository _cursoRepository;

        public CreateModel(ICooperadoRepository cooperadoRepository, ICursoRepository cursoRepository)
        {
            _cooperadoRepository = cooperadoRepository;
            _cursoRepository = cursoRepository;
            CooperadoVM = new CooperadoViewModel();
        }

        [BindProperty]
        public CooperadoViewModel CooperadoVM { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Cooperado cooperado = new Cooperado
            {
                Bairro = CooperadoVM.Bairro,
                Cep = CooperadoVM.Cep,
                Cidade = CooperadoVM.Cidade,
                CotaParte = decimal.Parse(CooperadoVM.CotaParte),
                Cpf = CooperadoVM.Cpf,
                Curso = await _cursoRepository.ObterCurso(CooperadoVM.CursoId),
                CursoId = CooperadoVM.CursoId,
                DataExpedicaoRg = CooperadoVM.DataExpedicaoRg,
                DataMatricula = CooperadoVM.DataMatricula,
                DataNascimento = CooperadoVM.DataNascimento,
                Email = CooperadoVM.Email,
                Escolaridade = (Escolaridade)CooperadoVM.Escolaridade,
                Estado = CooperadoVM.Estado,
                EstadoCivil = (EstadoCivil)CooperadoVM.EstadoCivil,
                Logradouro = CooperadoVM.Logradouro,
                Matricula = CooperadoVM.Matricula,
                Nacionalidade = CooperadoVM.Nacionalidade,
                Naturalidade = CooperadoVM.Naturalidade,
                NecessidadeEspecial = (NecessidadeEspecial)CooperadoVM.NecessidadeEspecial,
                Nome = CooperadoVM.Nome,
                NomeMae = CooperadoVM.NomeMae,
                NomePai = CooperadoVM.NomePai,
                OrgaoExpedidorRg = CooperadoVM.OrgaoExpedidorRg,
                RacaCor = (RacaCor)CooperadoVM.RacaCor,
                RendaFamiliar = CooperadoVM.RendaFamiliar,
                Rg = CooperadoVM.Rg,
                Sexo = (Sexo)CooperadoVM.Sexo,
                StatusMatricula = (StatusMatricula)CooperadoVM.StatusMatricula,
                TelefoneCelular = CooperadoVM.TelefoneCelular,
                TelefoneResidencial = CooperadoVM.TelefoneResidencial,
                Turma = CooperadoVM.Turma
            };

            try
            {
                await _cooperadoRepository.SalvarCooperado(cooperado);
                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }

        public override PageResult Page()
        {
            InicializarCooperado();
            return base.Page();
        }

        private void InicializarCooperado()
        {
            if (CooperadoVM != null)
            {
                CooperadoVM.Cursos = _cursoRepository.ObterTodosCursos()
                    .Select(c => new SelectListItem
                    {
                        Text = c.Nome,
                        Value = c.Id.ToString()
                    });
            }
        }
    }
}
