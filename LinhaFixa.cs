using System;

class LinhaFixa : Linha
{
  private double valorMensalidade;
  private double franquiaMes;
  private double valorRestante;
  private bool faturaPaga;


  public LinhaFixa(string nomeTitular,int numero,int anoContratacao,double valorMensalidade, double franquiaMes,double valorRestante,bool faturaPaga)
  {
    this.nomeTitular = nomeTitular;
    this.numero = numero;
    this.anoContratacao = anoContratacao;
    this.valorMensalidade = valorMensalidade;
    this.franquiaMes = franquiaMes;
    this.valorRestante = valorRestante;
    this.faturaPaga = faturaPaga;
  }

  public double getValorMensalidade()
  {
    return this.valorMensalidade;
  }

  public double getFranquiaMes()
  {
    return this.franquiaMes;
  }

  public double getValorRestante()
  {
    return this.valorRestante;
  }

  public void ligar(double minutos)
  {
    if(this.valorRestante >= minutos)
    {
      if (this.faturaPaga)
      {
        this.valorRestante -= minutos;
        Console.WriteLine("Ligação efetuada com sucesso!");
        Console.WriteLine("Minutos restantes: {0}", this.valorRestante);
      } else
      {
        Console.WriteLine("Operação cancelada por fala de pagamento da fatura!");
      }
    } else
    {
      Console.WriteLine("Você não possui minutos para essa operação!");
    }
  }

  public void pagarFatura()
  {
    this.valorRestante = this.franquiaMes;
    this.faturaPaga = true;
  }
}