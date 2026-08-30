# 14 - Struct

## 📚 O que aprendi

Nesta aula aprendi a utilizar **`struct`** em C# para criar um tipo personalizado capaz de agrupar informações relacionadas em uma única estrutura.

O objetivo foi entender como organizar dados de um mesmo objeto sem precisar criar várias variáveis separadas.

## 💻 Exercício

Neste exercício criei uma `struct` chamada `Produto` contendo quatro atributos:

- `nome`
- `preco`
- `peso`
- `marca`

Depois criei dois produtos utilizando essa estrutura:

- Bola da Copa 2026
- Mercurial 7

Cada produto recebeu seus próprios valores para nome, preço, peso e marca.

## 🏗️ Estrutura criada

A estrutura utilizada foi:

```csharp
struct Produto
{
    public string nome;
    public float preco;
    public float peso;
    public string marca;
}
```

Essa `struct` funciona como um modelo para criar diferentes produtos com as mesmas características.

## 📦 Criando objetos

Depois de criar a estrutura, instanciei dois produtos:

- **Bola da Copa 2026**
  - Marca: Adidas
  - Preço: R$120
  - Peso: 0,8 kg

- **Mercurial 7**
  - Marca: Nike
  - Preço: R$500
  - Peso: 0,4 kg

Cada atributo foi preenchido individualmente após criar o produto.

## 🧠 Conceitos praticados

- `struct`
- Tipos personalizados
- Campos públicos (`public`)
- Instanciação de estruturas
- Atribuição de valores aos campos
- Organização de dados

## 📝 Minhas anotações

Aprendi que uma `struct` permite agrupar várias informações relacionadas em um único tipo.

Nesse exercício utilizei uma estrutura para representar produtos, deixando o código mais organizado do que criar várias variáveis separadas para nome, preço, peso e marca.

## 🚀 O que consegui fazer

Consegui criar minha primeira `struct`, instanciar diferentes produtos utilizando a mesma estrutura e preencher seus atributos individualmente.
