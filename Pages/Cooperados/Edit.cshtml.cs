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
    public class EditModel : PageModel
    {
        private readonly ICooperadoRepository _cooperadoRepository;
        private readonly ICursoRepository _cursoRepository;

        public EditModel(ICooperadoRepository cooperadoRepository, ICursoRepository cursoRepository)
        {
            _cooperadoRepository = cooperadoRepository;
            _cursoRepository = cursoRepository;
            CooperadoVM = new CooperadoViewModel();
        }

        [BindProperty]
        public CooperadoViewModel CooperadoVM { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cooperado cooperado = await _cooperadoRepository.ObterCooperado(id);

            if (cooperado == null)
            {
                return NotFound();
            }

            CooperadoVM = new CooperadoViewModel(cooperado);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Cooperado cooperado = await _cooperadoRepository.ObterCooperado(CooperadoVM.Id);

            if (cooperado == null)
            {
                return NotFound();
            }

            cooperado.Bairro = CooperadoVM.Bairro;
            cooperado.Cep = CooperadoVM.Cep;
            cooperado.Cidade = CooperadoVM.Cidade;
            cooperado.CotaParte = CooperadoVM.CotaParte;
            cooperado.Cpf = CooperadoVM.Cpf;
            cooperado.Curso = await _cursoRepository.ObterCurso(CooperadoVM.CursoId);
            cooperado.CursoId = CooperadoVM.CursoId;
            cooperado.DataExpedicaoRg = CooperadoVM.DataExpedicaoRg;
            cooperado.DataMatricula = CooperadoVM.DataMatricula;
            cooperado.DataNascimento = CooperadoVM.DataNascimento;
            cooperado.Email = CooperadoVM.Email;
            cooperado.Escolaridade = (Escolaridade)CooperadoVM.Escolaridade;
            cooperado.Estado = CooperadoVM.Estado;
            cooperado.EstadoCivil = (EstadoCivil)CooperadoVM.EstadoCivil;
            cooperado.Logradouro = CooperadoVM.Logradouro;
            cooperado.Matricula = CooperadoVM.Matricula;
            cooperado.Nacionalidade = CooperadoVM.Nacionalidade;
            cooperado.Naturalidade = CooperadoVM.Naturalidade;
            cooperado.NecessidadeEspecial = (NecessidadeEspecial)CooperadoVM.NecessidadeEspecial;
            cooperado.Nome = CooperadoVM.Nome;
            cooperado.NomeMae = CooperadoVM.NomeMae;
            cooperado.NomePai = CooperadoVM.NomePai;
            cooperado.OrgaoExpedidorRg = CooperadoVM.OrgaoExpedidorRg;
            cooperado.RacaCor = (RacaCor)CooperadoVM.RacaCor;
            cooperado.RendaFamiliar = CooperadoVM.RendaFamiliar;
            cooperado.Rg = CooperadoVM.Rg;
            cooperado.Sexo = (Sexo)CooperadoVM.Sexo;
            cooperado.StatusMatricula = (StatusMatricula)CooperadoVM.StatusMatricula;
            cooperado.TelefoneCelular = CooperadoVM.TelefoneCelular;
            cooperado.TelefoneResidencial = CooperadoVM.TelefoneResidencial;
            cooperado.Turma = CooperadoVM.Turma;

            try
            {
                await _cooperadoRepository.AtualizarCooperado(cooperado);
                return await Task.FromResult(RedirectToPage("./Index"));
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
