Double calcIMC (Double peso, Double altura) 
{
    Double IMC = peso / (altura * altura);
    IMC=Math.Round(IMC,4);
    return IMC;
}

String classificaIMC(String gen, Double peso, Double altura)
{
    String classifica = "";
    Double imc = calcIMC(peso, altura);
    if (imc > 39.9) classifica = "Obesidade Morbida";
    else classifica = "Abaixo do normal";
    return classifica;
}


String genero;
Double peso, altura;

Console.Write("Qual seu gênero (F/M)");
genero = Console.ReadLine();
Console.WriteLine("Quanto você pesa? (KG)");
peso = Double.Parse(Console.ReadLine());
Console.WriteLine("Qual sua altura? Metros");
altura = Double.Parse(Console.ReadLine());

Double meuIMC = calcIMC(peso,altura);
Console.WriteLine("IMC = " + meuIMC);
Console.WriteLine(classificaIMC(genero,altura,peso));