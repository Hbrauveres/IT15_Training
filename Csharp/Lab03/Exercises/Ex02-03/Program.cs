double[] numeros = {3.2, 5.5, 1.2, 7.25, 6, 1, 8, 4.9, 3, 6};
int arrSize = numeros.Count();
double arrToral = numeros.Sum();
double media = arrToral/arrSize;

Console.WriteLine($"MEDIA = {media}");

List<double> maiorQueMedia = new List<double>();

foreach (double val in numeros)
{
    if (val > media)
        maiorQueMedia.Add(val);
}

Console.WriteLine("Maiores que a media: [{0}]", string.Join(", ", maiorQueMedia));