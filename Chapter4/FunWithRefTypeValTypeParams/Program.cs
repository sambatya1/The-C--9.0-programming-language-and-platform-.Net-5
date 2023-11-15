
SendRefByRef();

// Передача ссылочных типов по значению.
static void SendRefByVal()
{
    Console.WriteLine("***Passing Person object by value *****");
    Person fred = new Person("Fred", 12);
    Console.WriteLine("\nBefore by value call, Person is:");
    fred.Display();
    SendAPersonByValue(fred);
    Console.WriteLine("\nAfter by value call, Person is:");
    // После вызова с передачей по значению
    fred.Display();
    Console.ReadLine();
}

static void SendRefByRef()
{
    // Передача ссылочных типов по ссылке.
    Console.WriteLine("***** Passing Person object by reference ***** ");
    Person mel = new Person("Mel", 23);
    Console.WriteLine("Before by ref call, Person is:");
    // Перед вызовом с передачей по ссылке
    mel.Display();
    SendAPersonByReference(ref mel);
    Console.WriteLine("After by ref call, Person is:");
    // После вызова с передачей по ссылке
    mel.Display();
    Console.ReadLine();
}

static void SendAPersonByValue(Person p)
{
    // Изменить значение возраста в р?
    p.personAge = 99;
    p = new Person("Nikki", 25);
}

static void SendAPersonByReference(ref Person p)
{
    // Изменить некоторые данные в р.
    p.personAge = 555;
    // р теперь указывает на новый объект в куче!
    p = new Person("Nikki", 999);
}
class Person
{
    public string personName;
    public int personAge;
    // Конструкторы.
    public Person(string name, int age)
    {
        personName = name;
        personAge = age;
    }
    public Person() { }
    public void Display()
    {
        Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
    }
}

