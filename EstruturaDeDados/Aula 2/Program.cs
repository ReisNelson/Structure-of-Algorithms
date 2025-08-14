//Double Dobrar(Double x)
//{
//    Double result = 2 * x;
//    return result;
//}

//Double mediaFecap(Double N1, Double PO, Double PI)
//{
//    Double result = N1 * 0.20 + PI * 0.30 + PO * 0.50;
//    return result;
//}

//Double media = mediaFecap(6.0, 7.0, 9.0);
//Console.WriteLine(media);



//Double y = Dobrar(2);
//Console.WriteLine(y);
//Double a = 5;
//y = Dobrar(a);
//Console.WriteLine(y);
//y = Dobrar(Dobrar(10));
//Console.WriteLine(y);


//Code that the professor did in class.

int diaMes(int mes)
{
    int result = 0;

    switch (mes)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12: result = 31; break;
        case 2: result = 28; break;
        case 4:
        case 6:
        case 9:
        case 11: result = 30; break;

    }
    return result;
}

int fimMes(int dia, int mes)
{
    int diasMes = diaMes(mes);
    int fim = diasMes - dia;
    return fim;
}
int dia, mes;
Console.WriteLine("Entre com o mês (1-12)");
mes = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o dia do mês (1-12)");
dia = int.Parse(Console.ReadLine());
int fim = fimMes(dia, mes);
Console.WriteLine("Faltam " + fim + " para terminar o mês " + mes);