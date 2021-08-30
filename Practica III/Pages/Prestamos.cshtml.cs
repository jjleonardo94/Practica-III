using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Practica_III.Pages
{
    public class PrestamosModel : PageModel
    {
        public double Prestamo { get; set; }
        
        public void OnGet(double data_prestamos, int data_tasa, double data_cuotas)
        {
            //this.Prestamo = data_prestamos * (Math.Pow((1 + data_tasa), data_cuotas)) / ((Math.Pow((1 + data_tasa), (data_cuotas))) - 1);

            this.Prestamo = data_prestamos * (1 + (((data_cuotas / 12) * data_tasa) / 100)) / (data_cuotas);

        }

    }
}
