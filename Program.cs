Console.Clear();
decimal salario = 0 ; const decimal porcentagemfgts = 0.08m;


Console.WriteLine("Olá, digite o salário do seu funcionário:");
salario = Convert.ToDecimal(Console.ReadLine()!);

decimal valorfgts = salario * porcentagemfgts;

Console.WriteLine($"\nSalário (R$)..:{salario:N2}");
Console.Write($"\nFGTS: {valorfgts:C2}");
