using System;

// (Nota mental): NÃO tentar dar um 'new Carro()' direto, 
// senão o universo entra em colapso (e o compilador do C# também). Rs
public abstract class Carro
{
    public string NumeroChassi { get; set; }
    public string NumeroMotor { get; set; }
    public double CustoProducao { get; set; }

    protected abstract double PercentualImposto { get; }
    protected double PercentualLucro = 0.25;

    public double CalcularCustoVenda()
    {
        // Cálculo conforme  o enunciado: Custo + Imposto + Lucro
        double valorImposto = CustoProducao * PercentualImposto;
        double valorLucro = CustoProducao * PercentualLucro;
        return CustoProducao + valorImposto + valorLucro;
    }
}

public class CarroFlex : Carro
{
    public int NumeroPortas { get; set; }
    public int Cilindrada { get; set; }
    protected override double PercentualImposto => 0.20; // 20%
}

public class CarroDiesel : Carro
{
    public double CapacidadeCarga { get; set; }
    public double VolumeCacamba { get; set; }
    protected override double PercentualImposto => 0.30; // 30%
}

public class CarroEletrico : Carro
{
    public double Potencia { get; set; }
    public double DuracaoBateria { get; set; }
    protected override double PercentualImposto => 0.10; // 10%
}

public class ExecucaoFabrica
{
    public static void Main()
    {
        double custoBase = 50000.00;

        // Instanciando os veículos
        CarroFlex meuFlex = new CarroFlex { CustoProducao = custoBase };
        CarroDiesel meuDiesel = new CarroDiesel { CustoProducao = custoBase };
        CarroEletrico meuEletrico = new CarroEletrico { CustoProducao = custoBase };

        // Exibição dos resultados
        Console.WriteLine("--- Tabela de Preços de Venda (Adisra) ---");
        Console.WriteLine($"Custo de Produção Base: R$ {custoBase:F2}\n");

        Console.WriteLine($"Carro Flex (Imposto 20%): R$ {meuFlex.CalcularCustoVenda():F2}");
        Console.WriteLine($"Carro Diesel (Imposto 30%): R$ {meuDiesel.CalcularCustoVenda():F2}");
        Console.WriteLine($"Carro Elétrico (Imposto 10%): R$ {meuEletrico.CalcularCustoVenda():F2}");
    }
}