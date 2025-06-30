# Design Patterns (Strategy, Singleton e Adapter)
A implementação será utilizando o padrão **Strategy**, que é um dos mais didáticos e úteis para entender o conceito de encapsulamento de comportamentos. Linguagem de programação utilizada: C#.

## Padrão Strategy em C#

O padrão Strategy permite definir uma família de algoritmos, encapsulá-los e torná-los intercambiáveis. Ele permite que o algoritmo varie independentemente dos clientes que o utilizam.

### Exemplo: Sistema de Pagamento

Vamos simular um sistema onde o usuário pode escolher diferentes formas de pagamento: Cartão de Crédito, PayPal e Boleto.

### Vantagens do Strategy

- Facilita a adição de novos comportamentos sem alterar o código existente.
- Promove o princípio de **abertura/fechamento** (_Open/Closed Principle_).
- Reduz o uso de condicionais complexas.

## Padrão Singleton em C#

O padrão Singleton garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.

### Por que usar lock?
O lock garante que, em ambientes com múltiplas threads, apenas uma delas possa criar a instância. Isso evita que duas instâncias sejam criadas acidentalmente.

### Quando usar o Singleton?

- Quando você precisa de uma única instância global (ex: loggers, gerenciadores de configuração, conexões com banco).
- Quando o custo de criação de múltiplas instâncias é alto.

## Padrão Adapter em C#

O padrão Adapter permite que classes com interfaces incompatíveis trabalhem juntas, agindo como um "tradutor" entre elas.

### Exemplo: Tomada de 3 pinos e Adaptador para 2 pinos

Imagine que temos um sistema que espera uma tomada de 2 pinos, mas temos um dispositivo com plug de 3 pinos. O Adapter vai permitir que esse dispositivo funcione com a tomada esperada.

### Quando usar o Adapter?

- Quando você quer usar uma classe existente, mas sua interface não é compatível com o sistema.
- Quando você quer reutilizar código legado sem modificá-lo.
