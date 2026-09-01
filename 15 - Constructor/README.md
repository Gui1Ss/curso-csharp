# 15 - Constructor

## 📚 O que aprendi

Nesta aula aprendi a criar um **construtor (`Constructor`)** em uma `struct` em C#.

O construtor permite inicializar todos os atributos de uma estrutura no momento em que ela é criada, deixando o código mais organizado e evitando preencher cada campo manualmente.

## 💻 Exercício

Neste exercício utilizei a `struct Produto` e adicionei um construtor que recebe quatro parâmetros:

* `nome`
* `preco`
* `peso`
* `marca`

Depois criei dois produtos utilizando apenas uma linha para cada um:

* iPhone 18 (Apple)
* Galaxy Book 6 (Samsung)

## 🏗️ Criando o construtor

O construtor criado foi:

```csharp
public Produto(string nome, float preco, float peso, string marca)
{
    this.nome = nome;
    this.preco = preco;
    this.peso = peso;
    this.marca = marca;
}
```

Aprendi que a palavra-chave `this` é utilizada para indicar que estou atribuindo valores aos atributos da própria estrutura.

## 📦 Instanciando produtos

Com o construtor, consegui criar produtos de forma muito mais simples:

```csharp
Produto iphone = new Produto("Iphone 18", 18000f, 200f, "Apple");

Produto notebook = new Produto("Galaxy Book 6", 20000f, 1800f, "Samsung");
```

Diferente da aula anterior, não foi necessário preencher cada atributo separadamente.

## 🔄 Antes e Depois

### Antes (sem construtor)

```csharp
Produto bola = new Produto();
bola.nome = "Bola da Copa 2026";
bola.preco = 120f;
```

### Depois (com construtor)

```csharp
Produto iphone = new Produto("Iphone 18", 18000f, 200f, "Apple");
```

O construtor deixou a criação dos objetos mais rápida e organizada.

## 🧠 Conceitos praticados

* Construtores (`Constructor`)
* `struct`
* `this`
* Parâmetros
* Inicialização de objetos
* Organização de código

## 📝 Minhas anotações

Aprendi que um construtor é executado automaticamente quando um objeto é criado.

Também entendi que o `this` serve para diferenciar os atributos da estrutura dos parâmetros recebidos pelo construtor.

## 🚀 O que consegui fazer

Consegui criar uma `struct` com construtor e instanciar objetos já preenchidos, deixando o código mais limpo e reduzindo a quantidade de linhas necessárias para criar novos produtos.
