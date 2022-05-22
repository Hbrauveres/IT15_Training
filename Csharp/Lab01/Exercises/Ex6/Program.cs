string strInt = "123456789";
int valStrInt;
bool conversao = Int32.TryParse(strInt, out valStrInt);
Console.WriteLine("[Conversão efetuada]:" + conversao + "\n[Valor]:" + valStrInt);

string strIntGrande = "999999999999999999999999999999999999999999999";
int valStrIntGrande;
bool conversaoGrande = Int32.TryParse(strIntGrande, out valStrIntGrande);
Console.WriteLine("[Conversão efetuada]:" + conversaoGrande + "\n[Valor]:" + valStrIntGrande);

string strLetras = "abc";
double valStrLetras;
bool conversaoLetras = Double.TryParse(strLetras, out valStrLetras);
Console.WriteLine("[Conversão efetuada]:" + conversaoLetras + "\n[Valor]:" + valStrLetras);


