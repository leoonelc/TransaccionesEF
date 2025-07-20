using TransaccionesEF.Servicios;
using System;
using System.Threading.Tasks;

namespace TransaccionesEF
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var menuService = new MenuService();
            await menuService.MostrarMenu();
        }
    }
}
