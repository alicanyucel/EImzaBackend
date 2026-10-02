# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY EImza.slnx .
COPY EImza/EImza.Domain/EImza.Domain.csproj EImza/EImza.Domain/
COPY EImza/EImza.Application/EImza.Application.csproj EImza/EImza.Application/
COPY EImza/EImza.Infrastructure/EImza.Infrastructure.csproj EImza/EImza.Infrastructure/
COPY EImza/EImza.WebAPI/EImza.WebAPI.csproj EImza/EImza.WebAPI/

# Restore dependencies
RUN dotnet restore

# Copy all source code
COPY . .

# Build
RUN dotnet build -c Release --no-restore

# Publish
RUN dotnet publish EImza/EImza.WebAPI/EImza.WebAPI.csproj -c Release -o /app/publish --no-build

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published files
COPY --from=build /app/publish .

# Create non-root user
RUN adduser --disabled-password --gecos '' appuser && chown -R appuser /app
USER appuser

# Expose port
EXPOSE 8080

# Set environment variables
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

# Run
ENTRYPOINT ["dotnet", "EImza.WebAPI.dll"]
