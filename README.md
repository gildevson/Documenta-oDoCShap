blocos de código e emojis mantidos.
Ela vai ficar linda no GitHub! 💪

# 🧩 🔤 Funções de String Mais Importantes em C#

## 📏 1️⃣ Length
Retorna o número de caracteres da string.

```csharp
string nome = "Gilson";
Console.WriteLine(nome.Length); // 6

✂️ 2️⃣ Substring

Retorna parte da string (a partir de um índice).

string texto = "Programador";
Console.WriteLine(texto.Substring(0, 4)); // "Prog"
Console.WriteLine(texto.Substring(4));    // "ramador"

🔠 3️⃣ ToUpper() / ToLower()

Converte a string para maiúsculas ou minúsculas.

string nome = "Gilson";
Console.WriteLine(nome.ToUpper()); // "GILSON"
Console.WriteLine(nome.ToLower()); // "gilson"

🔍 4️⃣ Contains()

Verifica se um trecho existe na string.

string frase = "Aprendendo C#";
Console.WriteLine(frase.Contains("C#"));   // true
Console.WriteLine(frase.Contains("Java")); // false

🧭 5️⃣ StartsWith() / EndsWith()

Verifica se começa ou termina com determinado texto.

string palavra = "Programação";
Console.WriteLine(palavra.StartsWith("Pro")); // true
Console.WriteLine(palavra.EndsWith("ção"));   // true

🔁 6️⃣ Replace()

Substitui partes do texto.

string frase = "Eu gosto de Java";
Console.WriteLine(frase.Replace("Java", "C#")); // "Eu gosto de C#"

🚿 7️⃣ Trim() / TrimStart() / TrimEnd()

Remove espaços (ou caracteres específicos) do início/fim.

string nome = "  Gilson  ";
Console.WriteLine(nome.Trim());      // "Gilson"
Console.WriteLine(nome.TrimStart()); // "Gilson  "
Console.WriteLine(nome.TrimEnd());   // "  Gilson"

🔗 8️⃣ Split()

Divide a string em partes e retorna um vetor.

string frutas = "maçã,banana,laranja";
string[] partes = frutas.Split(',');
Console.WriteLine(partes[1]); // "banana"

🧩 9️⃣ Join()

Junta várias strings com um separador.

string[] nomes = { "Gilson", "Ana", "Carlos" };
string resultado = string.Join(", ", nomes);
Console.WriteLine(resultado); // "Gilson, Ana, Carlos"

🧮 🔟 IndexOf() / LastIndexOf()

Retorna o índice (posição) de um caractere ou texto.

string texto = "banana";
Console.WriteLine(texto.IndexOf("a"));     // 1
Console.WriteLine(texto.LastIndexOf("a")); // 5

🔧 11️⃣ Insert()

Insere texto em uma posição específica.

string palavra = "Hello";
Console.WriteLine(palavra.Insert(5, " World")); // "Hello World"

✂️ 12️⃣ Remove()

Remove caracteres a partir de um índice.

string palavra = "Programação";
Console.WriteLine(palavra.Remove(4));    // "Prog"
Console.WriteLine(palavra.Remove(4, 3)); // "Progção"

🔢 13️⃣ PadLeft() / PadRight()

Adiciona espaços ou caracteres até atingir um tamanho.

string numero = "7";
Console.WriteLine(numero.PadLeft(3, '0'));  // "007"
Console.WriteLine(numero.PadRight(5, '*')); // "7****"

🔤 14️⃣ ToCharArray()

Converte a string em vetor (char[]).

string palavra = "C#";
char[] letras = palavra.ToCharArray(); // ['C', '#']

⚖️ 15️⃣ Equals()

Compara duas strings (com ou sem case-sensitive).

string a = "CSharp";
string b = "csharp";
Console.WriteLine(a.Equals(b)); // false
Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true

🧠 16️⃣ IsNullOrEmpty() / IsNullOrWhiteSpace()

Verifica se uma string está vazia ou nula.

string texto1 = "";
string texto2 = "   ";
Console.WriteLine(string.IsNullOrEmpty(texto1));      // true
Console.WriteLine(string.IsNullOrWhiteSpace(texto2)); // true

📘 17️⃣ Format() / Interpolação

Monta texto com variáveis.

string nome = "Gilson";
int idade = 28;

Console.WriteLine(string.Format("Meu nome é {0} e tenho {1} anos.", nome, idade));
Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos."); // interpolação

🧩 18️⃣ Compare()

Compara duas strings e retorna um número:

0 → iguais

<0 → primeira vem antes

>0 → primeira vem depois

Console.WriteLine(string.Compare("abc", "abd")); // -1
Console.WriteLine(string.Compare("abc", "abc")); // 0

🔗 19️⃣ Concat()

Junta duas ou mais strings.

string resultado = string.Concat("Olá", " ", "Mundo!");
Console.WriteLine(resultado); // "Olá Mundo!"

🧱 20️⃣ Normalize()

Normaliza acentuação (útil pra comparar textos com acentos).

string texto = "ação";
Console.WriteLine(texto.Normalize());

🧠 Dica de Memorização
Prefixo	Indica	Exemplo
To...	Conversão	ToUpper, ToLower, ToCharArray
Is...	Verificação	IsNullOrEmpty, IsNullOrWhiteSpace
Index...	Posição	IndexOf, LastIndexOf
Pad...	Ajuste de tamanho	PadLeft, PadRight
Trim...	Limpeza	Trim, TrimStart, TrimEnd
⚙️ Resumo dos Mais Usados no Dia a Dia

✅ ToUpper(), ToLower()
✅ Contains(), Replace()
✅ Trim()
✅ Split(), Join()
✅ Substring()
✅ IndexOf()
✅ Length
✅ IsNullOrEmpty()


---

Quer que eu gere um **README.md visual com ícones de linguagem, títulos coloridos e uma tabela resumida de
