using OOP_9_22;

Building[] mas = new Building[]
{
    new Building{BuildingName="1", Floors=5, Height=20,TotalArea=1200},
    new Building{BuildingName="2", Floors=7, Height=27,TotalArea=1905},
    new Building{BuildingName="3", Floors=3, Height=9,TotalArea=650}
};
void Print(Building[] mas, DelBuilding db)
{
foreach (Building ma in mas)
    {
        db = ma.CalculateVolume;
        Console.WriteLine(ma.BuildingName+" "+ma.Height+" "+ma.Floors+" "+ma.TotalArea+" Volume:"+db());
        
    }
}
delegate double DelBuilding();
