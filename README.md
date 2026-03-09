# TaskHub API JWT

API REST para gerenciamento de tarefas com autenticação JWT, construída em ASP.NET Core para estudo prático de backend e melhores práticas, princípios SOLID, design patterns, clean architecture e clean code.

Status do projeto: `em desenvolvimento (base de modelagem e banco concluída)`

## Objetivo

Implementar uma API com:

- Registro e login de usuários com JWT
- Controle de acesso por usuário autenticado
- CRUD de tarefas por usuário
- Separação por camadas para facilitar manutenção e testes

## Stack atual

- ASP.NET Core Web API (.NET 9)
- Entity Framework Core
- SQLite

## Stack planejada

- JWT Bearer Authentication
- BCrypt (hash de senha)
- Swagger/OpenAPI
- xUnit (planejado para testes)

## Arquitetura (proposta)

Fluxo de chamadas:

`Controller -> Facade -> Service -> Repository -> DbContext`

Pastas principais:

- `Controllers/`: entrada HTTP e retorno de status code
- `Facades/`: orquestra casos de uso para controller
- `Services/`: regras de negócio
- `Repositories/`: acesso a dados
- `DTOs/`: contratos de request/response
- `Models/`: entidades de domínio
- `Data/`: `AppDbContext`

## Endpoints esperados

Auth:

- `POST /auth/register`
- `POST /auth/login`
- `GET /auth/me` (protegido)

Tasks:

- `GET /tasks`
- `POST /tasks`
- `PUT /tasks/{id}`
- `DELETE /tasks/{id}`

## Decisões técnicas

- Uso de DTOs para não expor entidades diretamente
- Senha armazenada apenas como hash (BCrypt)
- Regras de autorização no fluxo de tarefas por `UserId`
- Dependência por interfaces para facilitar testes e troca de implementação
- Camada de Facade para desacoplar controller de regras de orquestração

## Como rodar localmente

Pré-requisito para comandos de migration:

```bash
dotnet tool install --global dotnet-ef
```

1. Restaurar pacotes:

```bash
dotnet restore
```

2. Aplicar migrações:

```bash
dotnet ef database update
```

3. Executar a API:

```bash
dotnet run
```

4. Abrir Swagger:

`https://localhost:<porta>/swagger`

## Como validar migration e schema

1. Compilar o projeto:

```bash
dotnet build
```

2. Aplicar migrações:

```bash
dotnet ef database update
```

3. Listar migrações aplicadas:

```bash
dotnet ef migrations list
```

4. Gerar script SQL da migration:

```bash
dotnet ef migrations script -o .\sql\latest.sql
```

## Roadmap

- [x] Base da API e `DbContext`
- [x] Entidades iniciais (`User`, `TaskItem`)
- [x] Refino de modelagem e constraints de banco
- [x] Migration de evolução do schema
- [ ] DTOs de autenticação e tarefas
- [ ] Implementações de `Repositories`
- [ ] Implementações de `Services`
- [ ] Implementações de `Facades`
- [ ] Controllers (`AuthController`, `TasksController`)
- [ ] Configuração JWT + Swagger com Bearer
- [ ] Projeto de testes com xUnit

## Aprendizados esperados

- Boas práticas de API REST em .NET
- Organização por camadas em backend
- Segurança com autenticação e autorização
- Escrita de testes de unidade e integração

## English Summary

TaskHub API is a .NET Web API study project focused on JWT authentication, task management, layered architecture, and backend best practices for mid-level engineering interviews.