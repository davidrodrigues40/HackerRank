namespace ConsoleApp.Services;

public static class ArgGenerator
{
    public static string[] GetArguments(string problem)
    {
        string values = problem switch
        {
            "ClimbingLeaderBoard" => "[100,90,90,80,75,60] [50,65,77,90,102]",
            "PickingNumbers" => "1,1,2,2,4,4,5,5,5",
            "HurdleRace" => "7,2 5 4 5 2",
            "DesignerPdfViewer" => "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7,zaba",
            "UtopianTree" => "0 1 4",
            "AngryProfessor" => "3,-1 -3 4 2",
            "BeautifulDaysAtTheMovies" => "20,23,6",
            _ => "[100,100,50,40,40,20,10] [5,25,50,120]"
        };

        return new[] { problem, values };
    }
}