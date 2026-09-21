using EImza.Domain.Abstractions;
namespace EImza.Domain.Entities;
public sealed class KeyPair : Entity
{
    public Guid OwnerId { get; set; }
    public string KeyType { get; set; } = "RSA";
    public string PublicKey { get; set; } = string.Empty;
    public string? EncryptedPrivateKey { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public AppUser? OwnerUser { get; set; }
}
