using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesExample.Models;
using RazorPagesExample.Repository;

namespace RazorPagesExample.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EditModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [BindProperty]
        public Employee Employee { get; set; } = null!;
        public void OnGet(int id)
        {
            Employee = _employeeRepository.GetById(id);
        }

        public IActionResult OnPost()
        {
            Employee = _employeeRepository.Update(Employee);
            return RedirectToPage("/Employees/Index");
        }
    }
}
