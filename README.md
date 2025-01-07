# Jogo de Plataforma 2D com Unity e C#

![Inicio do jogo](https://i.imgur.com/5ABRNCK.jpeg)

Este repositório contém um jogo de plataforma 2D desenvolvido com Unity e C#. O projeto apresenta uma jogabilidade envolvente e mecânicas como pulo duplo, inimigos com IA básica, e efeitos visuais com parallax. São 6 fases no total, com diferentes desafios e ambientes.

## Recursos

- Movimentação do jogador: Andar para frente e para trás, Pulo duplo com restrição de uso e Animações fluídas integradas à jogabilidade.
- Inimigos: IA básica com patrulha e colisão, Reações diferentes ao ser atingido pelo jogador ou ao derrotar o jogador.
- Efeitos Visuais: Parallax para um fundo dinâmico que acompanha o movimento do jogador.
- Sistema de Pontuação: Contador de pontos exibido em tempo real, Sistema de game over com reinício da fase.

## Tecnologias Utilizadas

- **Unity 6**: Software para criação de Jogos.
- **C#**: Linguagem para estruturação e funções no jogo.

  
## Estrutura de Scripts

- Player Controller: Gerencia a movimentação e as ações do jogador, incluindo Movimentação horizontal, Pulo simples e duplo, Interações com objetos e inimigos.

- Frog (IA de Inimigos): Patrulha entre dois pontos definidos (rightCol e leftCol), Reage ao contato com o jogador, Pode ser derrotado ao ser atingido na cabeça pelo jogador, Derrota o jogador ao contato direto, exceto quando atingido corretamente.

- GameController: Gerencia, Atualização de pontuação, Exibição de tela de game over, Reinício da fase atual.

- ParallaxEffect: Implementa o efeito de parallax para criar profundidade visual, Move camadas de fundo com base na posição do jogador e multiplicadores configuráveis.

## Requisitos para Execução

- Unity 2020 ou superior.

- Visual Studio ou outro editor de código compatível com C#.

## Como Jogar


## Prints das Fases

Fase 1: Desafio introdutório com obstáculos simples.

![print da fase 1](https://i.imgur.com/20qBhhH.jpeg)

Fase 2: Introdução de plataformas que caem.

![print da fase 2](https://i.imgur.com/Bthjdbc.jpeg)

Fase 3: Introdução de Serras, Inimigos (Frogs) e Espinhos.

![print da fase 3](https://i.imgur.com/VxDtG9h.jpeg)

Fase 4: Introdução de Ventiladores.

![print da fase 4](https://i.imgur.com/OLZVEPS.jpeg)

Fase 5: Aumento de dificuldade com inimigos, espaço limitado e combinação de todos os desafios anteriores.

![print da fase 5](https://i.imgur.com/Mh1u1aH.jpeg)

Fase 6: Fase final feliz.

![print da fase 6](https://i.imgur.com/OizoJok.jpeg)

## Autor

Este projeto foi criado por [Ryan Lira](https://github.com/RyanLinconl).

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).
