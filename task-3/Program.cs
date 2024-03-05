//Створити список місяців на рік із зазначенням їх назви та кількістю днів у місяці. Створити список місяців у яких 30 днів

List<string> year = new List<string>()
{
    "Jenuary 31", "February 29",
    "March 31", "April  30", "May 31",
    "June 30", "July 31", "August 31",
    "September 30", "October 31", "November 30",
    "Desember 31"
};

foreach (string month in year)
{
    Console.WriteLine(month);
}

var selectMonth = from month in year
                  where month.Contains("30")
                  select month;

Console.WriteLine("\nResult1:");

foreach (var month in selectMonth)
{
    Console.WriteLine(month);
}

var selectMonth2 = year.Where(m => m.Contains("30")).ToList();

Console.WriteLine("\nResult2:");

foreach (var month in selectMonth2)
{
    Console.WriteLine(month);
}

