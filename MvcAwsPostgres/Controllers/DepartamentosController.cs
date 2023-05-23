using Microsoft.AspNetCore.Mvc;
using MvcAwsPostgres.Models;
using MvcAwsPostgres.Repositories;

namespace MvcAwsPostgres.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Departamento> departamentos =
                await this.repo.GetDepartamentosAsync();
            return View(departamentos);
        }

        public async Task<IActionResult> Details(int id)
        {
            Departamento departamento =
                await this.repo.FindDepartamentoAsync(id);
            return View(departamento);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Departamento departamento)
        {
            await this.repo.InsertDepartamento(departamento.IdDept
                , departamento.Nombre, departamento.Localidad);
            return RedirectToAction("Index");
        }
    }

}
