# Exercício 03.5 — Exercícios Extras de Funções

> 🎯 **Desafio:** ler um número do usuário e exibir operações matemáticas sobre ele.

---

## 📖 O que eu aprendi

Dois conceitos novos aparecem aqui: a **interpolação de strings** e o **cast explícito**.

### Interpolação de strings

Comparando com o que vinha sendo feito antes:

```csharp
Console.WriteLine("O resultado é: " + resultado);   // concatenação
Console.WriteLine($"O resultado é: {resultado}");   // interpolação — mais legível
```

O `$` antes das aspas libera o uso de `{variavel}` dentro do texto. Com três ou quatro variáveis na mesma linha, a diferença de legibilidade fica gritante.

### Cast explícito

```csharp
double resultado = Math.Pow(num, 2);
return (int)resultado;   // (int) força a conversão double → int
```

`Math.Pow()` **sempre** devolve `double`, mesmo elevando inteiros. Como o método promete retornar `int`, o compilador exige a conversão explícita — ele não faz sozinho porque isso **descarta a parte decimal** (`(int)3.99` vira `3`, não `4`).

## 💻 Código comentado

```csharp
static void Main(string[] args)
{
    Console.Write("Digite um número: ");
    String entrada = Console.ReadLine();
    int num = int.Parse(entrada);      // conversão em 2 etapas: ler, depois converter

    Console.WriteLine($"O dobro é: {CalcularDobro(num)}");  // chamada direta dentro da string
    int dobro = CalcularDobro(num);
    Console.Write($"O quadrado é: {dobro}");
}

static int CalcularDobro(int num)
{
    double resultado = Math.Pow(num, 2);   // Math.Pow(base, expoente)
    return (int)resultado;
}
```

## ▶️ Saída esperada

```
Digite um número: 5
O dobro é: 25
O quadrado é: 25
```

## ⚠️ Erro de lógica identificado

O método se chama `CalcularDobro`, mas `Math.Pow(num, 2)` calcula o **quadrado** (`num²`), não o dobro (`num * 2`). Para `num = 2` os dois coincidem em `4`, o que esconde o problema — mas para `5` o dobro seria `10`, e o programa mostra `25`.

Como as duas linhas chamam o mesmo método, a saída repete o mesmo número com rótulos diferentes.

**Correção:**

```csharp
static int CalcularDobro(int num)  => num * 2;
static int CalcularQuadrado(int num) => (int)Math.Pow(num, 2);
```

> 💡 **Lição:** o nome de uma função é uma promessa. Quando ele não corresponde ao que o código faz, o bug fica invisível — porque a gente lê o nome e confia nele.

## 🔗 Aula relacionada

[03 — Funções](../03%20-%20Fun%C3%A7%C3%B5es/)
