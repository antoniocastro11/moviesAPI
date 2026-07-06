# MoviesAPI

API REST desenvolvida em **ASP.NET Core** para gerenciamento de cinemas, filmes, sessões e endereços;

O projeto segue uma arquitetura organizada utilizando DTOs, AutoMapper e Entity Framework Core, oferecendo uma base sólida para aplicações back-end em .NET

---

## Tecnologias Utilizadas

- C#
- ASP.NET Core
- Entity Framework Core
- MySQL
- AutoMapper

---

## Como executar

```bash
git clone https://github.com/antoniocastro11/moviesAPI.git

cd moviesAPI/moviesApi

dotnet restore

dotnet ef database update

dotnet run
```
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

A API disponibiliza operações CRUD para as seguintes entidades:

- Filmes
- Cinemas
- Sessões
- Endereços

Cada recurso possui endpoints para:

- Criar registros
- Consultar registros
- Atualizar informações
- Remover registros

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

 ---

## Possíveis melhorias

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
