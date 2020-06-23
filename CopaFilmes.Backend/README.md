# Campeonato de Filmes - Backend

REST API responsável pela lógica de negócio da determinação de filmes vencedores enviados do front-end.

## Ferramentas utilizadas
- .NET Core 3.1
- ASP.NET Core 3.1
- C# 8.0

## Componentes
- `Controllers`: Recepção de requisições vindas dos front-end;
- `Models`: Lógica de negócio;
- `Repositories`: Persistência dos dados em cache de Memória RAM;
- `Services`: Coordenação de lógica de negócio, persistência de dados e comunicação com a API de fonte de dados.

## Fluxo da aplicação
1. A aplicação é acionada a partir de requisições HTTP em seus `Controllers`;
2. Visando separação de responsabilidades, o `Service` correspondente é chamado;
3. Caso algum seja necessário lidar com persistência, o `Repository` é acionado. `Models` são invocados para execução da lógica de negócio;
4. Dados são devolvidos para o `Controller` no formato de uma resposta HTTP.

## Estrutura da lógica de negócio
1. Um `Championship` é gerado, recebendo em seu construtor todas as fases necessárias;
2. Cada fase é representada por uma classe que herda de `Phase` com um número máximo de participantes. Nela, são arranjadas instâncias de `Film` para que as disputas ocorram na ordem desejada;
3. Cada disputa entre dois filmes é realizada por uma instância de `Competition`. O critério de seleção é primariamente a nota do filme. No caso de notas idênticas, o nome é usado como critério de desempate;
4. Realizadas as competições, a `Phase` retorna os filmes vencedores para a próxima etapa do `Championship`.

## Fases do campeonato
São três fases, que ocorrem na seguinte ordem: `InitialPhase`, `EliminatoryPhase` e `FinalPhase`. Cada uma devolve um `IEnumerable<Film>` com os filmes vencedores.<br>
É possível gerar novas fases com facilidade, bastando criar uma classe que herde de `Phase` e injetá-las no método construtor de `Championship`.

## Setup
1. Instale o .NET Core 3.1;
2. Restaure as dependências do NuGet instaladas em `CopaFilmes.Backend` com os comandos `dotnet restore` e `dotnet build`.
3. O back-end funciona em HTTPS e o certificado digital é auto-assinado, sendo necessário acessar `http://localhost:5001` e aceitá-lo.

## Execução
Entre no diretório de `CopaFilmes.Backend` e execute a aplicação emitindo `dotnet run`. A aplicação pode ser acessada em `https://localhost:5001`.