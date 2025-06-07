namespace PedidosApp.Domain.Entities
{
    public class Pedido
    {
        public required Guid Id { get; set; }
        public required string Solicitante { get; set; }
        public required DateTime DataHora { get; set; }
        public required decimal Valor { get; set; }
        public required string Detalhes { get; set; }
        public required Status Status { get; set; }
        public required bool Ativo { get; set; }
    }

    public enum Status
    {
        Pendente = 1,
        Aprovado = 2,
        Rejeitado = 3
    }
}
