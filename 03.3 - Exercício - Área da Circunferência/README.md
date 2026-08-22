# Exercício 03.3 — Área da Circunferência

> 🎯 **Desafio:** ler o raio digitado pelo usuário e calcular a área do círculo.

---

## 📖 O que eu aprendi

Esta é a versão corrigida do [03.2](../03.2%20-%20Exerc%C3%ADcio%20-%20Fun%C3%A7%C3%B5es/), e ela junta tudo que veio antes: entrada de dados (aula 01), constante matemática (aula 02) e função com retorno (aula 03.1).

O conceito novo é a **conversão de tipos**. Como `Console.ReadLine()` devolve `string`, o texto precisa virar número antes de entrar em qualquer conta — `"5" * 2` simplesmente não existe em C#.

## 💻 Código comentado

```csharp
static void Main(string[] args)
{
    Console.Write("Digite o valor do raio: ");
    double raio = double.Parse(Console.ReadLine());  // string → double

    double area = areaCirculo(raio);   // resultado guardado em variável

    Console.Write("A área do circulo é:  " + area);
}

static double areaCirculo(double raio)
{
    return Math.PI * raio * raio;   // π · r² — Math.PI já vem pronto no .NET
}
```

## ▶️ Saída esperada

```
Digite o valor do raio: 5
A área do circulo é:  78,5398163397448
```

## 🧠 Pontos de atenção

- **`Math.PI` em vez de `const float PI`.** É `double`, muito mais preciso que os 5 decimais escritos à mão na aula 02, e já está disponível sem declarar nada.
- **`double.Parse()` quebra o programa se a entrada não for número.** Digitar `abc` lança uma `FormatException`. A forma segura é `double.TryParse(entrada, out double raio)`, que devolve `true`/`false` em vez de estourar — vale revisitar quando o curso chegar em tratamento de exceções.
- **Separador decimal:** em português, `Parse` espera vírgula. Digitar `2.5` provavelmente será lido como `25`.
- **Nome do método:** `areaCirculo` está em `camelCase`. A convenção do C# para métodos é `PascalCase` (`AreaCirculo`) — vale padronizar daqui pra frente.

## 🔗 Aula relacionada

[03 — Funções](../03%20-%20Fun%C3%A7%C3%B5es/)
