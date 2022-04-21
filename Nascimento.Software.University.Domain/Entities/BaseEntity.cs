using Flunt.Notifications;

namespace Nascimento.Software.University.Domain.Entities;

public class BaseEntity : Notifiable<Notification>
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}