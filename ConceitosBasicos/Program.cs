byte idade;
string nome;
Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());
Console.WriteLine("olá " + nome + ", A idade informada foi {0}" , idade);