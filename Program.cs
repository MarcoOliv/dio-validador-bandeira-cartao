using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número do cartão: ");
        string numeroCartao = Console.ReadLine() ?? string.Empty;

        string bandeira = IdentificarBandeira(numeroCartao);

        Console.WriteLine($"Bandeira identificada: {bandeira}");
    }

    static string IdentificarBandeira(string numeroCartao)
    {
        string numero = Regex.Replace(numeroCartao, @"\D", "");

        if (string.IsNullOrWhiteSpace(numero))
            return "Número inválido";

        if (Regex.IsMatch(numero, @"^4\d{12}(?:\d{3})?(?:\d{3})?$"))
            return "Visa";

        if (Regex.IsMatch(numero, @"^(5[1-5]\d{14}|2(2[2-9][1-9]|2[3-9]\d{2}|[3-6]\d{3}|7[01]\d{2}|720\d)\d{12})$"))
            return "MasterCard";

        if (Regex.IsMatch(numero, @"^3[47]\d{13}$"))
            return "American Express";

        if (Regex.IsMatch(numero, @"^(4011(78|79)|431274|438935|451416|457393|4576(31|32)|504175|506(699|7[0-6]\d)|509\d{3}|627780|636297|636368|650\d{3}|6516\d{2}|6550\d{2})\d+$"))
            return "Elo";

        if (Regex.IsMatch(numero, @"^606282\d+$"))
            return "Hipercard";

        return "Bandeira desconhecida";
    }
}
