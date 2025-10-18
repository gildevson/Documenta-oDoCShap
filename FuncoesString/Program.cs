using System;

namespace FuncoesString
{
    class TestClass
    {
        public static void Main(String[] args)
        {
            string frase = "Eu sou da FINANBLUE eu gosto de programar no desenvolvimento";
            string fraseMenor = "desenvolvedor";

            Console.WriteLine("===== 🔤 EXEMPLOS DE FUNÇÕES DE STRING EM C# =====\n");

            // LENGTH
            Console.WriteLine($"➡️ Length (conta número de caracteres): {frase.Length}");

            // SUBSTRING
            Console.WriteLine($"➡️ Substring(0, 2): {frase.Substring(0, 2)}");

            // TOUPPER e TOLOWER
            Console.WriteLine($"➡️ ToUpper() + Substring(0, 2): {frase.ToUpper().Substring(0, 2)}");
            Console.WriteLine($"➡️ ToLower() + Substring(0, 2): {frase.ToLower().Substring(0, 2)}");

            // CONTAINS
            Console.WriteLine($"➡️ Contains('programar'): {frase.Contains("programar")}");

            // STARTSWITH / ENDSWITH
            Console.WriteLine($"➡️ StartsWith('desenv'): {fraseMenor.StartsWith("desenv")}");
            Console.WriteLine($"➡️ EndsWith('dor'): {fraseMenor.EndsWith("dor")}");

            // REPLACE
            Console.WriteLine($"➡️ Replace('FINANBLUE', 'LiveWork'): {frase.Replace("FINANBLUE", "LiveWork")}");

            // SPLIT
            string splitParaVetor = "maça, banana, laranja";
            string[] partes = splitParaVetor.Split(',');
            Console.WriteLine($"➡️ Split(',') -> vetor[1]: {partes[1].Trim()}");

            // JOIN
            string[] listaJoin = { "Gilson", "Ana", "Carlos" };
            string resultadoJoin = string.Join(", ", listaJoin);
            Console.WriteLine($"➡️ Join(', '): {resultadoJoin}");

            // PADLEFT e PADRIGHT
            Console.WriteLine($"➡️ PadLeft(5, '0') em '45': {"45".PadLeft(5, '0')}");
            Console.WriteLine($"➡️ PadRight(6, '.') em 'Gil': {"Gil".PadRight(6, '.')}");

            // TRIM
            Console.WriteLine($"➡️ Trim() remove espaços extras: '{("  Gilson  ".Trim())}'");

            Console.WriteLine("\n===== ✅ FIM DOS EXEMPLOS =====");

            // IndexOf()
            Console.WriteLine($"➡️ IndexOf('gosto'): {frase.IndexOf("gosto")}");

            string texto = "Banana";
            Console.WriteLine(texto.IndexOf("a") + " ele retorna o indice a qual for primeiro no caso foi a = Banana");
            Console.WriteLine(texto.LastIndexOf("a") + " ele retorna o indice a qual for o ultimo a = Banana");

            string textodois = "Ejs";
            Console.WriteLine(textodois.Insert(3, " Finanblue")); //ele insere a palavra na posição que eu determinar


            // PADLEFT e PADRIGHT
            string textoNumero = "7";
            Console.WriteLine(textoNumero.PadLeft(3, '0')); //Adiciona espaços ou caracteres até atingir um tamanho.
            Console.WriteLine(textoNumero.PadLeft(5, '0'));
            Console.WriteLine(textoNumero.PadLeft(3, 'A'));


            // ToCharArray()
            string palavra = "C#";
            char[] letras = palavra.ToCharArray(); // ['C', '#']



            //15️⃣ Equals()
            //Compara duas strings(com ou sem case -sensitive).
            string a = "CSharp";
            string b = "csharp";
            Console.WriteLine(a.Equals(b)); // false
            Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true

            //IsNullOrEmpty() / IsNullOrWhiteSpace()
            //Verifica se uma string está vazia ou nula.
            string texto1 = "";
            string texto2 = "   ";
            Console.WriteLine(string.IsNullOrEmpty(texto1));      // true
            Console.WriteLine(string.IsNullOrWhiteSpace(texto2)); // true

            //📘 17️⃣ Format() / Interpolação
            //Monta texto com variáveis.

            string nome = "Gilson";
            int idade = 28;

            Console.WriteLine(string.Format("Meu nome é {0} e tenho {1} anos.", nome, idade));
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos."); // interpolação

            //🧩 18️⃣ Compare()
            //Compara duas strings e retorna um número:
            //0 → iguais
            //<0 → primeira vem antes
            //>0 → primeira vem depois

            Console.WriteLine(string.Compare("abc", "abd")); // -1
            Console.WriteLine(string.Compare("abc", "abc")); // 0

            //🔗 19️⃣ Concat()
            //Junta duas ou mais strings.

            string resultado = string.Concat("Olá", " ", "Mundo!");
            Console.WriteLine(resultado); // "Olá Mundo!"

            //🧱 20️⃣ Normalize()
            //Normaliza acentuação (útil pra comparar textos com acentos).

            string texto = "ação";
            Console.WriteLine(texto.Normalize());




        }
    }
}
