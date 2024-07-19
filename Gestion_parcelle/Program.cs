using Gestion_parcelle.Classes;
#region Function
#region Show list
void ShowChemicalElementList(List<ChemicalElement> listInput)
{
    for (int i = 0; i < listInput.Count; i++)
    {
        Console.WriteLine($"Element [{listInput[i].ElementCode}] as {listInput[i].ElementTag} and is unit is {listInput[i].ElementUnit}");
    }
}
void ShowCompositionList(List<Composition> listInput)
{
    for (int i = 0; i < listInput.Count; i++)
    {
        Console.WriteLine($"Composition [{listInput[i].CompositionId}] is the fetilizer with the id {listInput[i].CompositionFertilizerId} with the element code {listInput[i].Composition_element_code_id} in {listInput[i].Composition_unit}");
    }
}
void ShowCultureList(List<Culture> listInput)
{
    for(int i = 0; i < listInput.Count; i++)
    {
        Console.WriteLine($"Culture [{listInput[i].CultureId}] has started the {listInput[i].CultureStartingDate} and ended {listInput[i].CultureEndingDate} this culture hase gathered {listInput[i].CultureQuantityGathered} and has the production code [{listInput[i].CultureProductionCode}]");
    }
    
}
void ShowFertilizerList(List<Fertilizer> listInput)
{
    for (int i = 0; i < listInput.Count; i++)
    {
        Console.WriteLine($"Fertilizer [{listInput[i].FertilizerId}] who is maned {listInput[i].FertilizerName}");
    }

}
void ShowPlotList(List<Plot> listInput)
{
    for (int i = 0; i < listInput.Count; i++)
    {
    Console.WriteLine($"Plot [{listInput[i].PlotId}] named {listInput[i].PlotName} at the coordinate {listInput[i].PlotCordinate} that as a surface of {listInput[i].PlotSurface} and has a culture id of [{listInput[i].PlotCultureId}]");
}

}
void ShowProductionList(List<Production> listInput)
{
    for (int i = 0; i < listInput.Count; i++)
    {
    Console.WriteLine($"Production [{listInput[i].Productionid}] is a {listInput[i].ProductionName} production and is weigthed in {listInput[i].ProductionUnit}");
}

}
void ShowSprayingList(List<Spraying> listInput)
{
    for (int i = 0; i < listInput.Count; i++)
    {
    Console.WriteLine($"Spraying [{listInput[i].SprayingId}] was the fertilizer [{listInput[i].SprayinFertilizerId}] quantity was {listInput[i].SprayingQuantity} was sprayed the {listInput[i].SprayingDate} on the plot [{listInput[i].SprayingPlotId}]");
    }
}
#endregion
#region insert value
void insertChemicalElement() 
{
    string elementCode,
           elementTag,
           unit;
    restartChemicalElementInsertion:
    Console.Clear();
    Console.Write("====|Insert a chemical element|====\n\n" +
        "Enter the element code:");
    elementCode = Console.ReadLine();
    if (elementCode == null || elementCode == "")
    {
        Console.WriteLine("Error:need to enter a value");
        Console.ReadKey();
        goto restartChemicalElementInsertion;
    }
    Console.Write("Enter the element name:");
    restartElementNaming:
    elementTag = Console.ReadLine();
    if (elementTag == null || elementTag == "")
    {
        Console.WriteLine("Error:need to enter a value");
        Console.ReadKey();
        goto restartElementNaming;
    }
    restartElementUnit:
    Console.Write("Enter the unit:");
    unit = Console.ReadLine();
    if (unit == null || unit == "")
    {
        Console.WriteLine("Error:need to enter a value");
        Console.ReadKey();
        goto restartElementUnit;
    }
    ChemicalElement.AddObjectToDB(elementCode,elementTag,unit);
}
void insertComposition()
{
    restartCompositionInsertion:
    int compositionId,
        compositionFertilizerId;
    string compositionElementCode,
           compositionUnit;
    Console.Write("====|Insert a Composition|====\n\n" +
        "Enter the element code:");
    bool fertilizerIdParse = int.TryParse(Console.ReadLine(), out compositionFertilizerId);
    if (!fertilizerIdParse)
    {
        Console.WriteLine("Error:the entry is not a number");
        Console.ReadKey();
        goto restartCompositionInsertion;
    }
    Console.Write("Enter the element code:");
    restartCompositionElementCode:
    compositionElementCode = Console.ReadLine();
    if (compositionElementCode == null || compositionElementCode == "")
    {
        Console.WriteLine("Error:need to enter a value");
        Console.ReadKey();
        goto restartCompositionElementCode;
    }
    restartCompositionUnit:
    compositionUnit = Console.ReadLine();
    if (compositionUnit == null || compositionUnit == "")
    {
        Console.WriteLine("Error:need to enter a value");
        Console.ReadKey();
        goto restartCompositionUnit;
    }


}
#endregion

