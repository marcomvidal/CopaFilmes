# Campeonato de Filmes

Aplicação com Web API, Front-End e testes para seleção e comparação de filmes no formato de campeonato.

## Ferramentas utilizadas
- .NET Core 3.1
- ASP.NET Core 3.1
- C# 8.0
- Xunit 2.4
- Selenium 3.141
- Angular 9
- TypeScript 3.8

## Componentes
A aplicação está divida é em três partes essenciais:
- `CopaFilmes.Backend`: REST API em ASP.NET Web API para processamento da lógica de negócio;
- `CopaFilmes.Frontend`: Single Page Application em Angular para seleção e exibição dos filmes vencedores;
- `CopaFilmes.Test`: Testes unitários e funcionais aplicáveis às aplicações desenvolvidas.
Mais detalhes de arquitetura a partir do README do diretório de cada um dos projetos.

## Setup
1. Instale o .NET Core 3.1;
2. Instale o Node 12 ou superior;
3. Restaure as dependências do NuGet instaladas em `CopaFilmes.Backend` e `CopaFilmes.Test` com os comandos `dotnet restore` e `dotnet build`;
4. Restaure as dependências do NPM instaladas em `CopaFilmes.Frontend` com o comando `npm install`.

## Execução
1. Entre no diretório de `CopaFilmes.Backend` e execute a aplicação emitindo `dotnet run`;
2. Entre no diretório de `CopaFilmes.Frontend` e execute a aplicação emitindo `ng serve`.

## Execução dos testes
Entre no diretório de `CopaFilmes.Test` e execute a bateria de testes com o comando `dotnet run`.

## Objetos de estudos
- Orientação a objetos
- Programação funcional
- Injeção de dependências
- C# e ASP.NET Core
- TypeScript e Angular
- Testes de software
- Integração e desenvolvimento de API REST