# Os Princípios SOLID

![GitHub visitors](https://api.visitorbadge.io/api/visitors?path=https%3A%2F%2Fgithub.com%2Fcaiomeletti%2Fsolid-principles&countColor=%23263759&style=plastic)
![GitHub repo size](https://img.shields.io/github/repo-size/caiomeletti/solid-principles)
![GitHub language count](https://img.shields.io/github/languages/count/caiomeletti/solid-principles)
![GitHub forks](https://img.shields.io/github/forks/caiomeletti/solid-principles)
![Bitbucket open issues](https://img.shields.io/bitbucket/issues/caiomeletti/solid-principles)
![Bitbucket open pull requests](https://img.shields.io/bitbucket/pr-raw/caiomeletti/solid-principles)

Na programação de computadores orientada a objetos, o termo **SOLID** é um acrônimo para cinco postulados de design, destinados a facilitar a compreensão, o desenvolvimento e a manutenção de software.


    [S] Single-responsiblity principle 
    [O] Open-closed principle 
    [L] Liskov substitution principle
    [I] Interface segregation principle 
    [D] Dependency Inversion Principle 

> **Neste repositório encontraremos implementações de código para exemplificar os princípios SOLID.**

## Origem dos princípios SOLID

O primeiro indício dos princípios SOLID apareceu em 1995, no artigo *“The principles of OoD”* de [Robert C. Martin](https://en.wikipedia.org/wiki/Robert_C._Martin), também conhecido como *"Uncle Bob"*.

Em 2002, lançou o livro *"Agile Software Development, Principles, Patterns, and Practices"* que reúne diversos artigos sobre o tema.

A sigla SOLID só foi apresentada mais tarde, por Michael Feathers.


## Single-responsiblity principle ❄️
### Princípio da responsabilidade única

> Cada módulo ou classe deve ter responsabilidade sobre uma única parte da funcionalidade fornecida pelo software.

No artigo, Robert C. Martin define uma responsabilidade como um **"motivo para mudar"** e conclui que uma classe ou módulo deve ter um e apenas um motivo para ser alterado.


> ***Faça uma coisa e faça bem.***


Benefícios:

- Teste - Uma classe com uma responsabilidade terá muito menos casos de teste;
- Menor acoplamento - menos funcionalidade em uma única classe terá menos dependências;
- Organização - Classes menores e bem organizadas são mais fáceis de pesquisar do que as classes monolíticas.

### Exemplo de implementação
- [Book](https://github.com/caiomeletti/solid-principles/blob/main/solid-principles/principles/Srp/Book.cs)


## Open-closed principle 📖
### Princípio aberto-fechado

Na programação orientada a objeto, o princípio do aberto/fechado estabelece que:

> Entidades de software (classes, módulos, funções, etc.) devem ser abertas para extensão, mas fechadas para modificação.

Dessa forma, a entidade pode permitir que o seu comportamento seja estendido sem modificar seu código-fonte.

O nome do princípio aberto/fechado tem sido usado de duas maneiras. Ambas as maneiras usam generalizações (por exemplo, herança, ou delegação de funções) para resolver o aparente dilema, mas os objetivos, as técnicas e os resultados são diferentes.

### Exemplo de implementação

- [Post](https://github.com/caiomeletti/solid-principles/blob/main/solid-principles/principles/Ocp/Post.cs)


## Liskov substitution principle 🦆
### Princípio da substituição de Liskov

> Quem propôs o princípio de maneira formal e matemática, foi [Bárbara Liskov](https://pt.wikipedia.org/wiki/Barbara_Liskov).
>
> *Se F(x) é uma propriedade demonstrável sobre objetos x de tipo B. Então F(y) deve ser verdadeiro para objetos y de tipo A, em que A é um subtipo de B.*


No entanto, Robert Martin deu uma definição mais simples para ele: *"Classes derivadas (ou classes-filhas) devem ser capazes de substituir suas classes-base (ou classes-mães)"*.

Ou seja, uma classe-filha deve ser capaz de executar tudo que sua classe-mãe faz. Esse princípio se conecta com o polimorfismo e reforça esse pilar da POO.

### Exemplo de implementação

1. [Pessoa](https://github.com/caiomeletti/solid-principles/blob/main/solid-principles/principles/Lsp/Pessoa.cs)
2. [Student](https://github.com/caiomeletti/solid-principles/blob/main/solid-principles/principles/Lsp/Student.cs)


## Interface segregation principle 👥
### Princípio da Segregação de interface

> Nenhum cliente deve ser forçado a depender dos métodos que não usa.
> 
> Concluí-se que muitas interfaces de clientes específicas, são melhores do que uma para todos propósitos.

Portanto: interfaces maiores devem ser divididas em menores para garantir que as classes de implementação só precisam se preocupar com os métodos que são do seu interesse.

### Exemplo de implementação

1. [Post](https://github.com/caiomeletti/solid-principles/blob/main/solid-principles/principles/Isp/Post.cs)
2. [Employee](https://github.com/caiomeletti/solid-principles/blob/main/solid-principles/principles/Isp/Employee.cs)



## Dependency Inversion Principle ⏪
### Princípio da inversão de dependência

> Deve-se depender de abstrações, não de objetos concretos.
>
> Refere-se à dissociação de módulos de software. Dessa forma, em vez de módulos de alto nível, dependendo de módulos de baixo nível, ambos dependerão de abstrações.

Para cumprir esse princípio, precisamos usar um padrão de design conhecido como padrão de inversão de dependência, geralmente resolvido usando injeção de dependência.

### Exemplo de implementação

- [WindowsMachine](https://github.com/caiomeletti/solid-principles/blob/main/solid-principles/principles/Dip/WindowsMachine.cs)



## Referências
1. [Os Princípios do SOLID](https://medium.com/xp-inc/os-princ%C3%ADpios-do-solid-srp-princ%C3%ADpio-da-responsabilidade-%C3%BAnica-7897c55694fe). *Medium, Jones Roberto Nuzzi*. 08 de outubro de 2024

2. [SOLID](https://en.wikipedia.org/wiki/SOLID). *Wikipedia*. 09 de outubro de 2024

3. [SOLID: o que é e quais os 5 princípios da Programação Orientada a Objetos (POO)](https://www.alura.com.br/artigos/solid). *Alura*. 07 de outubro de 2024
