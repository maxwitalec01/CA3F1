using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3F1.Shared.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class TeamRankingParameters
{
    public string season { get; set; }
}

public class TeamRankingResponse
{
    public int position { get; set; }
    public TeamRankingTeam team { get; set; }
    public int points { get; set; }
    public int season { get; set; }
}

public class TeamRankingRoot
{
    public string get { get; set; }
    public TeamRankingParameters parameters { get; set; }
    public List<object> errors { get; set; }
    public int results { get; set; }
    public List<TeamRankingResponse> response { get; set; }
}

public class TeamRankingTeam
{
    public int id { get; set; }
    public string name { get; set; }
    public string logo { get; set; }
}

