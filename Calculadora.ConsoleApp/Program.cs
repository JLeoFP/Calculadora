Console.Clear();

Console.WriteLine("--------------------------");
Console.WriteLine("Bem-vindo à Calculadora Console App!");
Console.WriteLine("--------------------------");

bool continuar = true;

while(continuar)
{  
     Console.WriteLine("Escolha a operação que deseja realizar:");
    Console.WriteLine("1 - soma");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - multiplicação");
    Console.WriteLine("4 - divisão");
    Console.WriteLine("S - sair");
    Console.WriteLine("--------------------------");

    
        
    Console.WriteLine("Escolha uma opção: ");
    string option = Console.ReadLine().ToUpper();

    if(option == "S")
    {   
        Console.WriteLine("Obrigado por usar a Calculadora Console App! Até a próxima!");
        continuar = false;
        break;
    }

    Console.WriteLine("Digite o primeiro número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Digite o segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double resultado = 0;

    switch(option)
    {
        case "1":
            resultado = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("--------------------------");
            break;
        case "2":
            resultado = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine("--------------------------");
            break;
        case "3":
            resultado = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.WriteLine("--------------------------");
            break;
        case "4":
            if(num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine($"O resultado da divisão é: {resultado}");
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                Console.WriteLine("--------------------------");
            }
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            Console.WriteLine("--------------------------");
            break;
    }




}