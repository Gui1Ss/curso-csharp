# Exercício 03.4 — Área do Triângulo

> 🎯 **Desafio:** criar uma função que receba base e altura e devolva a área do triângulo.

---

## 📖 O que eu aprendi

O conceito novo aqui é o **método com mais de um parâmetro**. A regra é direta: os argumentos são associados **pela posição**, não pelo nome.

```csharp
calculaTriangulo(250, 350);
//                ↓     ↓
static double calculaTriangulo(double baseTri, double altura)
```

Se eu invertesse a chamada para `calculaTriangulo(350, 250)`, o resultado seria o mesmo — porque a multiplicação é comutativa. Mas em uma função de divisão ou subtração, trocar a ordem daria resultado errado **sem erro nenhum de compilação**.

## 💻 Código comentado

```csharp
static void Main(string[] args)
{
    double area = calculaTriangulo(250, 350);   // valores fixos, sem entrada do usuário
    Console.WriteLine("A área do triângulo é: " + area);
}

static double calculaTriangulo(double baseTri, double altura)
{                            // ↑ 'baseTri' e não 'base': 'base' é palavra reservada!
    return (baseTri * altura) / 2;   // fórmula: (b × h) ÷ 2
}
```

## ▶️ Saída esperada

```
A área do triângulo é: 43750
```

## 🧠 Pontos de atenção

- **`base` é palavra reservada** do C# (usada em herança, para acessar a classe-mãe). Por isso o parâmetro virou `baseTri` — um detalhe que só se descobre quando o editor sublinha em vermelho.
- **Parênteses opcionais, mas úteis:** `(baseTri * altura) / 2` daria o mesmo que `baseTri * altura / 2`, já que `*` e `/` têm a mesma precedência e avaliam da esquerda para a direita. Os parênteses ficam pela clareza.
- **Divisão inteira é uma armadilha.** Aqui os valores são `double`, então `/ 2` funciona. Se fossem `int`, `7 / 2` daria `3` — o resto seria descartado.

## 🔗 Aula relacionada

[03 — Funções](../03%20-%20Fun%C3%A7%C3%B5es/)
