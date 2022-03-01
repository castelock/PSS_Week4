using System.Globalization;

namespace StyleProvider
{


    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("The options for this program are: {0} 1- Example 1. {0} " +
                "2- Example 2. {0} " +
                "3- Example 3. {0} " +
                "4- Example different formats. {0} ", Environment.NewLine);
            Console.WriteLine("Insert one of the previous options: ");
            String option = Console.ReadLine();


            switch (option)
            {
                case "1":
                    string numericString = "22,593";
                    NumberStyles styles = NumberStyles.Integer | NumberStyles.AllowThousands;
                    CultureInfo providerUS = new CultureInfo("en-US");
                    CultureInfo providerES = new CultureInfo("es-ES");
                    int resultUS = Int32.Parse(numericString, styles, providerUS);
                    int resultES = Int32.Parse(numericString, styles, providerES);
                    break;
                case "2":
                    numericString = "$10634";
                    styles = NumberStyles.Integer | NumberStyles.AllowCurrencySymbol;
                    providerUS = new CultureInfo("en-US");
                    providerES = new CultureInfo("es-ES");
                    resultUS = Int32.Parse(numericString, styles, providerUS);
                    resultES = Int32.Parse(numericString, styles, providerES);
                    break;
                case "3":
                    numericString = "10345.00";
                    styles = NumberStyles.Integer | NumberStyles.AllowDecimalPoint;
                    providerUS = new CultureInfo("en-US");
                    providerES = new CultureInfo("es-ES");
                    resultUS = Int32.Parse(numericString, styles, providerUS);
                    resultES = Int32.Parse(numericString, styles, providerES);
                    break;
                case "4":
                    CultureInfo[] culturas = { CultureInfo.CreateSpecificCulture("en-US"),
                           CultureInfo.CreateSpecificCulture("es-ES") };
                    int enteroPositivo = 1679;
                    int enteroNegativo = -3045;
                    string[] formatos = { "G", "C", "D8", "E2", "F", "N", "P", "X8" };
                    foreach (string formato in formatos)
                    {
                        foreach (CultureInfo cultura in culturas)
                        {
                            Console.WriteLine("Formato {0, 2} usando cultura {1}: {2, 16} {3, 16}",
                                              formato, cultura.Name,
                                              enteroPositivo.ToString(formato, cultura),
                                              enteroNegativo.ToString(formato, cultura));
                        }
                        Console.WriteLine();
                    }

                    break;
                default:
                    Console.WriteLine("The option is not valid.");
                    break;
            }









        }


    }
}

