using TransaccionesEF.Controladores;

namespace TransaccionesEF.Servicios
{
    public class MenuService
    {
        public async Task MostrarMenu()
        {
            while (true)
            {
                try
                {
                    if (!Console.IsInputRedirected)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No se puede limpiar la consola en este entorno.");
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("No se puede limpiar la consola en este entorno.");
                }

                Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Transferir saldo");
                Console.WriteLine("3. Eliminar cliente");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        await RegistrarCliente();
                        break;

                    case "2":
                        await TransferirSaldo();
                        break;

                    case "3":
                        await EliminarCliente();
                        break;

                    case "0":
                        Console.WriteLine("Saliendo...");
                        return;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }

        private async Task RegistrarCliente()
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el correo del cliente: ");
            string correo = Console.ReadLine();

            Console.Write("Ingrese el saldo inicial: ");
            decimal saldo;

            while (!decimal.TryParse(Console.ReadLine(), out saldo))
            {
                Console.WriteLine("❌ El saldo debe ser un número válido. Intente de nuevo.");
                Console.Write("Ingrese el saldo inicial: ");
            }

            var clienteController = new ClienteController();
            await clienteController.RegistrarCliente(nombre, correo, saldo);
        }

        private async Task TransferirSaldo()
        {
            Console.Write("Ingrese el nombre del cliente que realiza la transferencia: ");
            string nombreOrigen = Console.ReadLine();

            Console.Write("Ingrese el nombre del cliente receptor: ");
            string nombreDestino = Console.ReadLine();

            Console.Write("Ingrese el monto a transferir: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            var clienteController = new ClienteController();
            await clienteController.TransferirSaldo(nombreOrigen, nombreDestino, monto);
        }

        private async Task EliminarCliente()
        {
            Console.Write("Ingrese el nombre del cliente a eliminar: ");
            string nombre = Console.ReadLine();

            var clienteController = new ClienteController();
            await clienteController.EliminarCliente(nombre);
        }
    }
}
