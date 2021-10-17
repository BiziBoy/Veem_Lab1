using System;

namespace Task_2
{
  interface IInheritance
  {
    public virtual string GetInfo()
    {
      return  "Parent.";
    }
  }

  struct Base: IInheritance
  {
    public string GetInfo()
    {
      return "Base";
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      
    }
  }
}
