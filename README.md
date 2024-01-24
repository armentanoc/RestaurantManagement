# Restaurant Management

**Este é um projeto desenvolvido como exercício final do módulo de Programação Orientada a Objetos I do curso de Backend C# do programa DiverseDev.**

## 🔭 Table of Contents

- [Participantes](#-participantes)
- [Descrição do projeto](#-descrição-do-projeto)
- [Fluxo aplicado](#-fluxo-aplicado)
- [Tópicos aplicados](#-tópicos-aplicados)
<br>

## 🌱 Participantes

Este projeto foi desenvolvido pelo grupo 3 que é composto por:
 - [Ana Carolina Armentano](https://github.com/armentanoc)
 - [Daisy Reis](https://github.com/DaisyCR)
 - [Igor Nunes](https://github.com/ig-nunes)
 - [Jonas Leite](https://github.com/little-junior)
 - [Paula Marinho](https://github.com/paulaandrezza)
 - [Vitória de Lira Tenório](https://github.com/vitorialira92)

## 📫 Descrição do projeto

O tema do projeto consistem em "sistema de gestão de restaurante". O restaurante em questão possui dois tipos de funcionários: garçom e gerente. Todo funcionário pode alocar cliente em mesa, receber um pedido e modificar um pedido. No entanto, somente um gerente pode processar pagamentos. Cada mesa está alocada em uma das áreas do restaurante: área externa ou interna e ela pode ser movida entre áreas. Cada mesa possui pelo menos um pedido associado a ela (que precisa conter um pagamento, que pode ser crédito, débito, dinheiro, VR ou VA), que contém produtos e suas quantidades. Há dois tipos de produtos: bebidas e pratos (que podem ser entrada, prato principal ou sobremesa). Todo o cardápio com todas as bebidas e todos os pratos está disponível para todos os usuários do sistema, sem precisar fazer login. As outras opções, no entanto, precisam de login.

## ⚡ Fluxo aplicado

Dividimos o código em duas partes, além da interação com o console: serviços e modelos. O folder de modelo contém a modelagem de todas as entidades do nosso projeto: Mesa, Pagamento, Pedido, Produto, Prato, Bebida, ItemPedido, Funcionario, Gerente e Garçom. O folder de serviço contém 5 repositórios que armazenam os dados sobre as entidades e fazem alterações nesses dados: Cardapio, que manipula todos os tipos de produtos, funcionário, que manipula todos os tipos de funcionários, mesa, que manipula as mesas, pagamento que manipula os pagamentos e pedido, que manipula os pedidos.

As seguintes funcionalidades foram implementadas:

 ```markdown
---------FUNCIONÁRIOS-----------

FAZER LOGIN

ALOCAR CLIENTE EM MESA

RECEBER UM PEDIDO

ARMAZENAR PEDIDO

ADICIONAR PRATO OU BEBIDA EM UM PEDIDO

---------GERENTE (QUE TAMBÉM É FUNCIONÁRIO)-----------

FECHAR CONTA

PROCESSAR PAGAMENTO

---------MESA-----------

MUDAR MESA PARA ÁREA EXTERNA

INICIAR NOVO PEDIDO

ATUALIZAR PEDIDO ATUAL DA MESA

OCUPAR MESA

LIBERAR MESA

---------PRODUTO-----------

ATUALIZAR DESCRIÇÃO E PREÇO


---------PRATO (QUE TAMBÉM É PRODUTO)-----------

ALTERAR QUANTIDADES DE GRAMAS

---------ITEM PEDIDO-----------

ADICIONAR MAIS DE UM PRODUTO


---------PAGAMENTO-----------

SELECIONAR O TIPO DE PAGAMENTO

CONFIRMAR PAGAMENTO

```

## 🍸 Tópicos aplicados

Tópicos vistos no módulo que foram aplicados neste projeto:
- Orientação a objetos
- Abstração
- Encapsulamento
- Herança
- Polimorfismo
- Propriedades e atributos
- Git

## 📹 Demo Video
https://github.com/armentanoc/RestaurantManagement/assets/88147887/7a5dae32-0dc9-42de-8c4a-3cafaaaf80f6
