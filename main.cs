using System;

class Program {
  public static void Main (string[] args) {
    LinhaFixa lf1 = new LinhaFixa("Daniel1", 123451, 2021, 65, 200, 200, true);
    LinhaFixa lf2 = new LinhaFixa("Daniel2", 123452, 2021, 65, 200, 200, false);

    LinhaMovel lm1 = new LinhaMovel("Daniel3",1234563,2021,75,"",true,false);
    LinhaMovel lm2 = new LinhaMovel("Daniel4", 1234564, 2021, 75, "", false, true);
    LinhaMovel lm3 = new LinhaMovel("Daniel5", 1234565, 2021, 75, "", true, true);
    LinhaMovel lm4 = new LinhaMovel("Daniel6", 1234566, 2021, 75, "", false, false);

    lf1.ligar(25);
    Console.WriteLine(lf1.getValorRestante());
    Console.WriteLine("----------------------------");
    lf2.ligar(25);
    lf2.pagarFatura();
    lf2.ligar(215);
    Console.WriteLine(lf2.getValorRestante());
    Console.WriteLine("----------------------------");
    lm1.enviarSms();
    lm1.getSaltoAtual();
    lm1.navegar();
    lm1.getSaltoAtual();
    lm1.recarregar(85);
    Console.WriteLine("----------------------------");
    lm2.navegar();
    Console.WriteLine("----------------------------");
    lm3.enviarSms();
  }
}