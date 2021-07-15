using BethanysPieShopHRM.Components;
using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Pages
{
    public partial class EmployeeOverview
    {
		public IEnumerable<Employee> Employees { get; set; }

		[Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        
        protected AddEmployeeDialog AddEmployeeDialog { get; set; }
        protected async override Task OnInitializedAsync()
		{

            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
		}
        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }
	}
}
