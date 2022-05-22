// Alocar, Inicializar e Acessar dados em array de tamanho fixo

void DesenhaDivisor()
{
    int i = 0;
    while(true) // Desenha um divisor
    {
        if (i > 30)
        {
            Console.Write("\n");
            break;
        }
        else
        {
            Console.Write("-");
            i++;
        }
    }
}

int[] array = new int[5] {10,20,30,40,50};
int i;
for (i = 0; i < 5; i++)
{
    Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
}

DesenhaDivisor();

DateTime[] dt = new DateTime[2];
int iDate;
dt[0] = new DateTime(2002,5,1);
dt[1] = new DateTime(2002,6,1);
for (iDate = 0; iDate < 2; iDate++)
{
    Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
}

DesenhaDivisor();

iDate = 0; 
foreach (DateTime date in dt)
{
    Console.WriteLine("Indice = " + iDate + " & Data = " + date.ToShortDateString());
    iDate++;
}