# Gestor de Clientes (Console)

Este projeto é um sistema de gerenciamento de clientes desenvolvido em **C#** para o terminal. Nele é possível cadastrar, listar e remover clientes, mantendo as informações salvas em um arquivo para que os dados permaneçam disponíveis mesmo após fechar o programa.

## Objetivo

Praticar conceitos fundamentais da linguagem C# em um projeto mais próximo de uma aplicação real, utilizando:

* `struct`
* `List<T>`
* `enum`
* `switch`
* Métodos
* Persistência de dados em arquivo
* Serialização e desserialização

## Funcionalidades

* Listar clientes cadastrados.
* Adicionar novos clientes.
* Remover clientes pelo ID.
* Salvar os dados automaticamente em arquivo.
* Carregar os dados ao iniciar o programa.

## Estrutura do Projeto

Cada cliente é representado pela `struct Cliente`, contendo:

* Nome
* E-mail
* CPF

Os clientes são armazenados em uma `List<Cliente>`, permitindo adicionar e remover registros dinamicamente.

## Código Principal

O programa inicia carregando os clientes salvos no arquivo `clientes.txt`. Em seguida, apresenta um menu interativo com quatro opções:

```text
1 - Listagem
2 - Adicionar
3 - Remover
4 - Sair
```

A navegação é controlada por um `enum` e um `switch`, tornando o código mais organizado.

## Como funciona cada opção

### Listagem

Percorre todos os clientes cadastrados utilizando `foreach`, exibindo:

* ID
* Nome
* E-mail
* CPF

### Adicionar

Solicita ao usuário:

* Nome
* E-mail
* CPF

Após preencher os dados:

1. adiciona o cliente na lista;
2. salva automaticamente no arquivo.

### Remover

Primeiro exibe a lista de clientes e, depois, solicita o ID do registro que será removido.

Se o ID for válido, o cliente é removido e o arquivo é atualizado.

## Persistência dos Dados

O projeto utiliza:

* `FileStream`
* `BinaryFormatter`

para serializar e desserializar a lista de clientes no arquivo `clientes.txt`.

Ao iniciar o programa:

* tenta carregar o arquivo existente;
* caso ele esteja vazio ou inexistente, cria uma nova lista.

## Exemplo de Uso

### Menu inicial

```text
Sistema de clientes - Bem vindo!

1- Listagem
2- Adicionar
3- Remover
4- Sair
```

### Cliente cadastrado

```text
Lista de clientes:

ID: 0
Nome: Guilherme
Email: guilherme@email.com
Cliente: 123.456.789-00
=========================
```

## Conceitos praticados

| Conceito        | Aplicação                      |
| --------------- | ------------------------------ |
| `struct`        | Representação do cliente       |
| `List<T>`       | Armazenamento dinâmico         |
| `enum`          | Organização das opções do menu |
| `switch`        | Controle do fluxo              |
| `foreach`       | Listagem dos clientes          |
| `FileStream`    | Manipulação de arquivos        |
| Serialização    | Salvar dados em disco          |
| Desserialização | Recuperar dados ao iniciar     |

## Como executar

1. Clone o repositório.
2. Abra a solução no Visual Studio.
3. Execute o projeto (`Ctrl + F5`).

Ou pelo terminal:

```bash
dotnet run
```

## Aprendizados

Este exercício foi um dos primeiros projetos completos do curso, reunindo diversos conceitos aprendidos anteriormente em uma única aplicação. Além da manipulação de listas e structs, ele introduz a persistência de dados em arquivo, permitindo que as informações continuem salvas entre diferentes execuções do programa.
