# Design Pattern Comportamental Observer

O padrão de observador é um padrão de projeto de software no qual um objeto, denominado assunto, 
mantém uma lista de seus dependentes, chamados observadores, 
e os notifica automaticamente sobre quaisquer mudanças de estado, geralmente chamando um de seus métodos.


1. O sujeito mantém uma lista de todos os observadores.
2. O sujeito pode inscrever/cancelar a inscrição de observadores em tempo de execução.
3. O assunto notifica todos os observadores quando seu estado muda ou algum evento ocorre
4. O sujeito e os observadores estão fracamente acoplados porque não têm conhecimento explícito um do outro.
Novos observadores podem ser implementados e usados sem modificar a implementação do assunto .

![Padrão Observer](/observer.jpg)

## Tecnologias Utilizadas

- [C#](https://dotnet.microsoft.com/download)
