// See https://aka.ms/new-console-template for more information
using Demos.Day2.Lib;

try
{
    InitializeSettings();
}
catch
{
    
}



static void InitializeSettings()
{
    object dbConn;

    // file inlezen
    // eventueel terugvallen op default als file niet bestaat
    try
    {
        Console.WriteLine("Voor het laden");
        dbConn = null; // = new DbConnection()
        LoadSettingsFromFile();

        Console.WriteLine("na het laden");
    }
    catch (Exception e)
    {
        Console.WriteLine("probleem bij laden settings: " + e.Message);
        LoadDefaultSettings();
        Console.WriteLine("maar ik kon de default settings inlezen");

        Console.WriteLine("Einde van catch");
    }
    finally
    {
        Console.WriteLine("Gebeurt altijd");
        //dbConn.CleanUp();

    }

    // settings 
}

static int LoadSettingsFromFile()
{
    throw new Exception();
    //var fileContents = File.ReadAllText("c:\\settings.json");
    //if (fileContents == null)

    return 1000;
}

static int LoadDefaultSettings()
{
    return 500;
}