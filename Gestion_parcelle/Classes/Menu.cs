using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_parcelle.Classes
{
    internal class Menu
    {
        public static void MenuSelect(string choixDeMenu)
        {
            switch (choixDeMenu)
            {
                #region Main
                case "main":
                    Console.Clear();
                    Console.Write("====|Main menu|====\n\n" +
                        "[1] See the DB \n" +
                        "[2] Insert in the DB\n" +
                        "[3] \n" +
                        "[4] \n" +
                        "[5] \n" +
                        "[6] \n" +
                        "-------------------------\nEntry:");
                    break;
                #endregion
                #region List
                case "list":
                    Console.Clear();
                    Console.Write("====|List menu|====\n\n" +
                        "[1] Chemical element \n" +
                        "[2] Composition\n" +
                        "[3] Culture\n" +
                        "[4] Fertilizer\n" +
                        "[5] Plot\n" +
                        "[6] Production\n" +
                        "[7] Spraying\n" +
                        "-------------------------\nEntry:");
                    break;
                case "insert":
                    Console.Clear();
                    Console.Write("====|Insertion menu|====\n\n" +
                        "[1] Chemical element \n" +
                        "[2] Composition\n" +
                        "[3] Culture\n" +
                        "[4] Fertilizer\n" +
                        "[5] Plot\n" +
                        "[6] Production\n" +
                        "[7] Spraying\n" +
                        "-------------------------\nEntry:");
                    break;
                    #endregion
            }
        }
    }
}
