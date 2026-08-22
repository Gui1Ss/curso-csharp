# Exercício 03.2 — Funções (versão de estudo)

> ⚠️ **Este projeto não compila.** Ele está preservado de propósito, como registro do processo de aprendizado. A versão funcional está em [03.3](../03.3%20-%20Exerc%C3%ADcio%20-%20%C3%81rea%20da%20Circunfer%C3%AAncia/).

---

## 📖 O que eu aprendi (errando)

Esta foi a primeira tentativa de calcular a área de um círculo. Três erros diferentes apareceram aqui — e cada um ensinou uma regra da linguagem.

## ❌ Os erros e o que cada um ensina

### 1. Ponto e vírgula faltando

```csharp
return circunferencia    // ← CS1002: ";" esperado
```

Toda instrução em C# termina com `;`. A quebra de linha não encerra comando nenhum — diferente de Python.

### 2. Método não estático chamado de contexto estático

```csharp
double areaCirculo(double raio)   // ← sem 'static'
```

Sem `static`, o método pertence a uma **instância** de `Program`. Como o `Main` é estático e não existe nenhum objeto `Program` criado, ele não teria como chamar esse método. Foi assim que a palavra `static` deixou de ser "aquela coisa que sempre vem antes" e passou a fazer sentido.

### 3. A função nunca é chamada

```csharp
Console.WriteLine("Digite o valor do raio");
double circunferencia = double.Parse(Console.ReadLine());

Console.WriteLine("A área do circulo é:  " + circunferencia);  // imprime o RAIO
```

Mesmo se compilasse, o programa imprimiria o raio digitado. O `Main` lê o valor e mostra direto na tela, sem passar por `areaCirculo()` — o método existe, mas ninguém o usa.

### 4. Fórmula trocada

`(raio * 2) * Math.PI` é o **perímetro** (circunferência), não a área. A área é `π · r²`.

## ✅ Como ficaria correto

```csharp
static void Main(string[] args)
{
    Console.Write("Digite o valor do raio: ");
    double raio = double.Parse(Console.ReadLine());

    double area = AreaCirculo(raio);   // agora a função é realmente usada
    Console.WriteLine("A área do círculo é: " + area);
}

static double AreaCirculo(double raio)
{
    return Math.PI * raio * raio;      // fórmula correta: π · r²
}
```

## 🧠 Lição principal

> Declarar uma função não é o mesmo que executá-la. O compilador aponta erros de sintaxe, mas **erros de lógica ele deixa passar** — a fórmula errada teria rodado sem reclamação nenhuma.
