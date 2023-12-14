namespace Bitacora.Services.RabbitMq
{
    public class RabbitMessage
{
    
    public DateTime Date { get; set; }

    public string Event { get; set; }
    public string Text { get; set; }
    // Añade aquí más campos según el contenido de tus mensajes RabbitMQ
}

}
