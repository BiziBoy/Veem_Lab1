using System;

//Учебный пример реализации immutable (неизменяемого) класса без дальнейшей реализации
namespace Veem_Lab1
{
  sealed class MyImmutableClass
  {
    private string name { get; }

    private readonly int id;

    public MyImmutableClass(string _name, int _id)
    {
      name = _name;
      id = _id;
    }

    public MyImmutableClass ChangeId(ref MyImmutableClass myImmutableClass)
    {
      string nameTemp = myImmutableClass.name;
      Console.Write("Введите новое значение Id: ");
      int idTemp = int.Parse(Console.ReadLine());
      MyImmutableClass temp = new(nameTemp, idTemp);
      myImmutableClass = null;
      return temp;
    }
  }
  class Program
  {
    static void Main()
    {

    } 
  }
}