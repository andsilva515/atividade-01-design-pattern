// Interface da Estratégia

public interface IPagamentoStrategy
{
    void Pagar(decimal valor);
}

// Estratégias Concretas

public class PagamentoCartaoCredito : IPagamentoStrategy
{
    public void Pagar(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} realizado com Cartão de Crédito.");
    }
}

public class PagamentoPayPal : IPagamentoStrategy
{
    public void Pagar(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} realizado via PayPal.");
    }
}

public class PagamentoBoleto : IPagamentoStrategy
{
    public void Pagar(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} realizado com Boleto Bancário.");
    }
}

// Contexto

public class ProcessadorPagamento
{
    private IPagamentoStrategy _estrategia;

    public void DefinirEstrategia(IPagamentoStrategy estrategia)
    {
        _estrategia = estrategia;
    }

    public void RealizarPagamento(decimal valor)
    {
        if (_estrategia == null)
        {
            Console.WriteLine("Nenhuma estratégia de pagamento definida.");
            return;
        }

        _estrategia.Pagar(valor);
    }
}

// Exemplo de Uso

class Program
{
    static void Main(string[] args)
    {
        var processador = new ProcessadorPagamento();

        processador.DefinirEstrategia(new PagamentoCartaoCredito());
        processador.RealizarPagamento(150.00m);

        processador.DefinirEstrategia(new PagamentoPayPal());
        processador.RealizarPagamento(200.00m);

        processador.DefinirEstrategia(new PagamentoBoleto());
        processador.RealizarPagamento(100.00m);
    }
}

