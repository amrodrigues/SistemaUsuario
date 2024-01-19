# Projeto Sistema Usuario

## Descri��o
Este projeto implementa uma aplica��o utilizando a arquitetura MVC. O sistema gerencia usu�rios e informa��es de pessoas.

## Estrutura MVC
A estrutura do projeto segue o padr�o MVC (Model-View-Controller). Os diret�rios est�o organizados da seguinte forma:
- `Models`: Cont�m as classes de modelo, como `Usuario` e `Pessoa`.
- `Views`: Cont�m as views da aplica��o.
- `Controllers`: Cont�m os controladores, como `UsuarioController` e `PessoaController`.
- `Migrations`: Armazena as migra��es do Entity Framework para controlar as altera��es no banco de dados.

## Entity Framework e Migra��o
O Entity Framework � utilizado como ORM (Object-Relational Mapper) para interagir com o banco de dados. As migra��es s�o utilizadas para controlar as altera��es no esquema do banco de dados.

Para criar e aplicar as migra��es, execute os seguintes comandos no Console do Gerenciador de Pacotes:
```sh
PM> Add-Migration NomeDaMigracao
PM> Update-Database
Inje��o de Depend�ncia
A inje��o de depend�ncia � utilizada para promover a modularidade e a testabilidade do c�digo. As depend�ncias necess�rias s�o injetadas nos construtores dos controladores.

Bootstrap e Angular
O Bootstrap � utilizado para estilizar a interface da aplica��o, proporcionando uma experi�ncia visual moderna e responsiva. Angular � utilizado para criar intera��es din�micas nas views.

Controller de Usu�rio
O controlador de usu�rio (UsuarioController) foi implementado, gerenciando opera��es relacionadas aos usu�rios.

Controller de Pessoa (Em Progresso)
O controlador de pessoa (PessoaController) est� em progresso e ser� implementado para gerenciar as opera��es relacionadas �s informa��es de pessoas.

Como Executar
Clone o reposit�rio.
Abra o projeto na sua IDE favorita.
Configure a string de conex�o do banco de dados no arquivo appsettings.json.
Execute as migra��es.
Execute a aplica��o.
Certifique-se de ter as depend�ncias instaladas usando o NuGet Package Manager.