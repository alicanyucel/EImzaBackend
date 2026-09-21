using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class KeyPair : Entity
{
    public Guid OwnerId { get; set; } // AppUser or Organization id depending on usage
    public string KeyType { get; set; } = "RSA"; // RSA, ECDSA, etc.
    public string PublicKey { get; set; } = string.Empty;
    public string? EncryptedPrivateKey { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public AppUser? OwnerUser { get; set; }
}
