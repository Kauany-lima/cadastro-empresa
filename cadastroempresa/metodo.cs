using cadastroempresa;
using System;
using System.Net.Http.Headers;
using System.Windows.Forms;

public class Metodos
{
    public string cnpj { get; set; }
    public string razaosocial { get; set; }
    public string nomefan { get; set; }
    public DateTime data { get; set; }
    public double capitalsocial { get; set; }
    public string telefone { get; set; }
    public string endereco { get; set; }
    public string cidade { get; set; }
    public string bairro { get; set; }
    public string rua { get; set; }
    public int numero { get; set; }
    public string Regimetributario { get; set; }
    public string tipo { get; set; }
    public string porte { get; set; }
    public string natureza { get; set; }
    public string nomeproprietario { get; set; }
    public string cpf { get; set; }
    public string situacao { get; set; }
  
}

public static class Valida
{
    public static bool Validacao(string cpf)
    {
        Metodos cl = new Metodos();
        cl.cpf = cpf;
        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        string tempCpf;
        string digito;
        int soma;
        int resto;
        cpf = cpf.Trim();
        cpf = cpf.Replace(".", "").Replace("-", "");
        if (cpf.Length != 11)
            return false;
        tempCpf = cpf.Substring(0, 9);
        soma = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
        resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;
        digito = resto.ToString();
        tempCpf = tempCpf + digito;
        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
        resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;
        digito = digito + resto.ToString();
        return cpf.EndsWith(digito);
    }
}

