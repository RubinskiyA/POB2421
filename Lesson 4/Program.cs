//Задача 1
double mskPeople = 13015126;
double spbPeople = 5598486;
double raznica = (mskPeople - spbPeople) / 1000;
Console.WriteLine($"На {raznica} тысяч людей больше в Москве, чем в Санкт-Петербурге.");
//Задача 2
decimal plataYear = 260548.56895M;
decimal plataMonth = plataYear / 12;
decimal plata_NDFL = plataMonth * 0.87M;
Console.WriteLine($"Работник получает {plataMonth:F2} рублей в месяц до вычета НДФЛ, с вычетом - {plata_NDFL:F2} рублей");

