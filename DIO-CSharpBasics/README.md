-----

# Sistema de Estacionamento em C\#

Bem-vindo ao repositório do projeto **Sistema de Estacionamento em C\#**\! Este projeto foi desenvolvido como parte do bootcamp da **DIO** para aprimorar os **fundamentos de programação em C\#** de forma prática e divertida.

A aplicação simula um sistema de gerenciamento de estacionamento, permitindo que o usuário interaja com um menu de console para cadastrar, remover e consultar veículos, enquanto aplica diversos conceitos importantes da linguagem.

-----

## Funcionalidades Principais

  * **Entrada de Valores:** Definição inicial do valor fixo e do valor por hora do estacionamento.
  * **Gestão de Veículos:**
      * **Cadastro de Carros:** Adiciona veículos ao sistema com validação de placa única.
      * **Consulta:** Exibe a lista de todos os carros atualmente estacionados.
      * **Remoção:** Retira um carro do estacionamento e calcula o valor a ser pago com base no tempo de permanência.
  * **Menu Interativo:** Navegação simplificada e intuitiva via console.
  * **Validação de Dados:** Evita a entrada de valores negativos ou placas duplicadas para garantir a integridade do sistema.

-----

## Tecnologias e Conceitos Aplicados

Este projeto foi uma ótima oportunidade para praticar e consolidar os seguintes conceitos de C\#:

  * **Programação Orientada a Objetos (POO):** Criação e manipulação de uma classe `Carro`.
  * **Estruturas de Dados:** Uso de `List<string>` para gerenciar os veículos estacionados.
  * **Lógica de Programação:** Aplicação de estruturas como `if-else` e `switch-case` para controle de fluxo.
  * **Loops:** Iteração de coleções usando `foreach`.
  * **Métodos e Funções:** Organização do código em métodos reutilizáveis.
  * **LINQ:** Utilização de `FirstOrDefault()` para realizar buscas eficientes na lista de carros.

-----

## Como Executar o Projeto

Siga os passos abaixo para rodar a aplicação em seu computador.

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/seu-usuario/EstacionamentoCSharp.git
    cd EstacionamentoCSharp
    ```
2.  **Abra em seu editor:**
    Abra o projeto no Visual Studio Code, Visual Studio ou sua IDE preferida.
3.  **Execute o programa:**
    Rode a aplicação e interaja com o menu do console para testar todas as funcionalidades.

### Exemplo de Uso no Console

```
Informe o Valor Fixo:
10
Digite o valor hora do estacionamento:
5

=== MENU ===
1 - Cadastrar Carro
2 - Consultar Carros
3 - Remover Carro
4 - Sair
Escolha: 1

Digite a placa do carro:
ABC1234
Carro cadastrado com sucesso!

=== MENU ===
Escolha: 3
Digite a placa do carro a ser removido:
ABC1234
Digite a quantidade de horas que o carro ficou estacionado:
3
O carro ABC1234 foi removido. Valor total: R$ 25
```

-----

## Estrutura do Projeto

```
EstacionamentoCSharp/
├── Program.cs             # Lógica principal, menu de interações e manipulação da lista.
├── Carro.cs               # Definição da classe Carro.
└── README.md              # Este arquivo, com informações sobre o projeto.
```

-----

## Desenvolvedor

  * **[wagnerdaniell]**