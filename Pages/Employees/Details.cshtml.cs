using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesExample.Models;
using RazorPagesExample.Repository;

namespace RazorPagesExample.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Employee Employee { get; set; } = default;
        public IActionResult OnGet(int id)
        {
            Employee =_employeeRepository.GetById(id);

            if(Employee == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }
    }
}
