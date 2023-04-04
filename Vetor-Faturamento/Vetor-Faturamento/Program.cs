using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Importa os dados do arquivo XML
        var dadosXml = XElement.Load("dados.xml");

        // Cria um array para armazenar os valores de faturamento diário
        double[] faturamentos = dadosXml.Elements("row").Select(r => (double)r.Element("valor")).ToArray();

        // Calcula o menor e o maior valor de faturamento
        double menorFaturamento = faturamentos.Min();
        double maiorFaturamento = faturamentos.Max();

        // Calcula a média mensal
        double mediaMensal = faturamentos.Where(f => f > 0).Average();

        // Calcula o número de dias em que o faturamento diário foi superior à média mensal
        int diasAcimaDaMedia = faturamentos.Count(f => f > mediaMensal);

        // Imprime os resultados
        Console.WriteLine("Menor faturamento: " + menorFaturamento);
        Console.WriteLine("Maior faturamento: " + maiorFaturamento);
        Console.WriteLine("Dias com faturamento acima da média mensal: " + diasAcimaDaMedia);
    }
}
