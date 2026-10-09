// Programação Orientada a Objetos

// Classes -> Molde/Projeto (o que é um carro?) (Ela não faz nada sozinha, só define o objeto)
// Objetos -> Instância de uma classe (instanciar = criar um objeto) -> materialização de uma classe com atributos e métodos.

// Atributos -> Características do objeto (cor do carro, modelo, ano, etc)
// Métodos -> Ações que o objeto pode realizar (acelerar, frear, etc)


// Função Main -> ponto de partida do código.

// Como eu instancio um objeto?
// 1. Criar classe:
// 1 classe = 1 arquivo.

// Obs.: Colocamos public antes do class para poder utilizar esse código em outros lugares.


// Toda classe terá esse formato:
//public class nome_da_classe { }

// 2. Definir atributos

//public 'tipo' 'nome'


// 3. Definir métodos
// Estrutura do método:
//public retorno nome () { }


// Criando o objeto (que é uma variável)?

using POO___Fundamentos;

// Instanciar
// Classe Carro
//Carro carroDoLuc = new Carro();

//carroDoLuc.Modelo = "HB20S";
//carroDoLuc.Marca = "Hyundai";
//carroDoLuc.Ano = 2024;

//carroDoLuc.ExibirInformacoes();



// Classe Pedido
// NomeDoCliente, Item, Quantidade, Preco
// Objetos
// Obs.: A partir de um molde, pode ter quantos pedidos quiser.

//Pedido pedido1 = new Pedido();

//Console.WriteLine("Digite o nome do item: ");
//pedido1.Item = Console.ReadLine();

//Console.WriteLine("Digite o nome do cliente: ");
//pedido1.NomeDoCliente = Console.ReadLine();

//Console.WriteLine("Digite a quantidade: ");
//pedido1.Quantidade = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o preço: ");
//pedido1.Preco = double.Parse(Console.ReadLine());

//Console.WriteLine(pedido1.Quantidade);
//Console.WriteLine(pedido1.Preco);



// Exercícios

// 1.

//Pessoa Pessoa1 = new Pessoa();

//Pessoa1.Nome = "Ana";
//Pessoa1.Idade = 25;

//Pessoa Pessoa2 = new Pessoa();

//Pessoa2.Nome = "Bruno";
//Pessoa2.Idade = 31;

//Pessoa1.Apresentar();
//Pessoa2.Apresentar();

//// 2.

//Retangulo Retangulo1 = new Retangulo();

//Retangulo1.Largura = 5;
//Retangulo1.Altura = 3;

//Console.WriteLine($"Área: {Retangulo1.CalcularArea()}");
//Console.WriteLine($"Perímetro: {Retangulo1.CalcularPerimetro()}");


//// 3.

//Lampada MinhaLampada = new Lampada();

//MinhaLampada.ExibirEstado();
//MinhaLampada.Ligar();
//MinhaLampada.ExibirEstado();
//MinhaLampada.Desligar();
//MinhaLampada.ExibirEstado();


// 4.

//ContaBancaria conta = new ContaBancaria("Lucas", 0.0);

//conta.Depositar(500);
//conta.Sacar(200);
//conta.Sacar(1000);
//conta.ExibirSaldo();



// Lista 2

// 1.

//Pessoa ana = new Pessoa();

//ana.Nome = "Ana";

//ana.Cumprimentar();
//ana.CumprimentarAlguem("Bruno");

//string frase = ana.ObterApresentacao();
//Console.WriteLine(frase);


// 2.

//Calculadora calc = new Calculadora();

//int soma = calc.Somar(10, 5);
//calc.MostrarResultado(soma);

//calc.MostrarResultado(calc.Subtrair(10, 5));


// 3.





