using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Globalization;
using System.Text;

/// <summary>class</summary>
class Obj
{
    ///<summary>a method that prints the names of the available properties and methods of an object. See example for output format.</summary>
    /// <returns> not </returns>
    public static void Print(object myObj)
    {
        Type tt = myObj.GetType();
        TypeInfo t = tt.GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        IEnumerable<MethodInfo> mList = t.GetMethods();
           
        System.Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo p in pList)
        {
            System.Console.WriteLine(p.Name);
        }
        
        System.Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo m in mList)
        {
            System.Console.WriteLine(m.Name);
        }

       
    }
}