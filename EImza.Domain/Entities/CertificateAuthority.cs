using EImza.Domain.Abstractions;

namespace EImza.Domain.Entities;

public sealed class CertificateAuthority : Entity
{
    public string Name { get; set; } = string.Empty;
    public string? Url { get; set; }
    public bool IsTrusted { get; set; } = false;

    // Navigation
    public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
}
