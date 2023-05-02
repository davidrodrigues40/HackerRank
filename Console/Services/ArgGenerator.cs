namespace ConsoleApp.Services;

public static class ArgGenerator
{
    public static string[] GetArguments(string problem)
    {
        string values = problem switch
        {
            "ClimbingLeaderBoard" => "[100,90,90,80,75,60] [50,65,77,90,102]",
            "PickingNumbers" => "1,1,2,2,4,4,5,5,5",
            _ => "[100,100,50,40,40,20,10] [5,25,50,120]"
        };

        return new[] { problem, values };
    }
}