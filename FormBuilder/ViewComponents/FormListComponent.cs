using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormBuilder.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormBuilder.ViewComponents
{
    [ViewComponent(Name = "FormList")]
    public class FormListComponent : ViewComponent
    {
        private readonly FormBuilderContext _context;

        public FormListComponent(FormBuilderContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var forms = _context.Forms.ToList();
            return View(forms);
        }
    }
}
