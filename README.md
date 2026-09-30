# Validador de Bandeiras de Cartão de Crédito

Projeto desenvolvido como parte do desafio **Criando um Validador de Bandeiras de Cartão de Crédito com o GitHub Copilot**, da DIO.

## Objetivo

Criar uma aplicação simples em C# capaz de identificar a bandeira de um cartão de crédito a partir do número informado.

O projeto utiliza regras baseadas nos prefixos e no tamanho dos números normalmente associados às principais bandeiras.

## Bandeiras identificadas

- Visa
- MasterCard
- American Express
- Elo
- Hipercard

Caso o número não corresponda às regras implementadas, a aplicação retorna `Bandeira desconhecida`.

## Tecnologias utilizadas

- C#
- .NET 8
- Expressões regulares (Regex)
- Git e GitHub
- GitHub Copilot como apoio durante o desenvolvimento

## Como executar

Clone o repositório:

```bash
git clone https://github.com/MarcoOliv/dio-validador-bandeira-cartao.git
```

Entre na pasta do projeto:

```bash
cd dio-validador-bandeira-cartao
```

Execute:

```bash
dotnet run
```

Depois, informe o número do cartão quando solicitado.

Exemplo:

```text
Digite o número do cartão: 4111111111111111
Bandeira identificada: Visa
```

## Como funciona

A aplicação:

1. recebe o número digitado pelo usuário;
2. remove caracteres que não sejam números;
3. compara o número com padrões de prefixo e quantidade de dígitos;
4. retorna a bandeira correspondente.

A identificação é feita no método `IdentificarBandeira`.

## Uso do GitHub Copilot

O GitHub Copilot foi utilizado como ferramenta de apoio para acelerar a implementação, sugerir estruturas de código e auxiliar na criação das regras de identificação.

As sugestões foram analisadas e adaptadas antes de serem incorporadas ao projeto.

## Observação

Este projeto tem finalidade educacional. A identificação da bandeira é feita somente com base em padrões numéricos e não realiza validação financeira, consulta a operadoras nem processamento de pagamentos.

## Autor

Marco Capucho
