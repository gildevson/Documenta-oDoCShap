# 🧩 Funções de String em C#

As strings em C# possuem diversos métodos úteis para manipular textos.  
Abaixo estão as funções mais utilizadas e que caem com frequência em testes técnicos e no dia a dia de desenvolvimento.

---

## 📏 Propriedades e Métodos Principais

| Método / Propriedade | Descrição | Exemplo | Resultado |
|-----------------------|------------|----------|------------|
| `Length` | Retorna o número de caracteres | `"Finanblue".Length` | `9` |
| `ToUpper()` | Converte para letras maiúsculas | `"finanblue".ToUpper()` | `FINANBLUE` |
| `ToLower()` | Converte para letras minúsculas | `"FINANBLUE".ToLower()` | `finanblue` |
| `Substring(início, comprimento)` | Extrai parte da string | `"Finanblue".Substring(0, 5)` | `Finan` |
| `Contains("texto")` | Verifica se contém o texto | `"Finanblue".Contains("blue")` | `true` |
| `StartsWith("texto")` | Verifica se começa com o texto | `"Finanblue".StartsWith("Fin")` | `true` |
| `EndsWith("texto")` | Verifica se termina com o texto | `"Finanblue".EndsWith("blue")` | `true` |
| `IndexOf("texto")` | Retorna a posição do primeiro caractere encontrado | `"Finanblue".IndexOf("b")` | `5` |
| `LastIndexOf("texto")` | Retorna a posição da última ocorrência | `"banana".LastIndexOf("a")` | `5` |
| `Replace("antigo", "novo")` | Substitui um texto por outro | `"Finanblue".Replace("blue", "bank")` | `Finanbank` |
| `Trim()` | Remove espaços no início e no fim | `"  Gilson  ".Trim()` | `Gilson` |
| `Split(' ')` | Divide a string em partes (array) | `"Eu gosto de C#".Split(' ')` | `["Eu", "gosto", "de", "C#"]` |
| `Join(" ", array)` | Junta elementos de um array em uma string | `String.Join(" ", new[] {"Eu", "gosto", "C#"})` | `Eu gosto C#` |
| `Equals("texto")` | Compara duas strings | `"teste".Equals("teste")` | `true` |
| `Insert(pos, "texto")` | Insere texto em uma posição específica | `"1234".Insert(2, "X")` | `12X34` |
| `Remove(pos, qtd)` | Remove caracteres a partir da posição informada | `"123456".Remove(2, 3)` | `126` |
| `PadLeft(tam, '0')` | Preenche com caracteres à esquerda | `"45".PadLeft(5, '0')` | `00045` |
| `PadRight(tam, '.')` | Preenche com caracteres à direita | `"Gil".PadRight(5, '.')` | `Gil..` |

---

## 💻 Exemplo Completo em C#

```csharp
using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Eu sou da FINANBLUE e gosto de programar";

            Console.WriteLine("📏 Tamanho: " + frase.Length);
            Console.WriteLine("🔠 Maiúscula: " + frase.ToUpper());
            Console.WriteLine("🔡 Minúscula: " + frase.ToLower());
            Console.WriteLine("🧩 Substring: " + frase.Substring(7, 10));
            Console.WriteLine("🔎 Contém 'FINANBLUE'? " + frase.Contains("FINANBLUE"));
            Console.WriteLine("💬 Replace: " + frase.Replace("FINANBLUE", "FINANBANK"));
            Console.WriteLine("✂️ Trim: '" + "  Gilson  ".Trim() + "'");
            Console.WriteLine("➡️ PadLeft: " + "45".PadLeft(5, '0'));
            Console.WriteLine("⬅️ PadRight: " + "Gil".PadRight(5, '.'));
        }
    }
}
