# 09 - While

## 📚 O que aprendi

Nesta aula aprendi a utilizar a estrutura de repetição `while` em C#.

O `while` permite repetir um determinado bloco de código enquanto uma condição for verdadeira.

## 💻 Exercício

Neste exercício criei uma variável chamada `cont` e atribuí o valor `0`.

Depois utilizei um `while` para repetir o código enquanto `cont` fosse menor que `10`.

```csharp
int cont = 0;

while (cont < 10)
{
    Console.WriteLine(cont + 1);
    Console.WriteLine("Infinito");
    cont++;
}
```

A cada repetição, a variável `cont` é incrementada utilizando `cont++`.

Quando `cont` chega a `10`, a condição `cont < 10` deixa de ser verdadeira e o `while` é encerrado.

Depois do `while`, o programa continua executando e mostra:

```text
Fim da linha
```

## 🔢 Contador

Neste exercício utilizei uma variável como contador:

```csharp
int cont = 0;
```

A cada repetição:

```csharp
cont++;
```

Isso faz com que o valor de `cont` aumente em `1`.

## 🧠 Conceitos praticados

* `while`
* Condições
* Contador
* `cont++`
* `Console.WriteLine()`
* Estruturas de repetição

## 📝 Minhas anotações

O `while` continua executando enquanto sua condição for verdadeira.

Neste exercício, a condição utilizada foi:

```csharp
cont < 10
```

Também aprendi que é importante alterar a variável utilizada na condição. Caso contrário, o `while` poderia continuar executando indefinidamente.

## 🚀 O que consegui fazer

Consegui criar um contador utilizando `while` e fazer o programa repetir uma ação até que a condição deixasse de ser verdadeira.
