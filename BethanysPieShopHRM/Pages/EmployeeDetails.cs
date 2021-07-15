using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Pages
{
	public partial class EmployeeDetails
	{
		[Parameter]
		public string EmployeeId { get; set; }

		public Employee Employee { get; set; } = new Employee();

		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }

		protected async override Task OnInitializedAsync()
		{
			Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
		}
	}
}
