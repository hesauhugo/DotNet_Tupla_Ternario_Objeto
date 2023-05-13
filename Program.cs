using DotnetTuplaTernarioObjeto.Models;
var leitor = new LeituraArquivo();
// Descarte de variavel
var (Sucesso, Linhas, _) = leitor.LerArquivo("Arquivo.txt");

if(Sucesso){

    //Console.WriteLine($"Quantidade de linhas lidas: {tupla.QuantidadeLinhas}");
    Console.WriteLine($"Início da leitura");
    Console.WriteLine($"--------------------------------");
    foreach (var item in Linhas)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine($"--------------------------------");
    Console.WriteLine($"Fim da leitura");
}else{
    Console.WriteLine($"Não foi possível efetuar a leitura do arquivo");
}


