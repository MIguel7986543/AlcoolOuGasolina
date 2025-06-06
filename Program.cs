Console.Clear();

Console.WriteLine("Bem-vindo ao comparador de etanol e gasolina:");
Console.Write("Digite o preço do litro da gasolina: ");

decimal precoGasolina = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço do litro do etanol: ");
decimal precoEtanol = Convert.ToDecimal(Console.ReadLine());

decimal relacao = precoEtanol / precoGasolina;

 decimal razao = calcularRazao(precoEtanol, precoGasolina);
    decimal percentual = razao * 100;

Console.WriteLine($"\nOpreço do etanol corresponde a {percentual:F1}% do preço da gasolina.");

if (ValeAPenaGasolina(relacao))
    Console.WriteLine("\nRecomendação: Abasteça com Gasolina!");
else
    Console.WriteLine("\nRecomendação: Abasteça com Etanol!");

decimal calcularRazao(decimal etanol, decimal gasolina)
{
    return etanol / gasolina;
}

bool ValeAPenaGasolina(decimal relacao)
{
    return relacao > 0.73m;
}