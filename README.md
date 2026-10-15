# SalesCoreCRM — API de leitura com C# e SQL Server

Projeto desenvolvido para praticar a criação de APIs utilizando C#, ASP.NET Core e SQL Server, com foco na consulta de dados de um sistema de CRM.

A API utiliza as tabelas já existentes no banco de dados `SalesCoreCRM`, permitindo consultar informações de empresas, contatos, oportunidades e usuários.

## Tecnologias utilizadas

- vs2022 (criação da api)
- C# (api) 
- ASP.NET Core Web API (api)
- ssms 22 (banco de dados)
- swagger / openapi (visualizador) 

## Funcionalidades

A API foi desenvolvida para realizar **consultas** aos dados cadastrados no banco de dados. **Não é possível alterar os dados.**

- **Empresas:** consulta das empresas cadastradas.
- **Contatos:** consulta dos contatos registrados.
- **Oportunidades:** consulta das oportunidades comerciais.
- **Usuários:** consulta dos usuários cadastrados no sistema.
- **Swagger:** documentação e testes dos endpoints diretamente pelo navegador.

## Como executar o projeto

**banco de dados** 
https://www.mediafire.com/file/yx9hencfazg83r6/SalesCoreCRM.bak/file 
1. Clone o repositório:
   ```bash
   git clone https://github.com/guisanzx/SalesCreCRM.git
   ```
2. Abra o projeto no Visual Studio.
3. Configure a conexão com o SQL Server.
4. Execute a API e acesse o Swagger para testar os endpoints.

## Objetivo do projeto

Projeto da faculdade. 
