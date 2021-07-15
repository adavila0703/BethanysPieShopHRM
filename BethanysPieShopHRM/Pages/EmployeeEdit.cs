using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Inject]
        public ICountryDataService CountryDataService { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }

        protected string CountryId = string.Empty;

        public Employee Employee { get; set; } = new Employee();
        public List<Country> Countries { get; set; } = new List<Country>();

        protected override async Task OnInitializedAsync()
        {
            Countries = (await CountryDataService.GetAllCountries()).ToList();
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
            CountryId = Employee.CountryId.ToString();
        }
    }
}
