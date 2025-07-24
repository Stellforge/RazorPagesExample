using RazorPagesExample.Models;

namespace RazorPagesExample.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
{
    new Employee
    {
        Id = 1,
        Name = "Ahmet Yılmaz",
        Email = "ahmetyilmaz@gmail.com",
        Photo = "1.jpg",
        Department = "Muhasebe"
    },
    new Employee
    {
        Id = 2,
        Name = "Ayşe Demir",
        Email = "ayse.demir@example.com",
        Photo = "2.jpg",
        Department = "İK"
    },
    new Employee
    {
        Id = 3,
        Name = "Mehmet Kaya",
        Email = "mehmet.kaya@example.com",
        Photo = "3.jpg",
        Department = "Bilişim"
    },
    new Employee
    {
        Id = 4,
        Name = "Zeynep Şahin",
        Email = "zeynepsahin@example.com",
        Photo = "4.jpg",
        Department = "Satın Alma"
    },
    new Employee
    {
        Id = 5,
        Name = "Emre Koç",
        Email = "emre.koc@example.com",
        Photo = "5.jpg",
        Department = "Pazarlama"
    }
};


        }
        public IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }

        public Employee GetById(int id)
        {
            return _employeeList.FirstOrDefault(i => i.Id == id);
        }

        public Employee Update(Employee entity)
        {
            Employee employee = _employeeList.FirstOrDefault(i => i.Id == entity.Id);

            if (employee != null)
            {
                employee.Name = entity.Name;
                employee.Email = entity.Email;
                employee.Department = entity.Department;
                employee.Photo = entity.Photo;
            }

            return employee;
        }
    }
}