#endregion

bool appWorking = true;
while (appWorking)
{
    Menu.MenuSelect("main");
    switch (Console.ReadLine())
    {
        case "1":
            restartMenuList:
            Menu.MenuSelect("list");
            switch (Console.ReadLine())
            {
                case "exit":
                    break;
                #region Chemical element list
                case "1":
                    List<ChemicalElement> chemicalElementslist = new List<ChemicalElement>(ChemicalElement.FetchDataBaseList());
                    Console.Clear();
                    ShowChemicalElementList(chemicalElementslist);
                    Console.ReadKey();
                    goto restartMenuList;
                #endregion
                #region Composition list
                case "2":
                    List<Composition> compositionList = new List<Composition>(Composition.FetchDataBaseList());
                    Console.Clear();
                    ShowCompositionList(compositionList);
                    Console.ReadKey();
                    goto restartMenuList;
                #endregion
                #region Culture
                case "3":
                    List<Culture> cultureList = new List<Culture>(Culture.FetchDataBaseList());
                    Console.Clear();
                    ShowCultureList(cultureList);
                    Console.ReadKey();
                    goto restartMenuList;
                #endregion
                #region Fertilizer
                case "4":
                    List<Fertilizer> fertilizerList = new List<Fertilizer>(Fertilizer.FetchDataBaseList());
                    Console.Clear();
                    ShowFertilizerList(fertilizerList);
                    Console.ReadKey();
                    goto restartMenuList;
                #endregion
                #region Plot
                case "5":
                    List<Plot> plotList = new List<Plot>(Plot.FetchDataBaseList());
                    Console.Clear();
                    ShowPlotList(plotList);
                    Console.ReadKey();
                    goto restartMenuList;
                #endregion
                #region Production
                case "6":
                    List<Production> productionList = new List<Production>(Production.FetchDataBaseList());
                    Console.Clear();
                    ShowProductionList(productionList);
                    Console.ReadKey();
                    goto restartMenuList;
                #endregion
                #region Spraying
                case "7":
                    List<Spraying> sprayingList = new List<Spraying>(Spraying.FetchDataBaseList());
                    Console.Clear();
                    ShowSprayingList(sprayingList);
                    Console.ReadKey();
                    goto restartMenuList;
                #endregion
                default:
                    Console.WriteLine("Error: invalid entry");
                    Console.ReadKey();
                    goto restartMenuList;
            }
            break;
        case "2":
            restartMenuInsert:
            Menu.MenuSelect("insert");
            switch (Console.ReadLine())
            {
                case "exit":
                    break;
                case "1":
                    insertChemicalElement();
                    Console.ReadKey();
                    goto restartMenuInsert;
                default:
                    Console.WriteLine("Error:invalid entry");
                    Console.ReadKey();
                    goto restartMenuInsert;
            }
            break;
        case "exit":
            appWorking = false;
            break;
        default:
            Console.WriteLine("Error:Command not supported or incorect");
            break;
    }
}