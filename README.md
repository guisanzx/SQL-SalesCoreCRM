# SalesCoreCRM — API de leitura com C# e SQL Server

Projeto didático baseado no PDF da aula. A API consulta as tabelas já existentes `dbo.tbEmpresa`, `dbo.tbContato`, `dbo.tbOportunidade` e `dbo.tbUsuario`.

## Requisitos
- .NET 8 SDK
- SQL Server instalado e em execução
- Banco `SalesCoreCRM` já criado com as quatro tabelas
- Visual Studio 2022 com ASP.NET e desenvolvimento Web, ou VS Code com extensão C# Dev Kit

## Antes de executar
1. Abra `SalesCoreCRM.sln`.
2. Confirme no SQL Server Management Studio que o banco `SalesCoreCRM` existe.
3. Abra `SalesCore.API/appsettings.Development.json` e ajuste `Server=localhost` para o nome de servidor usado no SSMS. Para SQL Express, normalmente será `Server=localhost\SQLEXPRESS`.
4. O exemplo usa autenticação integrada do Windows (`Integrated Security=True`). O usuário do Windows que executa a API precisa ter acesso ao banco.

## Executar
No terminal, na pasta que contém `SalesCoreCRM.sln`:

```bash
dotnet restore
dotnet build
dotnet run --project SalesCore.API
```

Abra `http://localhost:5202/swagger` (ou a URL HTTPS mostrada no terminal) e execute os quatro GETs.

## Rotas
- `GET /api/empresas`
- `GET /api/contatos`
- `GET /api/oportunidades`
- `GET /api/usuarios`

Uma resposta `200` com `[]` significa que a consulta funcionou, mas não encontrou registros. Esta entrega não implementa criação, alteração, exclusão, filtros ou paginação.

## Observação importante
O PDF não informa todos os tipos e tamanhos das colunas de `tbEmpresa`. O mapeamento de `razaoSocial`, `nomeFantasia` e `email` usa `varchar(100)` como configuração inicial plausível; se o esquema real tiver outros tipos/tamanhos, confira a tabela no SSMS e ajuste o `OnModelCreating` antes da demonstração. Não foram incluídas migrations nem comandos para alterar o banco.
