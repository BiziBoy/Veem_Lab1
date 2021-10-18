using System;

namespace Task_2
{
  interface IInheritance
  {
    public string GetInfo()
    {
      return  "Parent";
    }
  }

  struct Base: IInheritance
  {
    string GetInfo()
    {
      Console.WriteLine("Base");
      return "Base";
    }
    public Base(Base _b)
    {
      GetInfo();
    }
  }

  struct A: IInheritance
  {
    public A(IInheritance _a)
    {
      if (_a is Base)
      {
        Base _bbase = new Base((Base)_a);
      }
      else
      {
        GetInfo();
      }
      string GetInfo()
      {
        Console.WriteLine("A");
        return "A";
      }
    }
  }

  class Program
  {
    static void Main()
    {
      IInheritance b = new Base();
      A a = new A(b);
    }
  }
}
