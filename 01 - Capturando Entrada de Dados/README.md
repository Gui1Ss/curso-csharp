# Aula 01 — Capturando Entrada de Dados

> 🎯 **Conceito central:** ler informações digitadas pelo usuário no console e devolvê-las na tela.

---

## 📖 O que eu aprendi

Todo programa útil precisa **receber dados** de algum lugar. No console, esse canal de entrada é o teclado, e o C# nos dá a classe estática `Console` para trabalhar com ele.

Aqui a diferença entre os três métodos ficou clara:

| Método | O que faz |
|--------|-----------|
| `Console.Write()` | Escreve na tela **sem** pular linha |
| `Console.WriteLine()` | Escreve na tela **e** pula linha |
| `Console.ReadLine()` | Pausa o programa e **lê** tudo que o usuário digitar até apertar Enter |

O detalhe importante: `Console.Write()` foi usado de propósito antes da leitura, para o cursor piscar **na mesma linha** da pergunta — um detalhe pequeno que muda bastante a aparência do programa.

## 💻 Código comentado

```csharp
string nome = "";                      // variável declarada e inicializada vazia

Console.Write("Escreva seu nome: ");   // Write (sem Line) → cursor fica na mesma linha
nome = Console.ReadLine();             // programa PARA e espera o Enter do usuário

Console.WriteLine("Seu nome é: " + nome);  // concatenação com o operador +
```

## ▶️ Saída esperada

```
Escreva seu nome: Guilherme
Seu nome é: Guilherme
```

## 🧠 Pontos de atenção

- **`ReadLine()` sempre retorna `string`.** Mesmo que o usuário digite `42`, o que chega é o texto `"42"`. Para usar como número é obrigatório converter (isso aparece na aula 03.3).
- **Concatenação com `+`** funciona, mas em aulas seguintes a interpolação (`$"Seu nome é: {nome}"`) se mostra bem mais legível.
- Inicializar `nome = ""` antes de usar não era estritamente necessário aqui, já que a atribuição vem logo depois — mas é um bom hábito para evitar o erro *"uso de variável local não atribuída"*.

## 🔗 Próxima aula

[02 — Constantes](../02%20-%20Constantes/) — valores que não podem mudar.
