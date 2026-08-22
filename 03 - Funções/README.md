# Aula 03 — Funções

> 🎯 **Conceito central:** agrupar instruções em blocos nomeados e reutilizáveis.

---

## 📖 O que eu aprendi

Até aqui todo o código morava dentro do `Main`. **Funções** (ou *métodos*, no vocabulário do C#) permitem dar um nome a um pedaço de lógica e chamá-lo quantas vezes for preciso.

Anatomia de um método:

```
static    void        ExibirMensagem   ()
  ↑        ↑                ↑           ↑
modificador  tipo de       nome      parâmetros
             retorno
```

- **`static`** — o método pertence à classe, não a um objeto. É obrigatório aqui porque o `Main` também é `static` e um método estático só chama outro estático diretamente.
- **`void`** — o método executa algo mas **não devolve** valor nenhum.
- **Parâmetros** — dados de entrada que o método recebe, como o `double preco`.

## 💻 Código comentado

```csharp
static void Main(string[] args)
{
    ExibirMensagem();       // chamada sem argumentos
    GerarPreco(18.90);      // chamada passando um argumento
}

static void ExibirMensagem()          // sem parâmetros, sem retorno
{
    Console.WriteLine("Olá, mundo!");
    Console.WriteLine("Bem-vindo");
}

static void GerarPreco(double preco)  // recebe 1 parâmetro
{
    double precoAbs = Math.Abs(preco);            // Math.Abs → valor absoluto (sem sinal)
    double valorFinal = precoAbs + (2 * precoAbs); // preço triplicado
    Console.WriteLine("Valor final: " + valorFinal);
}
```

## ▶️ Saída esperada

```
Olá, mundo!
Bem-vindo
Valor final: 56,7
```

## 🧠 Pontos de atenção

- **`Math.Abs()`** garante que um preço negativo digitado por engano não gere resultado negativo — uma defesa simples contra entrada inválida.
- **Parâmetro vs argumento:** `preco` é o *parâmetro* (na declaração); `18.90` é o *argumento* (na chamada).
- Este método **imprime** o resultado em vez de devolvê-lo. Isso limita o reuso — se eu quisesse somar dois preços, não conseguiria. A aula 04 resolve isso com `return`.

## 📝 Exercícios desta aula

| Pasta | Tema |
|-------|------|
| [03.1](../03.1%20-%20Exerc%C3%ADcio%20-%20Primeiras%20Fun%C3%A7%C3%B5es/) | Reajuste de preço com percentual |
| [03.2](../03.2%20-%20Exerc%C3%ADcio%20-%20Fun%C3%A7%C3%B5es/) | Primeira tentativa — área do círculo |
| [03.3](../03.3%20-%20Exerc%C3%ADcio%20-%20%C3%81rea%20da%20Circunfer%C3%AAncia/) | Área do círculo (versão corrigida) |
| [03.4](../03.4%20-%20Exerc%C3%ADcio%20-%20%C3%81rea%20do%20Tri%C3%A2ngulo/) | Área do triângulo |
| [03.5](../03.5%20-%20Exerc%C3%ADcios%20Extras%20de%20Fun%C3%A7%C3%B5es/) | Dobro e quadrado com `Math.Pow` |
