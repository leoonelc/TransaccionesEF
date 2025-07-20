using Microsoft.EntityFrameworkCore;
using TransaccionesEF.Data;
using TransaccionesEF.Modelos;
using System;
using System.Threading.Tasks;

namespace TransaccionesEF.Controladores
{
    public class ClienteController
    {
        private ApplicationDbContext CrearContexto()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql(
                "server=localhost;database=TransaccionesEF;user=root;password=;",
                new MySqlServerVersion(new Version(10, 4, 32))
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }

        // Registrar un nuevo cliente
        public async Task RegistrarCliente(string nombre, string correo, decimal saldoInicial)
        {
            if (saldoInicial < 0)
            {
                Console.WriteLine("❌ El saldo inicial no puede ser negativo.");
                Console.ReadKey();
                return;
            }

            using var context = CrearContexto();

            try
            {
                // Verifica si el nombre ya existe
                var existe = await context.Clientes.AnyAsync(c => c.Nombre == nombre);
                if (existe)
                {
                    Console.WriteLine("⚠️ Ya existe un cliente con ese nombre.");
                    Console.ReadKey();
                    return;
                }

                var cliente = new Cliente
                {
                    Nombre = nombre,
                    Correo = correo,
                    Saldo = saldoInicial
                };

                await context.Clientes.AddAsync(cliente);
                await context.SaveChangesAsync();

                Console.WriteLine("✅ Cliente registrado exitosamente.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al registrar cliente: {ex.Message}");
                Console.ReadKey();
            }
        }

        // Transferir saldo entre clientes (por nombre)
        public async Task TransferirSaldo(string nombreOrigen, string nombreDestino, decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("❌ El monto debe ser mayor que cero.");
                Console.ReadKey();
                return;
            }

            using var context = CrearContexto();
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                var origen = await context.Clientes.FirstOrDefaultAsync(c => c.Nombre == nombreOrigen);
                var destino = await context.Clientes.FirstOrDefaultAsync(c => c.Nombre == nombreDestino);

                if (origen == null || destino == null)
                {
                    Console.WriteLine("❌ Uno o ambos clientes no existen.");
                    Console.ReadKey();
                    return;
                }

                if (origen.Saldo < monto)
                {
                    Console.WriteLine("❌ Saldo insuficiente en el cliente origen.");
                    Console.ReadKey();
                    return;
                }

                origen.Saldo -= monto;
                destino.Saldo += monto;

                await context.SaveChangesAsync();
                await transaction.CommitAsync();

                Console.WriteLine($"✅ Transferencia de {monto:C} realizada con éxito.");
                Console.WriteLine($"Saldo actualizado del cliente origen: {origen.Saldo:C}");
                Console.WriteLine($"Saldo actualizado del cliente destino: {destino.Saldo:C}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine($"❌ Error en la transferencia: {ex.Message}");
                Console.ReadKey();
            }
        }

        // Eliminar cliente si su saldo es 0 (por nombre)
        public async Task EliminarCliente(string nombre)
        {
            using var context = CrearContexto();
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                var cliente = await context.Clientes.FirstOrDefaultAsync(c => c.Nombre == nombre);

                if (cliente == null)
                {
                    Console.WriteLine("❌ Cliente no encontrado.");
                    Console.ReadKey();
                    return;
                }

                if (cliente.Saldo != 0)
                {
                    Console.WriteLine("⚠️ El cliente tiene un saldo pendiente. No se puede eliminar.");
                    Console.ReadKey();
                    return;
                }

                context.Clientes.Remove(cliente);
                await context.SaveChangesAsync();
                await transaction.CommitAsync();

                Console.WriteLine("✅ Cliente eliminado correctamente.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine($"❌ Error al eliminar cliente: {ex.Message}");
                Console.ReadKey();
            }
        }

        // Mostrar todos los clientes (útil para probar)
        public async Task ListarClientes()
        {
            using var context = CrearContexto();

            var clientes = await context.Clientes.ToListAsync();

            Console.WriteLine("📋 Lista de Clientes:");
            foreach (var c in clientes)
            {
                Console.WriteLine($"ID: {c.Id}, Nombre: {c.Nombre}, Correo: {c.Correo}, Saldo: {c.Saldo:C}");
            }
            Console.ReadKey();
        }
    }
}
