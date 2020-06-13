# Campeonato de Filmes - Backend

REST API responsável pela lógica de negócio da determinação de filmes vencedores enviados do front-end.

## Ferramentas utilizadas
- Angular 9
- TypeScript 3.8

## Componentes
Todos os componentes da aplicação estão dentro de `/src/app` e dispostos da seguinte forma:
- `components`: Elementos de interface gráfica reaproveitáveis;
- `models`: Lógica de negócio;
- `pages`: Composição de componentes para geração de páginas navegáveis;
- `services`: Interação com o back-end através de mensagens HTTP.

## Fluxo da aplicação
1. A página de `films-selection` é exibida para que sejam selecionados os filmes desejados para o campeonato;
2. Ao clicar em <b>Gerar meu campeonato</b>, os filmes selecionados são enviados ao back-end e o campeonato é iniciado;
3. É exibida a página de `championship-result` com os filmes vencedores obtidos do back-end.

## Particularidades
Dado que não há persistência definitiva de dados, os dados de cada campeonato são armazenados por uma hora no cache do back-end. Portanto, a navegação deve sempre iniciar de `films-selection`, que é a home page do projeto. Do contrário, a tela de resultados exibirá uma mensagem de que ainda não há vencedores definidos.

## Setup
1. Instale o Node 12 ou superior;
2. Restaure as dependências do NPM instaladas em `CopaFilmes.Frontend` com o comando `npm install`.

## Execução
Entre no diretório de `CopaFilmes.Frontend` e execute a aplicação emitindo `ng serve`.