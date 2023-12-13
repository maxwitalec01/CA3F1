namespace CA3F1.Shared.Models;


// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class TeamDetailHighestRaceFinish
{
    public int position { get; set; }
    public int number { get; set; }
}

public class TeamDetailParameters
{
    public string search { get; set; }
}

public class TeamDetailResponse
{
    public int id { get; set; }
    public string name { get; set; }
    public string logo { get; set; }
    public string @base { get; set; }
    public int first_team_entry { get; set; }
    public int world_championships { get; set; }
    public TeamDetailHighestRaceFinish highest_race_finish { get; set; }
    public int pole_positions { get; set; }
    public int fastest_laps { get; set; }
    public string president { get; set; }
    public string director { get; set; }
    public string technical_manager { get; set; }
    public string chassis { get; set; }
    public string engine { get; set; }
    public string tyres { get; set; }
}

public class TeamDetailRoot
{
    public string get { get; set; }
    public TeamDetailParameters parameters { get; set; }
    public List<object> errors { get; set; }
    public int results { get; set; }
    public List<TeamDetailResponse> response { get; set; }
}

