# Exercício 05.1 — Funções + Arrays

> 🎯 **Desafio:** ler 5 notas do usuário e calcular média, maior e menor nota — cada tarefa em sua própria função.

---

## 📖 O que eu aprendi

Este é o exercício mais completo até aqui: ele **junta tudo** — entrada de dados, funções com retorno, arrays e laços. E introduz o conceito mais importante do módulo: **passar e retornar arrays**.

### Separação de responsabilidades

O `Main` virou um roteiro de cinco linhas. Cada função faz **uma coisa só**:

| Função | Responsabilidade |
|--------|-----------------|
| `LerNotas()` | Coleta a entrada e **devolve** o array |
| `MostrarNotas()` | Exibe a lista |
| `CalcularMedia()` | Soma e divide |
| `MaiorNota()` | Encontra o máximo |
| `MenorNota()` | Encontra o mínimo |

### Arrays são tipos de referência

```csharp
double[] notas = LerNotas();   // a função devolve o array inteiro
MostrarNotas(notas);           // e ele pode ser passado adiante
```

O que trafega não é uma cópia dos 5 valores, e sim uma **referência** ao array na memória. Consequência prática: se um método alterar `notas[0]`, a mudança é visível no `Main` também — diferente de um `int` ou `double`, que são copiados.

## 💻 Trechos-chave

**Preencher um array lendo do teclado:**

```csharp
static double[] LerNotas()
{
    double[] notas = new double[5];    // array vazio (5 zeros)
    for (int i = 0; i < notas.Length; i++)
    {
        Console.Write($"Digite a nota {i + 1}: ");   // i+1 → usuário conta de 1, não de 0
        notas[i] = Convert.ToDouble(Console.ReadLine());
    }
    return notas;
}
```

**Acumulador — o padrão para somar tudo:**

```csharp
double soma = 0;                                // começa em zero (elemento neutro da soma)
for (int i = 0; i < notas.Length; i++)
{
    soma += notas[i];                           // soma = soma + notas[i]
}
double media = soma / notas.Length;
```

**Busca do máximo — o padrão para encontrar extremos:**

```csharp
double maior = notas[0];                        // assume o primeiro como candidato
for (int i = 1; i < notas.Length; i++)          // começa em 1: o 0 já é o candidato
{
    if (maior < notas[i]) maior = notas[i];     // achou um melhor? troca
}
```

> A diferença entre os dois padrões é o valor inicial. Na **soma**, começar em `0` é seguro. Na **busca do maior**, começar em `0` seria um bug: se todas as notas fossem negativas, o resultado seria `0` — um valor que nunca esteve no array. Por isso inicializa-se com `notas[0]`.

## ▶️ Saída esperada

```
Digite a nota 1: 7,5
Digite a nota 2: 8
Digite a nota 3: 6
Digite a nota 4: 9,5
Digite a nota 5: 10

Notas
Notas 1: 7,5
Notas 2: 8
Notas 3: 6
Notas 4: 9,5
Notas 5: 10

Média
Média: 8,2

Maior Nota
Maior nota: 10

Menor Nota
Menor nota: 6
```

## 🧠 Pontos de atenção

- **`Convert.ToDouble()` vs `double.Parse()`:** ambos convertem, mas `Convert` trata `null` como `0` em vez de lançar exceção.
- **Retorno ignorado.** `CalcularMedia()`, `MaiorNota()` e `MenorNota()` devolvem `double`, mas o `Main` chama sem guardar o valor. Isso funciona porque as próprias funções imprimem — só que elas fazem **duas coisas** (calcular *e* exibir), o que mistura responsabilidades. O ideal:

  ```csharp
  double media = CalcularMedia(notas);
  Console.WriteLine($"Média: {media}");   // exibição fica no Main
  ```

- **Tamanho fixo em 5.** Passar a quantidade como parâmetro (`LerNotas(int quantidade)`) tornaria a função reutilizável para qualquer turma.
- **Atalho do .NET:** `notas.Max()`, `notas.Min()` e `notas.Average()` já existem via LINQ (`using System.Linq`). Escrever os laços na mão primeiro é o que faz entender o que esses métodos realmente executam.

## 🔗 Aula relacionada

[05 — Arrays](../05%20-%20Arrays/)
