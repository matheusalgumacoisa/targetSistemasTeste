using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


string jsonContent = File.ReadAllText("dados.json");

List<Item> items = JsonSerializer.Deserialize<List<Item>>(jsonContent);

int diasUteis = 0;
float totalFaturado = 0f;
int menorDiaFaturado = 1;
int maiorDiaFaturado = 1;
float menorFaturamento = items[0].valor;
float maiorFaturamento = items[0].valor;


foreach (Item item in items)
{

    if (item.valor > 0) { 
        diasUteis++;
        totalFaturado += item.valor;

        if (item.valor < menorFaturamento) {
            menorDiaFaturado = item.dia;
            menorFaturamento = item.valor;
        }

        if (item.valor > maiorFaturamento)
        {
            maiorDiaFaturado = item.dia;
            maiorFaturamento = item.valor;
        }
    }
}

Console.WriteLine("Total faturado: R$"+totalFaturado);
Console.WriteLine("Media diária: R$" +totalFaturado/diasUteis);
Console.WriteLine("Menor faturamento: dia " + menorDiaFaturado);
Console.WriteLine("Maior faturamento: dia " + maiorDiaFaturado);


public class Item
{
    public int dia { get; set; }
    public float valor { get; set; }
}
