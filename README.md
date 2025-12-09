# 📚 Repositório de Estudos C#

Repositório de estudos práticos em C# com exemplos de manipulação de arquivos, Design Patterns, SOLID e conceitos fundamentais da linguagem.

---

## 📁 Estrutura do Repositório

### 1️⃣ CSharp-FilesStreams

Projeto focado em manipulação de arquivos, streams e monitoramento de sistema de arquivos em C#.

#### **01-GerenciandoArquivosDiretorios**
Exemplos práticos de gerenciamento de arquivos e diretórios.

- **01NewConsoleApp** - Criação de aplicação console básica
- **02FileExists** - Verificação de existência de arquivos
- **03ParentDir** - Navegação em diretórios pai
- **04DirExists** - Verificação de existência de diretórios
- **05Copy** - Cópia de arquivos
- **06Move** - Movimentação de arquivos
- **07FileExtension** - Manipulação de extensões de arquivo
- **08DeleteDir** - Exclusão de diretórios
- **09FileList** - Listagem de arquivos

**Stack:** C#, System.IO

---

#### **02-Monitorando**
Implementação de monitoramento de sistema de arquivos usando FileSystemWatcher.

- **01RefactoringToFileSystemWatcher** - Refatoração para uso de FileSystemWatcher
- **02ObservingEvents** - Observação de eventos de arquivo
- **03ProcessingCreatedFiles** - Processamento de arquivos criados
- **04ProcessingUpdatedFiles** - Processamento de arquivos atualizados
- **05Dictionary** - Uso de dicionários para cache
- **06Cache** - Implementação de cache de arquivos
- **07ExistingFiles** - Processamento de arquivos existentes

**Stack:** C#, FileSystemWatcher, System.Runtime.Caching

---

#### **03-LendoEscrevendo**
Leitura e escrita de dados em diferentes formatos.

- **01TextFiles** - Manipulação de arquivos de texto
- **02TextFileLines** - Leitura linha a linha
- **03BinaryData** - Manipulação de dados binários

**Stack:** C#, System.IO, File, StreamReader, StreamWriter

---

#### **04-LendoEscrevendo_Stream**
Uso avançado de Streams para leitura e escrita eficiente.

- **01TextStreams** - Streams de texto
- **02Simplifying** - Simplificação de código
- **03SelectiveStreamText** - Leitura seletiva de texto
- **04BinaryStream** - Streams binários
- **05BinaryReaderWriter** - Uso de BinaryReader e BinaryWriter

**Stack:** C#, Stream, BinaryReader, BinaryWriter, FileStream

---

#### **05-LendoEscrevendo_CSV**
Manipulação completa de arquivos CSV.

- **01Dynamic** - Leitura dinâmica
- **02Comments** - Tratamento de comentários
- **03Whitespace** - Tratamento de espaços em branco
- **04BlankLines** - Tratamento de linhas em branco
- **05Headers** - Manipulação de cabeçalhos
- **06Delimiter** - Delimitadores customizados
- **07StrongType** - Mapeamento tipado forte
- **08ClassMapping** - Mapeamento de classes
- **09TypeConverter** - Conversores de tipo
- **10MissingFields** - Tratamento de campos faltantes
- **11WritingCSVFiles** - Escrita de arquivos CSV

**Stack:** C#, CsvHelper, System.Globalization

---

#### **06-Testes**
Testes unitários para processadores de arquivo.

- **01Refactoring** - Refatoração de código
- **02TextFileProcessorTest** - Testes para processador de texto
- **03BinaryFileProcessorTest** - Testes para processador binário
- **04CsvFileProcessorTest** - Testes para processador CSV
- **05ApprovalTests** - Testes de aprovação

**Stack:** C#, xUnit/NUnit, ApprovalTests

---

### 2️⃣ EstudosVariados

Projeto de estudos gerais com exemplos práticos de diversos conceitos C#.

**Principais conceitos:**
- Leitura de arquivos de configuração JSON
- Requisições HTTP
- Serialização com System.Text.Json
- Microsoft.Extensions.Configuration
- HttpClient

**Stack:** .NET 10.0, C#, System.Net.Http, System.Text.Json

---

### 3️⃣ EstudosVariados2

Coleção abrangente de estudos sobre C#, incluindo conceitos fundamentais, Design Patterns e SOLID.

#### **Aulas Dio+Udemy**
Estudos completos de cursos da DIO e Udemy.

