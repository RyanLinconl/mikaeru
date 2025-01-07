Jogo de Plataforma 2D com Unity e C#

Este repositório contém um jogo de plataforma 2D desenvolvido com Unity e C#. O projeto apresenta uma jogabilidade envolvente e mecânicas como pulo duplo, inimigos com IA básica, e efeitos visuais com parallax. São 6 fases no total, com diferentes desafios e ambientes.

Funcionalidades Principais

Movimentação do jogador:

Andar para frente e para trás.

Pulo duplo com restrição de uso.

Animações fluídas integradas à jogabilidade.

Inimigos:

IA básica com patrulha e colisão.

Reações diferentes ao ser atingido pelo jogador ou ao derrotar o jogador.

Efeitos Visuais:

Parallax para um fundo dinâmico que acompanha o movimento do jogador.

Sistema de Pontuação:

Contador de pontos exibido em tempo real.

Sistema de game over com reinício da fase.

6 Fases Exclusivas:

Cada fase tem desafios únicos e novos elementos para explorar.

Estrutura de Scripts

1. Player Controller

Gerencia a movimentação e as ações do jogador, incluindo:

Movimentação horizontal.

Pulo simples e duplo.

Interações com objetos e inimigos.

2. Frog (IA de Inimigos)

Patrulha entre dois pontos definidos (rightCol e leftCol).

Reage ao contato com o jogador:

Pode ser derrotado ao ser atingido pela cabeça do jogador.

Derrota o jogador ao contato direto, exceto quando atingido corretamente.

3. GameController

Gerencia:

Atualização de pontuação.

Exibição de tela de game over.

Reinício da fase atual.

4. ParallaxEffect

Implementa o efeito de parallax para criar profundidade visual.

Move camadas de fundo com base na posição do jogador e multiplicadores configuráveis.

Requisitos para Execução

Unity 2020 ou superior.

Visual Studio ou outro editor de código compatível com C#.

Como Jogar

Estrutura do Projeto

Assets/Scripts: Contém todos os scripts em C# utilizados no jogo.

Assets/Sprites: Sprites e animações dos personagens e objetos.

Assets/Scenes: Fases do jogo organizadas em cenas separadas.

Prints das Fases

Fase 1: Desafio introdutório com obstáculos simples.

([print da fase 1](https://imgur.com/20qBhhH))

Fase 2: Introdução de plataformas que caem.

([print da fase 2](https://imgur.com/Bthjdbc))

Fase 3: Introdução de Serras, Inimigos (Frogs) e Espinhos.

([print da fase 3](https://imgur.com/VxDtG9h))

Fase 4: Introdução de Ventiladores.

([print da fase 4](https://imgur.com/OLZVEPS))

Fase 5: Aumento de dificuldade com inimigos, espaço limitado e combinação de todos os desafios anteriores.

([print da fase 5](https://imgur.com/Mh1u1aH))

Fase 6: Fase final feliz.

([print da fase 6](https://imgur.com/OizoJok))

Licença

Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.
