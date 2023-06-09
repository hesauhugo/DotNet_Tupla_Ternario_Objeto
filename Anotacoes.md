 
## Tupla simples

```csharp

    (int,string,string,decimal) tupla = (1,"Enzo","Gabriel",1.80M);

    Console.WriteLine($"Id: {tupla.Item1}");
    Console.WriteLine($"Nome: {tupla.Item2}");
    Console.WriteLine($"SobreNome: {tupla.Item3}");
    Console.WriteLine($"Altura: {tupla.Item4}");

```

## Tupla Nomeada

```csharp

    (int Id,string Nome,string Sobrenome , decimal Altura) tupla = (1,"Enzo","Gabriel",1.80M);

    Console.WriteLine($"Id: {tupla.Id}");
    Console.WriteLine($"Nome: {tupla.Nome}");
    Console.WriteLine($"SobreNome: {tupla.Sobrenome}");
    Console.WriteLine($"Altura: {tupla.Altura}");

```

## Tupla (Value Tuple)

```csharp

    ValueTuple<int,string,string,decimal> tupla = (1,"Enzo","Gabriel",1.80M);
    Console.WriteLine($"Id: {tupla.Item1}");
    Console.WriteLine($"Nome: {tupla.Item2}");
    Console.WriteLine($"SobreNome: {tupla.Item3}");
    Console.WriteLine($"Altura: {tupla.Item4}");

```

## Tupla (Tuple.Create)

```csharp

    var tupla = Tuple.Create(1,"Enzo","Gabriel",1.80M);
    Console.WriteLine($"Id: {tupla.Item1}");
    Console.WriteLine($"Nome: {tupla.Item2}");
    Console.WriteLine($"SobreNome: {tupla.Item3}");
    Console.WriteLine($"Altura: {tupla.Item4}");
    
```
## Tupla em Métodos

* Exemplo de método com tupla
```csharp

        public (bool Sucesso,string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho){
            // seu código aqui;
        }
    
```
* Exemplo do retorno da tupla
```csharp

        var (Sucesso, Linhas, QunatidadeLinhas) = LerArquivo("Arquivo.txt")
    
```
* Exemplo de descarte de variáveis
```csharp

        var (Sucesso, Linhas, _) = LerArquivo("Arquivo.txt")
    
```

* Program (Codigo completo)
```csharp

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
```


## Desconstrutor

* Na classe Pessoa

```csharp
        public void Deconstruct( out string nome, out string sobrenome){
            nome = Nome;
            sobrenome  = Sobrenome;
        }
```

* Na Program
```csharp
    Pessoa p1 = new Pessoa("Enzo","Gabriel");
    (string nome, string sobrenome)  = p1;
    Console.WriteLine($"{nome} {sobrenome}");
```

## Ternário

```csharp
    int numero = 15;
    bool ehPar = false;

    // if ternario
    ehPar = numero % 2 ==0;
    Console.WriteLine($" O número {numero} é " + (ehPar ? "par":"impar"));
```
