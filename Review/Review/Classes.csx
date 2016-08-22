using System;

//Make a class and assign it three properties

public class SoccerPlayer
{
    public string Player { get; set; }
    public int Number { get; set; }
    public int GoalsScored { get; set; }
}

SoccerPlayer Paul = new SoccerPlayer();
Paul.Player = "Jim";
Paul.Number = 65;
Paul.GoalsScored = 56;
Console.WriteLine(Paul.Player);
Console.WriteLine(Paul.Number);
Console.WriteLine(Paul.GoalsScored);
