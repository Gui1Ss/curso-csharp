<div align="center">

# 📘 Curso de C# — Anotações e Exercícios

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

**Progresso do curso:** 65%

![65%](https://progress-bar.xyz/65/?width=400&color=6b46c1)

</div>

---

## 📌 Sobre

Repositório de estudos com os exercícios do curso **"C# para iniciantes — Crie 4 projetos"**, de **Victor Lima (Guia do Programador)**.

Cada pasta representa um projeto de console independente, acompanhado de um `README.md` com:

- Explicação do conceito estudado;
- Código comentado;
- Exemplo de saída no console;
- Aprendizados e erros encontrados durante o desenvolvimento.

O objetivo é registrar minha evolução em **C#** enquanto construo uma base sólida para desenvolvimento com **.NET**.

---

## 🗂️ Índice das aulas

| # | Módulo | Conceito | Anotações |
|:--:|--------|----------|:---------:|
| 01 | Capturando Entrada de Dados | `Console.ReadLine()`, `Write` vs `WriteLine` | [📖](./01%20-%20Capturando%20Entrada%20de%20Dados/) |
| 02 | Constantes | `const`, sufixo `f`, imutabilidade | [📖](./02%20-%20Constantes/) |
| 03 | Funções | `static`, `void`, parâmetros | [📖](./03%20-%20Fun%C3%A7%C3%B5es/) |
| 03.1 | 📝 Primeiras Funções | Primeiro `return` | [📖](./03.1%20-%20Exerc%C3%ADcio%20-%20Primeiras%20Fun%C3%A7%C3%B5es/) |
| 03.2 | 📝 Funções *(com erros)* | Erros de compilação e lógica | [📖](./03.2%20-%20Exerc%C3%ADcio%20-%20Fun%C3%A7%C3%B5es/) |
| 03.3 | 📝 Área da Circunferência | `Math.PI`, `double.Parse()` | [📖](./03.3%20-%20Exerc%C3%ADcio%20-%20%C3%81rea%20da%20Circunfer%C3%AAncia/) |
| 03.4 | 📝 Área do Triângulo | Múltiplos parâmetros | [📖](./03.4%20-%20Exerc%C3%ADcio%20-%20%C3%81rea%20do%20Tri%C3%A2ngulo/) |
| 03.5 | 📝 Exercícios Extras | Interpolação, cast, `Math.Pow()` | [📖](./03.5%20-%20Exerc%C3%ADcios%20Extras%20de%20Fun%C3%A7%C3%B5es/) |
| 04 | Funções com Retorno | `return` e composição | [📖](./04%20-%20Fun%C3%A7%C3%B5es%20com%20Retorno/) |
| 05 | Arrays | Índices, `.Length`, `for` | [📖](./05%20-%20Arrays/) |
| 05.1 | 📝 Funções + Arrays | Acumulador e busca de extremos | [📖](./05.1%20-%20Exerc%C3%ADcio%20-%20Fun%C3%A7%C3%B5es%20%2B%20Arrays/) |
| 16 | Funções em Structs | `struct`, construtor, métodos | [📖](./16%20-%20Fun%C3%A7%C3%B5es%20em%20Structs/) |
| 17 | Listas (`List<T>`) | `Add()`, `Find()`, `FindAll()`, `foreach` | [📖](./17%20-%20Lista%20e%20FindAll/) |

---

## 🧠 Conceitos dominados

<grid columns=2><grid-item>
    <box background=surface radius=xl padding=3 gap=2 border=1 height="100%">
      <row gap=2 align=center>
        <icon name=cog color=discovery />
        **Fundamentos**
      </row>
      <box gap=1 padding={{ left: 1 }}>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Entrada e saída no console</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Variáveis e tipos primitivos</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Constantes com `const`</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Conversão de tipos (`Parse`, `Convert` e cast)</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Interpolação de strings</text></row>
      </box>
    </box>
  </grid-item><grid-item>
    <box background=surface radius=xl padding=3 gap=2 border=1 height="100%">
      <row gap=2 align=center>
        <icon name=code color=discovery />
        **Estruturação**
      </row>
      <box gap=1 padding={{ left: 1 }}>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Métodos com e sem retorno</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Parâmetros e argumentos</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Modificador `static`</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>Arrays de tamanho fixo</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>`struct` com construtores e métodos</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>`List<T>` e expressões lambda</text></row>
        <row gap=2 align=center><icon name=check color=success/><text size=sm>`foreach` para percorrer coleções</text></row>
      </box>
    </box>
  </grid-item></grid>

---

## 🚀 Como executar

### Pré-requisitos

- Visual Studio 2022
- Carga de trabalho **Desenvolvimento para desktop com .NET**
- .NET Framework 4.7.2 Developer Pack

### Clone o repositório

```bash
git clone https://github.com/Gui1Ss/curso-csharp.git
cd curso-csharp
```

Abra o arquivo `.sln` (ou `.slnx`) do módulo desejado e execute com:

- **F5** → Executar com depuração
- **Ctrl + F5** → Executar sem depuração

> Cada projeto é independente e pode ser executado separadamente.

---

## 🛣️ Roadmap

### ✅ Concluído

- [x] Entrada de dados
- [x] Constantes
- [x] Funções
- [x] Funções com retorno
- [x] Arrays
- [x] Structs
- [x] Listas (`List<T>`) e filtros (`FindAll`)

### 📚 Próximos módulos

- [ ] Estruturas condicionais (`if`, `else if`, `switch`)
- [ ] Estruturas de repetição (`while`, `do while`)
- [ ] Programação Orientada a Objetos
- [ ] Encapsulamento
- [ ] Herança
- [ ] Polimorfismo
- [ ] Interfaces
- [ ] Tratamento de exceções
- [ ] Os **4 projetos finais** do curso

---

## 📈 Evolução

Atualmente já pratiquei:

- Criação de métodos reutilizáveis;
- Manipulação de arrays e listas;
- Uso de `struct` para organizar dados;
- Expressões lambda para filtragem;
- Construção de pequenos projetos de console.

A ideia é que este repositório acompanhe toda a minha evolução até chegar ao desenvolvimento com **C# e .NET**.

---

## 👤 Autor

**Guilherme Silva**

🎓 Estudante de Análise e Desenvolvimento de Sistemas

[![GitHub](https://img.shields.io/badge/GitHub-Gui1Ss-181717?style=flat-square&logo=github)](https://github.com/Gui1Ss)

---

<div align="center">

⭐ Se este repositório te ajudou de alguma forma, considere deixar uma estrela!

</div>
