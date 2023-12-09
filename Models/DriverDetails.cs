using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CA3F1.Shared.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class DriverDetailCountry
{
    public string? name { get; set; }
    public string? code { get; set; }
}

public class DriverDetailHighestRaceFinish
{
    public int? position { get; set; }
    public int? number { get; set; }
}

public class DriverDetailParameters
{
    public string? search { get; set; }
}

public class DriverDetailResponse
{
    public int? id { get; set; }
    public string? name { get; set; }
    // public string abbr { get; set; }
    public string? image { get; set; }
    public string? nationality { get; set; }
    public DriverDetailCountry? country { get; set; }
    public string? birthdate { get; set; }
    public string? birthplace { get; set; }
    public int? number { get; set; }
    public int? grands_prix_entered { get; set; }
    public int? world_championships { get; set; }
    public int? podiums { get; set; }
    public DriverDetailHighestRaceFinish? highest_race_finish { get; set; }
    public int? highest_grid_position { get; set; }
    public string? career_points { get; set; }
    public List<DriverDetailTeam>? teams { get; set; }
}

public class DriverDetailRoot
{
    public string? get { get; set; }
    public DriverDetailParameters? parameters { get; set; }
    public List<object>? errors { get; set; }

    public int? results { get; set; }
    public List<DriverDetailResponse>? response { get; set; }
}

public class DriverDetailTeam
{
    public int? season { get; set; }
    public DriverDetailTeam? team { get; set; }
}

public class DriverDetailTeam2
{
    public int? id { get; set; }
    public string? name { get; set; }
    public string? logo { get; set; }
}

public class DriverDetailErrors
{
    public List<Error>? ErrorsList { get; set; } // Change here
}

