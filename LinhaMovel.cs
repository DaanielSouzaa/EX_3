using System;

class LinhaMovel : Linha
{
  private double saldoAtual;
  private string ultMensagem;
  private bool planoDados;
  private bool smsDisponivel;

  public LinhaMovel(string nomeTitular, int numero, int anoContratacao,double saldoAtual,string ultMensagem, bool planoDados,bool smsDisponivel)
  {
    this.nomeTitular = nomeTitular;
    this.numero = numero;
    this.anoContratacao = anoContratacao;
    this.saldoAtual = saldoAtual;
    this.ultMensagem = ultMensagem;
    this.planoDados = planoDados;
    this.smsDisponivel = smsDisponivel;
  }

  public double getSaltoAtual()
  {
    return this.saldoAtual;
  }

  public double getPlanoDadoos()
  {
    return this.saldoAtual;
  }

  public void recarregar(double reais)
  {            
    Console.WriteLine("Recarga efetuada com sucesso: \nSaldo anterior: {0} \nValor recaraga: {1}", this.saldoAtual,reais);
    this.saldoAtual += reais;
    Console.WriteLine("Novo saldo disponível: {0}", this.saldoAtual);
  }

  public void navegar()
  {
    if (this.planoDados)
    {
      Console.WriteLine("Informe a quantidade de dados que você deseja navegar:");
      double mbNavegar = double.Parse(Console.ReadLine());
      double valorDesejado = (mbNavegar / 4) * 0.99;
      if(this.saldoAtual >= valorDesejado)
      {
        this.saldoAtual -= valorDesejado;
        Console.WriteLine("Operação efetuada com sucesso!");
        Console.WriteLine("Saldo disponível: {0}", this.saldoAtual);
      } else
      {
        Console.WriteLine("Você não possui saldo suficiente. \n Por favor, efetue uma recarga!");
      }
    } else
    {
      Console.WriteLine("Serviço indisponível!");
    }
  }

  public void enviarSms()
  {
    if (this.smsDisponivel)
    {
      Console.WriteLine("Informe o número do celular que receberá a mensagem: ");
      int numeroDesti = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe a mensagem que deseja enviar:");
      string mensagem = Console.ReadLine();
      if(saldoAtual >= 0.10)
      {
        saldoAtual -= 0.10;
        this.ultMensagem = mensagem;
        Console.WriteLine("Mensagem enviada com sucesso!");
        Console.WriteLine("Saldo disponível: {0}", this.saldoAtual);
      } else
      {
        Console.WriteLine("Você não possui saldo suficiente. \n Por favor, efetue uma recarga!");
      }
    }
    else
    {
      Console.WriteLine("Serviço indisponível!");
    }
  }
}