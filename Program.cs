// Programa que lê e valida as seguintes informações:
//
// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;
//
// 3. Salário: maior que zero;
//
// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));


Console.Write (@$"
--------------------------------------------------------------------------------------------------
                     Programa para verificar dados do usuário  1.0                        
--------------------------------------------------------------------------------------------------
");


//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//


string nome, estado_civil;
int idade;
double salario;

Console.Write(@$"Digite o seu nome: ");
nome = Console.ReadLine().ToUpper() ;

while (String.IsNullOrWhiteSpace(nome))     // Método para verificar se a String é Nula, Vazia ou WhiteSpace.
{
    Console.Clear();
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("               ERRO, informe um nome válido !"                     );
    Console.WriteLine("------------------------------------------------------------------");

    Console.Write("Digite seu nome:");    
    nome = Console.ReadLine();     
}

Console.Clear();
Console.Write($"Digite a sua idade: ");
idade = int.Parse (Console.ReadLine()) ;

while (idade <=0 || idade >100)
{
    Console.Clear();
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("                ERRO, informe uma idade válida !                  ");
    Console.WriteLine("------------------------------------------------------------------");
    Console.Write($"Digite sua idade:  ");
    idade = int.Parse (Console.ReadLine());
}

Console.Clear();
Console.Write($"Digite seu salário: ");
salario= double.Parse (Console.ReadLine()) ;

while ( salario <= 0)
{
    Console.Clear ();
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("                 ERRO, informe um valor válido !                  ");
    Console.WriteLine("------------------------------------------------------------------");
    Console.Write($"Digite seu salário:  ");
    salario = double.Parse (Console.ReadLine());
}

Console.Clear();
Console.Write($"Digite seu estado civil 'S'(solteiro(a)), 'C'(casado(a)), 'V'(viuvo(a)), 'D'(divorciado(a)): ");
estado_civil = (Console.ReadLine()) .ToUpper() ;

while ( estado_civil != "S" && estado_civil != "C" && estado_civil != "V" && estado_civil != "D")
{
    Console.Clear();
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("          ERRO, informe um estado civil válido !                  ");
    Console.WriteLine("------------------------------------------------------------------");
    Console.Write($"Digite seu estado civil:  ");
    estado_civil =  (Console.ReadLine()) .ToUpper() ;
}


Console.Clear();

Console.WriteLine (@$"

|----------------------------------------------|
|   RELATÓRIO DOS DADOS COLETADOS E VALIDADOS  |
|----------------------------------------------|
     NOME: {nome}                              
     IDADE: {idade} anos                           
     SALÁRIO: {string.Format("{0:C2}", salario)} reais                       
     ESTADO CIVIL: {estado_civil}                           
 
");


Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();