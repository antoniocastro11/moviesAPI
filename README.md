# MoviesAPI

API REST desenvolvida em **ASP.NET Core** para gerenciamento de cinemas, filmes, sessões e endereços;

O projeto segue uma arquitetura organizada utilizando DTOs, AutoMapper e Entity Framework Core, oferecendo uma base sólida para aplicações back-end em .NET

> Este foi o meu **primeiro projeto web desenvolvido em .NET**, criado para aprender a tecnologia. É intencionalmente básico e organizado por tipos (Controllers, Models, DTOs...), não por features, mas já cumpriu seu objetivo de aprendizado.

---

## Tecnologias Utilizadas

- C# / .NET 10
- ASP.NET Core
- Entity Framework Core 10
- PostgreSQL (Npgsql)
- AutoMapper
- Scalar (documentação interativa da API via OpenAPI)

---

## Como executar

```bash
git clone https://github.com/antoniocastro11/moviesAPI.git

cd moviesAPI/moviesApi

dotnet restore

# Configure a connection string do PostgreSQL (via user-secrets)
dotnet user-secrets set "ConnectionStrings:DatabaseConnection" "Host=localhost;Database=movies;Username=postgres;Password=postgres"

dotnet ef database update

dotnet run
```

Em ambiente de desenvolvimento, a documentação interativa da API (Scalar) fica disponível em `/scalar/v1`.

---

## Árvore de pastas do projeto

```
moviesApi
├── Controllers
│   ├── AddressController.cs
│   ├── CinemaController.cs
│   ├── MovieController.cs
│   └── SessionController.cs
│
├── Data
│   ├── Dtos
│   │   ├── Address
│   │   ├── Cinema
│   │   ├── Movie
│   │   └── Session
│   └── MovieContext.cs
│
├── Models
│   ├── Address.cs
│   ├── Cinema.cs
│   ├── Movie.cs
│   └── Session.cs
│
├── Profiles
│   ├── AddressProfile.cs
│   ├── CinemaProfile.cs
│   ├── MovieProfile.cs
│   └── SessionProfile.cs
│
└── Migrations
```

---

## Funcionalidades

A API disponibiliza operações CRUD para Filmes, Cinemas e Endereços (criar, consultar, atualizar e remover registros).

Sessões possuem apenas criação e consulta (não há atualização/remoção).

---

## Arquitetura

O projeto foi organizado seguindo uma separação de responsabilidades:

- **Controllers**: Endpoints da API;
- **Models**: Entidades do banco de dados;
- **DTOs**: Objetos de transferência de dados;
- **Profiles**: Configurações do AutoMapper;
- **Data**: Contexto do Entity Framework e configuração de acesso ao banco de dados;

Essa estrutura facilita a manutenção, escalabilidade e reutilização do código.

---

## Conceitos aplicados

- API REST
- CRUD
- Entity Framework Core
- Migrations
- AutoMapper
- DTO Pattern
- Injeção de Dependência
- Separação de responsabilidades
- DRY (Don't Repeat Yourself)
- KISS (Keep It Simple, Stupid)
- YAGNI (You Aren't Gonna Need It)

## Ferramentas utilizadas durante o desenvolvimento:

- Postman
- DBeaver
- Git e GitHub
- Visual Studio & Visual Studio Code

  ***

## Dívidas técnicas - Possíveis melhorias

- Paginação
- Filtros e ordenação
- Testes unitários
- Docker
- CI/CD com GitHub Actions
- Tratamento global de exceções

---

## Autor

**Antonio Castro**

- [GitHub](https://github.com/antoniocastro11)
- [LinkedIn](https://www.linkedin.com/in/antoniocastro11/)
