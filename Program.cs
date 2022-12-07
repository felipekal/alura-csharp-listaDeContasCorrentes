using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.\n");

#region Exemplos Array em C#
void TestaArray()
{
    int[] vetor = new int[5];

    vetor[0] = 30;
    vetor[1] = 40;
    vetor[2] = 17;
    vetor[3] = 21;
    vetor[4] = 18;

    int contador = 0;

    Console.WriteLine($"Tamanho do vetor: {vetor.Length}");

    for (int i = 0; i < vetor.Length; i++)
    {
        int soma = vetor[i];
        Console.WriteLine($"Contador do índice: {i} + valor da variavel soma: {soma}");
        Console.WriteLine($"Valor da variavel contador: {contador} \n");
        contador += soma;
    }

    int media = contador / vetor.Length;

    Console.WriteLine($"Média das idades: {media}");

}
void TestaBuscarPalavra()
{
    string[] array = new string[5];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Digite a palavra: ");
        array[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra que gostaria de encontrar");
    var busca = Console.ReadLine();

    foreach (var item in array)
    {
        if (item.Equals(busca))
        {
            Console.WriteLine("Palavra Encontrada!");
            break;
        }

    }

}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);


void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array incorreto.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a media = {mediana}");
}

//TestaBuscarPalavra();
//TestaArray();

void TestaArrayDeContasCorrents()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    ContaCorrente contadoAndre = new ContaCorrente(123, "1234-x");

    listaDeContas.Adicionar(contadoAndre);

    Console.WriteLine("------------------------------------------------");

    //listaDeContas.ExibeLista();
    //listaDeContas.Remover(contadoAndre);

    //Console.WriteLine("------------------------------------------------- \n");
    //listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }
}

//TestaArrayDeContasCorrents();
#endregion 

ArrayList _listaDeContas = new ArrayList();
void AtendimentoCliente()
{
    char opcao = '0';
    while(opcao != 6)
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===       Atendimento       ===");
        Console.WriteLine("===1 - Cadastrar Conta      ===");
        Console.WriteLine("===2 - Listar Contas        ===");
        Console.WriteLine("===3 - Remover Conta        ===");
        Console.WriteLine("===4 - Ordenar Contas       ===");
        Console.WriteLine("===5 - Pesquisar Conta      ===");
        Console.WriteLine("===6 - Sair do Sistema      ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];
        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            default:
                Console.WriteLine("Opcao não implementada.");
                break;
        }
    }
}

void CadastrarConta()
{
    throw new NotImplementedException();
}

Console.ReadLine();