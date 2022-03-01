
using System;
using System.Collections;

namespace IteratorCollection
{


    class Program
    {
        static void EscribeInfoObjeto(object obj)
        {
            TypeCode typeCode = Type.GetTypeCode(obj.GetType());
            switch (typeCode)
            {
                case TypeCode.Boolean:
                    Console.WriteLine("Boolean: {0}", obj);
                    break;
                default:
                    Console.WriteLine("{0}:{1}", typeCode.ToString(), obj);
                    break;
            }
        }
        static void Main(string[] args)
        {
            object[] objetos = { 0, 4.5, 0xAF, true };
            foreach (var item in objetos)
                EscribeInfoObjeto(item);



        }


    }
}

