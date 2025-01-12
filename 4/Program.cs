float sp = 67836.43f;
float rj = 36678.66f;
float mg = 29228.88f;
float es = 27165.48f;
float outros = 19849.53f;

float total = sp + rj + mg + es + outros;

Console.WriteLine("Percentual de faturamento por estado: ");

Console.WriteLine("sp: "+((sp/total)*100)+"%");
Console.WriteLine("rj: " + ((rj / total) * 100) + "%");
Console.WriteLine("mg: " + ((mg / total) * 100) + "%");
Console.WriteLine("es: " + ((es / total) * 100) + "%");
Console.WriteLine("outros: " + ((outros / total) * 100) + "%");
