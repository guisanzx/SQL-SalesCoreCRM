# SalesCoreCRM — API de leitura com C# e SQL Server

Projeto desenvolvido para praticar a criação de APIs utilizando C#, ASP.NET Core e SQL Server, com foco na consulta de dados de um sistema de CRM.

A API utiliza as tabelas já existentes no banco de dados `SalesCoreCRM`, permitindo consultar informações de empresas, contatos, oportunidades e usuários.

## Tecnologias utilizadas

- Visual Studio 2022 (criação da api)
- C# (api) 
- ASP.NET Core Web API (api)
- sql server management studio 22 (banco de dados)
- Swagger / OpenAPI (visualizador) 


## Funcionalidades

A API foi desenvolvida para realizar **consultas** aos dados cadastrados no banco de dados. **Não é possível alterar os dados.**

- **Empresas:** consulta das empresas cadastradas.
- **Contatos:** consulta dos contatos registrados.
- **Oportunidades:** consulta das oportunidades comerciais.
- **Usuários:** consulta dos usuários cadastrados no sistema.
- **Swagger:** documentação e testes dos endpoints diretamente pelo navegador.

## Banco de dados

O projeto utiliza o banco de dados `SalesCoreCRM`, com as seguintes tabelas:

- `dbo.tbEmpresa`
- `dbo.tbContato`
- `dbo.tbOportunidade`
- `dbo.tbUsuario`

## Como executar o projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/guisanzx/SalesCreCRM.git
   ```

2. Abra a solução no Visual Studio.

3. Configure a conexão com o SQL Server de acordo com o ambiente utilizado.

4. Verifique se o banco `SalesCoreCRM` está disponível e se as tabelas necessárias existem.

5. Execute o projeto pelo Visual Studio.

6. Acesse o Swagger para visualizar e testar os endpoints disponíveis.

## Objetivo do projeto

O objetivo é colocar em prática os conhecimentos de C#, APIs REST e SQL Server, entendendo como uma aplicação se conecta ao banco de dados e disponibiliza informações por meio de endpoints.

O projeto também serve como base para futuras melhorias, como inclusão de operações de cadastro e atualização, autenticação de usuários e integração com uma interface web.
