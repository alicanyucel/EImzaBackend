# EImza - Elektronik İmza Yönetim Sistemi

## Proje Hakkında

EImza, elektronik imza süreçlerini yönetmek için geliştirilmiş bir backend API projesidir. Clean Architecture ve CQRS pattern kullanılarak geliştirilmiştir.

## Teknolojiler

- **.NET 8** - Backend framework
- **Entity Framework Core 8** - ORM
- **SQL Server** - Veritabanı
- **MediatR** - CQRS pattern
- **FluentValidation** - Validation
- **AutoMapper** - Object mapping
- **ASP.NET Core Identity** - Authentication
- **JWT Bearer** - Token-based authentication
- **TS.Result** - Result pattern
- **GenericRepository** - Repository pattern
- **Swagger** - API documentation

## Proje Yapısı

```
EImza/
├── EImza.Domain/           # Entity'ler ve repository interface'leri
│   ├── Abstractions/       # Entity base class
│   ├── Entities/           # Domain entity'leri
│   └── Repositories/       # Repository interface'leri
├── EImza.Application/      # CQRS command/query'ler
│   ├── Features/           # Feature bazlı CQRS
│   ├── Behaviors/          # Validation behavior
│   ├── Mapping/            # AutoMapper profile
│   └── Services/           # Application service interface'leri
├── EImza.Infrastructure/   # Repository implementasyonları
│   ├── Context/            # DbContext
│   ├── Repositories/       # Repository implementasyonları
│   ├── Configurations/     # EF Core configurations
│   └── Services/           # Infrastructure servisleri
└── EImza.WebAPI/           # API Controller'ları
	├── Controllers/        # REST API endpoint'leri
	├── Abstractions/       # ApiController base
	└── Middlewares/        # Custom middleware'ler
```

## Entity'ler

| Entity | Açıklama |
|--------|----------|
| AppUser | Kullanıcı (Identity) |
| Organization | Organizasyon/Şirket |
| UserOrganization | Kullanıcı-Organizasyon ilişkisi |
| Certificate | Sertifika |
| CertificateAuthority | Sertifika otoritesi |
| CertificateRequest | Sertifika talebi |
| Document | Doküman |
| DocumentVersion | Doküman versiyonu |
| Signature | İmza |
| SignatureRequest | İmza talebi |
| SignatureTemplate | İmza şablonu |
| SigningSession | İmza oturumu |
| KeyPair | Anahtar çifti |
| ApiKey | API anahtarı |
| AuditLog | Denetim kaydı |
| TimestampToken | Zaman damgası |
| ValidationResult | Doğrulama sonucu |
| Anchor | Anchor |
| Notary | Noter |
| Permission | Yetki |
| RolePermission | Rol-Yetki ilişkisi |

## API Endpoint'leri

Tüm controller'lar `ApiController` base class'ından türer ve JWT authentication gerektirir (AuthController hariç).

### Auth
- `POST /api/Auth/Login` - Kullanıcı girişi

### Organizations
- `POST /api/Organizations/Create` - Organizasyon oluştur
- `POST /api/Organizations/Update` - Organizasyon güncelle
- `POST /api/Organizations/Delete` - Organizasyon sil
- `GET /api/Organizations/GetAll` - Tüm organizasyonları listele
- `GET /api/Organizations/GetById` - ID ile organizasyon getir

### Certificates
- `POST /api/Certificates/Create` - Sertifika oluştur
- `POST /api/Certificates/Update` - Sertifika güncelle
- `POST /api/Certificates/Delete` - Sertifika sil
- `GET /api/Certificates/GetAll` - Tüm sertifikaları listele
- `GET /api/Certificates/GetById` - ID ile sertifika getir

### Documents
- `POST /api/Documents/Create` - Doküman oluştur
- `POST /api/Documents/Update` - Doküman güncelle
- `POST /api/Documents/Delete` - Doküman sil
- `GET /api/Documents/GetAll` - Tüm dokümanları listele
- `GET /api/Documents/GetById` - ID ile doküman getir

### Signatures
- `POST /api/Signatures/Create` - İmza oluştur
- `POST /api/Signatures/Update` - İmza güncelle
- `POST /api/Signatures/Delete` - İmza sil
- `GET /api/Signatures/GetAll` - Tüm imzaları listele
- `GET /api/Signatures/GetById` - ID ile imza getir

### SignatureRequests
- `POST /api/SignatureRequests/Create` - İmza talebi oluştur
- `POST /api/SignatureRequests/Update` - İmza talebi güncelle
- `POST /api/SignatureRequests/Delete` - İmza talebi sil
- `GET /api/SignatureRequests/GetAll` - Tüm imza taleplerini listele
- `GET /api/SignatureRequests/GetById` - ID ile imza talebi getir

### CertificateAuthorities
- `POST /api/CertificateAuthorities/Create` - Sertifika otoritesi oluştur
- `POST /api/CertificateAuthorities/Update` - Sertifika otoritesi güncelle
- `POST /api/CertificateAuthorities/Delete` - Sertifika otoritesi sil
- `GET /api/CertificateAuthorities/GetAll` - Tüm sertifika otoritelerini listele
- `GET /api/CertificateAuthorities/GetById` - ID ile sertifika otoritesi getir

### Diğer Endpoint'ler
- `DocumentVersions` - Doküman versiyonları
- `SignatureTemplates` - İmza şablonları
- `SigningSessions` - İmza oturumları
- `AuditLogs` - Denetim kayıtları
- `ApiKeys` - API anahtarları
- `CertificateRequests` - Sertifika talepleri
- `TimestampTokens` - Zaman damgaları
- `ValidationResults` - Doğrulama sonuçları
- `Anchors` - Anchor'lar
- `Notaries` - Noterler
- `Permissions` - Yetkiler
- `KeyPairs` - Anahtar çiftleri

## Kurulum

### Gereksinimler
- .NET 8 SDK
- SQL Server
- Visual Studio 2022 veya VS Code

### Adımlar

1. **Projeyi klonlayın**
   ```bash
   git clone https://github.com/alicanyucel/EImzaBackend.git
   cd EImzaBackend
   ```

2. **Connection string'i ayarlayın**
   `EImza.WebAPI/appsettings.json` dosyasında `SqlServer` connection string'ini düzenleyin.

3. **Migration'ları uygulayın**
   ```bash
   cd EImza.WebAPI
   dotnet ef database update
   ```

4. **Projeyi çalıştırın**
   ```bash
   dotnet run
   ```

5. **Swagger UI'a erişin**
   ```
   https://localhost:5001/swagger
   ```

## Docker ile Çalıştırma

### Dockerfile ile
```bash
docker build -t eimza-api .
docker run -p 8080:8080 eimza-api
```

### Docker Compose ile
```bash
docker-compose up -d
```

## Varsayılan Kullanıcı

İlk çalıştırmada otomatik olarak admin kullanıcısı oluşturulur:
- **Kullanıcı adı:** admin
- **Email:** admin@admin.com
- **Şifre:** 1

## Lisans

Bu proje MIT lisansı ile lisanslanmıştır.
