// See https://aka.ms/new-console-template for more information

// Exercício 7 - Boletim 2.0

float notaFinal = 0;
Console.WriteLine("Olá, Aluno. Vamos calcular sua média!");
Console.WriteLine("Qual é o seu nome completo?");
string nomeCompleto = Console.ReadLine();

int tamanhoArray;
Console.WriteLine("Quantas notas serão usadas para compor a média?");
tamanhoArray = int.Parse(Console.ReadLine());
float[] notas = new float[tamanhoArray];
for ( int i = 0; i < tamanhoArray; i++){
    Console.WriteLine("Digite a " + (i+1) + "ª nota:");
    notas[i] = float.Parse(Console.ReadLine());
    notaFinal = notas[i] + notaFinal;
}
notaFinal = notaFinal/tamanhoArray;
Console.WriteLine("Aluno: " + nomeCompleto);
for (int i =0; i< tamanhoArray; i++){
Console.WriteLine($"Nota{i}: {notas[i]}");
}
    if (notaFinal >=6){
        Console.WriteLine("Com média " + (notaFinal) + " - APROVADO");
    }
    else if (notaFinal>= 5){
        Console.WriteLine("Com média " + (notaFinal) + " - EM RECUPERAÇÃO");
    }
    else {
        Console.WriteLine("Com média " + (notaFinal) + " - REPROVADO");
    }
