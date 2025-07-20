namespace TransaccionesEF.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }  // ID único del cliente (clave primaria)
        public string Nombre { get; set; }  // Nombre del cliente
        public string Correo { get; set; }  // Correo del cliente
        public decimal Saldo { get; set; }  // Saldo disponible
    }
}
