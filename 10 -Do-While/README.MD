# 10 - Do While

## 📚 O que aprendi

Nesta aula aprendi a utilizar a estrutura de repetição `do while` em C#.

O `do while` funciona de forma parecida com o `while`, mas existe uma diferença importante: o código dentro do `do` é executado **pelo menos uma vez**, antes da condição ser verificada.

## 💻 Exercício

Neste exercício criei uma variável chamada `cont` com o valor inicial `0`.

Depois utilizei um `do while` para repetir o código enquanto `cont` fosse menor que `10`.

```csharp
int cont = 0;

do
{
    Console.WriteLine("do while");
    cont++;

} while (cont < 10);
```

A cada repetição, a variável `cont` é incrementada com:

```csharp
cont++;
```

Quando `cont` chega a `10`, a condição `cont < 10` deixa de ser verdadeira e o loop termina.

## 🔄 Diferença entre While e Do While

A principal diferença que aprendi é:

### While

No `while`, a condição é verificada **antes** da execução.

```csharp
while (condicao)
{
    // código
}
```

Se a condição já for falsa, o código pode não ser executado nenhuma vez.

### Do While

No `do while`, o código é executado primeiro e a condição é verificada depois.

```csharp
do
{
    // código
}
while (condicao);
```

Por isso, o `do while` executa o bloco pelo menos uma vez. Essa foi a principal observação que fiz durante o exercício.

## 🧪 Teste da condição

Também fiz um teste comentando outro `do while`, utilizando uma condição que já começa como falsa:

```csharp
do
{
    Console.WriteLine("do while");
    cont++;

} while (1000 < 10);
```

Mesmo que `1000 < 10` seja falso, o código dentro do `do` seria executado uma vez antes da condição ser verificada.

## 🧠 Conceitos praticados

* `do while`
* Condições
* Contador
* `cont++`
* Estruturas de repetição
* Diferença entre `while` e `do while`

## 📝 Minhas anotações

O `do while` é parecido com o `while`, mas a ordem muda:

**Do While:**

1. Executa o código.
2. Verifica a condição.
3. Se for verdadeira, repete.
4. Se for falsa, encerra.

O ponto principal que aprendi é que o `do while` executa pelo menos uma vez, mesmo que a condição seja falsa.

## 🚀 O que consegui fazer

Consegui criar uma estrutura `do while` utilizando um contador e entender a diferença entre ela e o `while`.
