abstract class Linha
{
  protected string nomeTitular;
  protected int numero;
  protected int anoContratacao;

  public string getNomeTitular()
  {
      return this.nomeTitular;
  }
  public int getNumero()
  {
      return this.numero;
  }
  public int getAnoContratacao()
  {
      return this.anoContratacao;
  }
}