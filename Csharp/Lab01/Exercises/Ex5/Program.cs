string stringInt = "123456789";
int valStringInt = Convert.ToInt32(stringInt);
Console.WriteLine(valStringInt);

Int64 valInt64 = 123456789;
int valInt = Convert.ToInt32(valInt64);
Console.WriteLine(valInt);

// Erro, int não suporta o valor contid na string
//string strIntGrande = "999999999999999999999999999999999999999999999";
//int valStrGrande = Convert.ToInt(strIntGrande);
// Ex6 apresenta o modo TryParse, uma forma de detectar e lidar com esse erro