**Tópicos principais:**
- **0.Atividades Estudos** - Exercícios práticos
- **1.Entrada Saida de dados e conversoes** - I/O e conversões
- **2.Tipos de dados E Operacoes** - Tipos primitivos e operações
- **3.Conversão de Dados** - Type casting e conversões
- **4.Vetores Foreach e listas** - Arrays e listas
- **5.Estruturas de Decisao** - If/else, switch
- **6.Estrutura das Classes** - POO básico
- **7.This Construct e Estatic** - Construtores e membros estáticos
- **8.Classes Parciais** - Partial classes
- **9.Colecoes** - Collections Framework
- **10.Tuplas** - Tuplas em C#
- **11.Desconstruct** - Desconstrução de objetos
- **12.Serializacao** - Serialização/Deserialização
- **13.Heranca** - Herança e polimorfismo
- **14.API** - Criação de APIs
- **15.Consumo de API** - Consumo de APIs REST
- **16.minimal-api-main** - Minimal APIs .NET
- **17.Entity** - Entity Framework
- **18.Recursividade** - Recursão
- **22.Task** - Programação assíncrona com Task
- **23.Thread** - Multithreading
- **24-30.Forms** - Windows Forms (detalhes e controles)
- **31.TryCatch** - Tratamento de exceções
- **32.Arquivos** - Manipulação de arquivos
- **33.Writer** - StreamWriter
- **34.Bases de dados** - Banco de dados
- **36.GdiPlus** - Gráficos com GDI+
- **37.Imprimindo** - Impressão de documentos
- **38.SocketServer** - Servidor Socket
- **39.SocketCliente** - Cliente Socket
- **41.ClienteDeArquivos** - Cliente de transferência de arquivos
- **42.Servidor de Chat** - Servidor de chat TCP
- **43.Client de chat** - Cliente de chat
- **44.HashMd5** - Hashing MD5
- **45.CriptoGuardian** - Criptografia
- **46.AsyncExemplo** - Async/Await
- **47.Lamdba** - Expressões Lambda
- **48.CapturarTeclas** - Captura de eventos de teclado
- **49.GraficosTabela** - Gráficos e tabelas
- **50.RazorFilmes** - Razor Pages

**Stack:** C#, .NET Framework, Windows Forms, Entity Framework, ASP.NET, Socket Programming, GDI+

---

#### **Aulas sobre Struct e ponteiros**
Estudos avançados sobre estruturas e ponteiros em C#.

- **ArraydeStruct** - Arrays de structs
- **Struct Aninhada** - Structs aninhadas
- **Ponteiros e Dados** - Manipulação de ponteiros
- **Manipulando structs** - Manipulação de estruturas
- **Ponteiros** - Conceitos de ponteiros
- **Structs** - Definição e uso de structs

**Stack:** C#, unsafe code, ponteiros

---

#### **Design Patterns**
Implementação dos principais padrões de projeto GoF (Gang of Four).

**Padrões Criacionais:**
- **AbstractFactory** - Famílias de objetos relacionados
- **Builder** - Construção passo a passo de objetos complexos
- **FactoryMethod** - Interface para criação de objetos
- **Prototype** - Clonagem de objetos
- **Singleton** - Instância única global

**Padrões Estruturais:**
- **Adapter** - Adaptação de interfaces incompatíveis
- **Bridge** - Separação de abstração e implementação
- **Composite** - Estruturas em árvore
- **Decorator** - Adição dinâmica de responsabilidades
- **Facade** - Interface simplificada para subsistemas
- **Flyweight** - Compartilhamento eficiente de objetos
- **Proxy** - Representante de outro objeto

**Padrões Comportamentais:**
- **ChainOfResponsability** - Cadeia de processadores
- **Command** - Encapsulamento de requisições
- **Iterator** - Acesso sequencial a coleções
- **Mediator** - Comunicação entre objetos
- **Memento** - Captura e restauração de estado
- **Observer** - Notificação de mudanças
- **State** - Alteração de comportamento baseado em estado
- **Strategy** - Família de algoritmos intercambiáveis
- **Template Method** - Esqueleto de algoritmo

**Stack:** C#, OOP, Design Patterns

---

#### **SOLID**
Implementação dos princípios SOLID de design orientado a objetos.

- **S** - Single Responsibility Principle (Princípio da Responsabilidade Única)
- **O** - Open/Closed Principle (Princípio Aberto/Fechado)
- **L** - Liskov Substitution Principle (Princípio da Substituição de Liskov)
- **I** - Interface Segregation Principle (Princípio da Segregação de Interface)
- **D** - Dependency Inversion Principle (Princípio da Inversão de Dependência)

**Stack:** C#, OOP, Clean Code

---

#### **Azure**
Estudos sobre integração com Microsoft Azure.

**Stack:** C#, Azure SDK, Cloud Computing

---

#### **23. Estudo das Forms**
Aprofundamento em Windows Forms.

**Stack:** C#, Windows Forms, .NET Framework

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Frameworks:** .NET 10.0, .NET Framework, ASP.NET
- **UI:** Windows Forms
- **Dados:** Entity Framework, CSV, JSON, XML
- **Testes:** xUnit, NUnit, ApprovalTests
- **Cloud:** Microsoft Azure
- **Bibliotecas:** CsvHelper, System.Text.Json, HttpClient
- **Conceitos:** OOP, Design Patterns, SOLID, Async/Await, Socket Programming, Multithreading

---

## 📖 Como Usar

Cada pasta contém projetos independentes com seus respectivos arquivos `.csproj` e `.sln`.

Para executar um projeto:

```powershell
cd caminho/do/projeto
dotnet run
```

Para compilar:

```powershell
dotnet build
```

Para executar testes:

```powershell
dotnet test
```

---

## 🎯 Objetivo

Este repositório serve como material de referência e prática para desenvolvimento em C#, cobrindo desde conceitos básicos até padrões arquiteturais avançados.

---

## 📝 Notas

- Os projetos estão organizados de forma progressiva, do básico ao avançado
- Cada subpasta contém exemplos práticos e comentários explicativos
- Ideal para consulta rápida e revisão de conceitos

---

**Desenvolvido como material de estudo pessoal em C# e .NET** 🚀
