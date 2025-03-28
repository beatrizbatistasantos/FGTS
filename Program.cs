decimal salario = 0, fgts = 0;

Console.WriteLine("Olá, digite o salário do seu funcionário:");
salario = Convert.ToDecimal(Console.ReadLine()!);

fgts = (salario/100) * 8;

Console.WriteLine($"\nSalário (R$)..:{salario:N2}");
Console.Write($"\nFGTS:R$ {fgts :N2}");