//Sempre chamar Soma antes da static 
Menu();

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float resultado = valor1 + valor2;
    //essas são duas formas de mostrar o resultado na tela.
    Console.WriteLine("O resultado da soma é: " + resultado);
    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float resultado = valor1 - valor2;
    //Novamente mostrando dois resultados para a aprensetação na tela.
    Console.WriteLine("O Resultado da subtração é: " + resultado);
    Console.WriteLine($"O Resultado da subtração é: {resultado}");
    Console.ReadKey(); // Funçaõ para não parar o programa!
    Menu();
}       

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float resultado = valor1 / valor2;
    //Novamente mostrando dois resultados para a aprensetação na tela.
    Console.WriteLine("O Resultado da subtração é: " + resultado);
    Console.WriteLine($"O Resultado da subtração é: {resultado}");
    Console.ReadKey(); // Funçaõ para não parar o programa!
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = valor1 * valor2;
    //Novamete mostrando dois resultados!
    Console.WriteLine("O resultado da multiplicação é: " + resultado);
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.ReadKey(); //Função para não parar a tela de execução!
    Menu();
}

static void Menu()
{
    Console.Clear();

    Console.WriteLine("O que deseja calcular: ");
    Console.WriteLine("1 - SOMA");
    Console.WriteLine("2 - SUBTRAÇÃO");
    Console.WriteLine("3 - DIVISÃO");
    Console.WriteLine("4 - DIVISÃO");
    Console.WriteLine("5 - SAIR");

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Selecione uma opção: ");
    
    short res = short.Parse(Console.ReadLine());

    switch(res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break; //função para sair do sistema.
        default: Menu(); break;
    }
}


