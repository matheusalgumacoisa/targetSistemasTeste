Console.WriteLine("Entre com uma string");
string s =  Console.ReadLine();
string aux = "";

for (int i = s.Length-1; i >= 0; i--){
    aux += s[i];
}

Console.WriteLine("String invertida: "+aux);
