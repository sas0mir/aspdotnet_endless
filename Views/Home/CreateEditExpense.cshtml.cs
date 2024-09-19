using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspdonet_endless.Views.Home
{
    public class CreateEditExpense : PageModel
    {
        private readonly ILogger<CreateEditExpense> _logger;

        public CreateEditExpense(ILogger<CreateEditExpense> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}