# Projeto LINQ

## Descrição

Este projeto é uma exploração profunda da biblioteca LINQ (Language Integrated Query) em C#. LINQ é uma poderosa característica do .NET Framework que fornece funcionalidades para consultar e manipular dados.

## Recursos do LINQ

LINQ tem muitos recursos úteis:

- **Consulta de dados**: LINQ permite que você consulte uma variedade de fontes de dados como coleções em memória, bancos de dados SQL e XML.

- **Sintaxe de consulta**: LINQ introduz uma sintaxe de consulta padrão para consultar fontes de dados que são coleções de objetos.

- **Tipagem estática**: As consultas LINQ são verificadas em tempo de compilação.

## Exemplos de Uso

Aqui estão alguns exemplos de como você pode usar LINQ em seu código C#:

```csharp
// Criar uma lista de inteiros
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };

// Usar LINQ para encontrar todos os números pares na lista
IEnumerable<int> pares = numeros.Where(n => n % 2 == 0);
