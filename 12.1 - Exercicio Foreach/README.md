# 12.1 - Exercício Foreach e For

## 📚 O que aprendi

Neste exercício pratiquei os laços `foreach` e `for`, combinando-os com `if` / `else`.

## 💻 Exercícios

### 1. Lista de boas-vindas com `foreach`

Percorri um array de nomes e exibi uma mensagem numerada para cada aluno.

```csharp
int i = 1;
foreach (string nomes in alunos)
{
    Console.WriteLine(i + " Bem vindo(a) " + nomes);
    i++;
}
```

### 2. Contagem regressiva com `for`

```csharp
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
```

### 3. Controle de velocidade

O laço vai de 100 a 220 km/h e avisa quando a velocidade passa do limite de 200 km/h.

```csharp
for (int velocidade = 100; velocidade <= 220; velocidade++)
{
    if (velocidade >= 200)
        Console.WriteLine("Você esta ultrapassando a velocidade permitida...");
    else
        Console.WriteLine("Você esta na velocidade permitida...");
}
```

## 🧠 Aprendizados

* `foreach` é ideal para percorrer todos os itens de uma coleção.
* `for` dá controle sobre início, fim e passo do contador.
* Dá para combinar laços com condicionais para tomar decisões a cada repetição.
