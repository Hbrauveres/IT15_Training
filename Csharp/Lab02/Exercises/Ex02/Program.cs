const int numCol = 3;
const int numLin = 5;

// Jagged Array Definição
int[][] jarray = new int[numLin][];

// Populando Array
for (int i = 0; i < numLin; i++)
{
    jarray[i] = new int[numCol];
    for (int j = 0; j < numCol; j++)
    {
        jarray[i][j] = j*i; 
    }
    
}

// Imprimindo Jagged Array
for (int i = 0; i < numLin; i++)
{
    Console.Write("[");
    for (int j = 0; j < numCol; j++)
    {
        Console.Write(string.Format("{0} ", jarray[i][j].ToString().PadLeft(3)));
    }
    Console.Write("]");
    Console.WriteLine();
}

// Soma das linhas
for(int i = 0; i < numLin; i++)
{
    int soma = 0;
    for(int j = 0; j < numCol; j++)
    {
        soma += jarray[i][j];
    }
    Console.WriteLine($"Soma linha {i} = {soma}");
}

// Soma das Colunas
for(int j = 0; j < numCol; j++)
{
    int soma = 0;
    for(int i = 0; i < numLin; i++)
    {
        soma += jarray[i][j];
    }
    Console.WriteLine($"Soma coluna {j} = {soma}");
}

//----------------------------------------------
// Multidim 2D array Definição e população
int[,] array2D = new int[numLin,numCol];
for(int i = 0; i < numLin; i++)
{
    for(int j = 0; j < numCol; j++)
    {
        array2D[i,j] = j*i;
    }
}

// Imprimindo 2D Multidim array
for (int i = 0; i < numLin; i++)
{
    Console.Write("[");
    for (int j = 0; j < numCol; j++)
    {
        Console.Write(string.Format("{0} ", array2D[i, j].ToString().PadLeft(3)));
    }
    Console.Write("]");
    Console.WriteLine();
}

// Soma das colunas
for(int j = 0; j < numCol; j++)
{
    int soma = 0;
    for(int i = 0; i < numLin; i++)
    {
        soma += array2D[i,j];
    }
    Console.WriteLine($"Soma coluna {j} = {soma}");
}

