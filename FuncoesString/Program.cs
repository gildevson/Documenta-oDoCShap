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
        }
    }
}
