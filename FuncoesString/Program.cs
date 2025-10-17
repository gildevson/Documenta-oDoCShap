namespace FuncoesString
{
    class TestClass
    {
        public static void Main(String[] args)
        {
            string frase = "Eu sou da FINANBLUE eu gosto de programar no desenvolvimento";
            string fraseMenor = "desenvolvedor";

            /*RETORNA UM VETOR */
            string splitParaVetor = "maça, banana, laranja";
            string[] partes = splitParaVetor.Split(',');
            Console.WriteLine("Split ele divite a string em partes e retorna um vetor: " + partes[1]); // banana

            Console.WriteLine("Length conta números de caracteres: " + frase.Length); //
            Console.WriteLine(frase + " usando Substring(0,2): " + frase.Substring(0,2)); // eu
            Console.WriteLine("Usando ToUpper(): " + frase.ToUpper().Substring(0,2)); // ToUpper() mistando com substring
            Console.WriteLine("Usando ToLower(): " + frase.ToLower().Substring(0, 2)); // ToLower( ele) ele mostra se letra minusculas
            Console.WriteLine("Usando Contains() ele server para ver se um trecho existe: " + frase.Contains("programar"));
            Console.WriteLine("StarsWith: " + fraseMenor.StartsWith("desenv")); // pega do começo da String
            Console.WriteLine("EndWith: " + fraseMenor.EndsWith("dor")); // pega o final da String
            Console.WriteLine("Replace substitui parte dos texto" + frase.Replace("FINANBLUE","LiveWork")); //  SUBSTITUI DA ESQUERDA("FINANBLUE") PELA DIREITA("LiveWork").

            string[] listaJoin = {"Gilson", "Ana", "Carlos"};
            string resultadoJoin = string.Join(", ", listaJoin);
            
            Console.WriteLine("Join() junta várias strings com um separador: " + resultadoJoin);



            
        }
    }
}
