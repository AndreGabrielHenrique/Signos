Console.Write("Digite o dia de nascimento: ");
string diainput = Console.ReadLine();
DateTime dianascimento;
if (!DateTime.TryParseExact(diainput,"dd",null,System.Globalization.DateTimeStyles.None,out dianascimento))
{
    Console.WriteLine("Dia de nascimento inválido.");
    return;
}
Console.Write("Digite o mês de nascimento: ");
string mesinput = Console.ReadLine();
DateTime mesnascimento;
if (!DateTime.TryParseExact(mesinput,"MM",null,System.Globalization.DateTimeStyles.None,out mesnascimento))
{
    Console.WriteLine("Mês de nascimento inválido.");
    return;
}
int dia=dianascimento.Day;
int mes=mesnascimento.Month;
if((dia>=21&&mes==3)||(dia<=20&&mes==4))
    Console.WriteLine("Você é de Aries.");
if((dia>=24&&mes==9)||(dia<=23&&mes==10))
    Console.WriteLine("Você é de Libra.");
if((dia>=21&&mes==4)||(dia<=21&&mes==5))
    Console.WriteLine("Você é de Touro.");
if((dia>=24&&mes==10)||(dia<=22&&mes==11))
    Console.WriteLine("Você é de Escorpião.");
if((dia>=22&&mes==5)||(dia<=21&&mes==6))
    Console.WriteLine("Você é de Gêmeos.");
if((dia>=23&&mes==11)||(dia<=21&&mes==12))
    Console.WriteLine("Você é de Sagitário.");
if((dia>=21&&mes==6)||(dia<=23&&mes==7))
    Console.WriteLine("Você é de Câncer.");
if((dia>=22&&mes==12)||(dia<=20&&mes==1))
    Console.WriteLine("Você é de Capricórnio.");
if((dia>=24&&mes==7)||(dia<=23&&mes==8))
    Console.WriteLine("Você é de Leão.");
if((dia>=21&&mes==1)||(dia<=19&&mes==2))
    Console.WriteLine("Você é de Aquário.");
if((dia>=24&&mes==8)||(dia<=23&&mes==9))
    Console.WriteLine("Você é de Virgem.");
if((dia>=20&&mes==2)||(dia<=20&&mes==3))
    Console.WriteLine("Você é de Peixes.");