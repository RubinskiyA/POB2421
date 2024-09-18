//string name = "132145";
//string resultName = name ?? "Net dannih";//Проверка на null
//Console.WriteLine(resultName);
//Console.WriteLine(name??="Net dannih");//второй вариант проверки
using System.Security.Principal;





void PrintWebSite(Person? person)
{
    //if (person != null)
    //{
    //    if(person.Company != null)
    //    {
    //        if(person.Company.WebSite != null)
    //        {
    //            Console.WriteLine(person.Company.WebSite.ToUpper());
    //        }
    //    }
    //}
    //______________________________________________________________________________или
    //if ((person != null)&&(person.Company != null)&&(person.Company.WebSite != null))
    //{
    //    Console.WriteLine(person.Company.WebSite.ToUpper());
    //}
    //______________________________________________________________________________или
    Console.WriteLine(person?.Company?.WebSite?.ToUpper()??"Нет сайта");


}

Company company = new Company();
//company.WebSite = "www.mail.ru";
company.WebSite = null;
Person person = new Person();
person.Company = company;
PrintWebSite(person);
class Person
{
    public Company? Company { get; set; }
}

class Company
{
    public string? WebSite { get; set; } 
}


