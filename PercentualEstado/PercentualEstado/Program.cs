using System;

class Program
{
    static void Main(string[] args)
    {
        // Valores de faturamento por estado
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        // Cálculo do faturamento total
        double faturamentoTotal = sp + rj + mg + es + outros;

        // Cálculo do percentual de representação de cada estado
        double percentualSP = (sp / faturamentoTotal) * 100;
        double percentualRJ = (rj / faturamentoTotal) * 100;
        double percentualMG = (mg / faturamentoTotal) * 100;
        double percentualES = (es / faturamentoTotal) * 100;
        double percentualOutros = (outros / faturamentoTotal) * 100;

        // Impressão dos resultados
        Console.WriteLine("Percentual de representação de cada estado no faturamento total:");
        Console.WriteLine("SP: {0:F2}%", percentualSP);
        Console.WriteLine("RJ: {0:F2}%", percentualRJ);
        Console.WriteLine("MG: {0:F2}%", percentualMG);
        Console.WriteLine("ES: {0:F2}%", percentualES);
        Console.WriteLine("Outros: {0:F2}%", percentualOutros);
    }
}
