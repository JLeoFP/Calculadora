//Console.Clear();

string[] historicoOpe = new string[100];
int totalOpe = 0;

bool continuar = true;

while(continuar)
{   
    Console.WriteLine("--------------------------");
    Console.WriteLine("Bem-vindo à Calculadora Console App!");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Escolha a operação que deseja realizar:");
    Console.WriteLine("1 - soma");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - multiplicação");
    Console.WriteLine("4 - divisão");
    Console.WriteLine("5 - Operacion tabuada");
    Console.WriteLine("6 - Historico de operações");
    Console.WriteLine("S - sair");
    Console.WriteLine("--------------------------");

    
        
    Console.WriteLine("Escolha uma opção: ");
    string? option = Console.ReadLine()?.ToUpper();              // Uso de ? :  if str > upper, else null.

    if(option == "5")
    {
        Console.WriteLine("Digite o numero para a tabuda:");
            string? strNumTabuada = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(strNumTabuada))
            {
                decimal numTabuada = Convert.ToDecimal(strNumTabuada);
                Console.WriteLine($"Tabuada do {numTabuada}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numTabuada} x {i} = {numTabuada * i}");
                }
                
            }
            else
            {
                Console.WriteLine("Erro: Por favor, insira um valor numérico válido.");
            }
            Console.WriteLine("--------------------------");
        continue;    
    }
    
    if(option == "6")
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Historico de operações:");
        Console.WriteLine("--------------------------");
        if (totalOpe == 0)
        {
            Console.WriteLine("Nenhuma operação realizada ainda.");
        }
        else
        {
            for (int i = 0; i < totalOpe; i++)
            {
                Console.WriteLine(historicoOpe[i]);
            }
        }
      Console.ReadLine();
      continue;  
    }

    if(option == "S")
    {   
        Console.WriteLine("Obrigado por usar a Calculadora Console App! Até a próxima!");
        continuar = false;
        return;
    }

    Console.WriteLine("Digite o primeiro número: ");        
    string? strNum1 = (Console.ReadLine());         //string? <- string ou null
    Console.WriteLine("Digite o segundo número: ");
    string? strNum2 = (Console.ReadLine());

    //                                       vefica se os valores nao e null

    bool validNum1 = string.IsNullOrEmpty(strNum1);
    bool validNum2 = string.IsNullOrEmpty(strNum2);

    if(validNum1 == true || validNum2 == true  )
    {
        Console.WriteLine("Erro: Por favor, insira valores numéricos válidos.");
        Console.WriteLine("--------------------------");
        Console.ReadLine();
        continue;
    }

    decimal num1 = Convert.ToDecimal(strNum1);
    decimal num2 = Convert.ToDecimal(strNum2);
    decimal resultado = 0;
    string txtOpe = "";

    switch(option)
    {
        case "1":
            resultado = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("--------------------------");
            txtOpe = $"{num1} + {num2} = {resultado}";
            break;
        case "2":
            resultado = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine("--------------------------");
            txtOpe = $"{num1} - {num2} = {resultado}";
            
            break;
        case "3":
            resultado = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.WriteLine("--------------------------");
            txtOpe = $"{num1} * {num2} = {resultado}";
            break;
        case "4":
            if(num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine($"O resultado da divisão é: {resultado}");
                Console.WriteLine("--------------------------");
                txtOpe = $"{num1} / {num2} = {resultado}";
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
    
    
    if (totalOpe < historicoOpe.Length)
    {
        historicoOpe[totalOpe] = txtOpe;    
        totalOpe++;
    }
}