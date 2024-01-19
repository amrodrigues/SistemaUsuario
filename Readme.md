# Projeto Sistema Usuario

## Descrição
Este projeto implementa uma aplicação utilizando a arquitetura MVC. O sistema gerencia usuários e informações de pessoas.

## Estrutura MVC
A estrutura do projeto segue o padrão MVC (Model-View-Controller). Os diretórios estão organizados da seguinte forma:
- `Models`: Contém as classes de modelo, como `Usuario` e `Pessoa`.
- `Views`: Contém as views da aplicação.
- `Controllers`: Contém os controladores, como `UsuarioController` e `PessoaController`.
- `Migrations`: Armazena as migrações do Entity Framework para controlar as alterações no banco de dados.

## Entity Framework e Migração
O Entity Framework é utilizado como ORM (Object-Relational Mapper) para interagir com o banco de dados. As migrações são utilizadas para controlar as alterações no esquema do banco de dados.

Para criar e aplicar as migrações, execute os seguintes comandos no Console do Gerenciador de Pacotes:
```sh
PM> Add-Migration NomeDaMigracao
PM> Update-Database
Injeção de Dependência
A injeção de dependência é utilizada para promover a modularidade e a testabilidade do código. As dependências necessárias são injetadas nos construtores dos controladores.

Bootstrap e Angular
O Bootstrap é utilizado para estilizar a interface da aplicação, proporcionando uma experiência visual moderna e responsiva. Angular é utilizado para criar interações dinâmicas nas views.

Controller de Usuário
O controlador de usuário (UsuarioController) foi implementado, gerenciando operações relacionadas aos usuários.

Controller de Pessoa (Em Progresso)
O controlador de pessoa (PessoaController) está em progresso e será implementado para gerenciar as operações relacionadas às informações de pessoas.

Como Executar
Clone o repositório.
Abra o projeto na sua IDE favorita.
Configure a string de conexão do banco de dados no arquivo appsettings.json.
Execute as migrações.
Execute a aplicação.
Certifique-se de ter as dependências instaladas usando o NuGet Package Manager.