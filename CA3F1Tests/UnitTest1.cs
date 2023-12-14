using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
	[Test]
	public async Task RankingTest()
	{
		await Page.GotoAsync("https://maxwitalec01.github.io/CA3F1/");

		// Example pattern for the rest of the clicks and assertions
		var first_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "1", Exact = true });

		// Assert that the first cell was clicked, perhaps by checking if a detail pane or new content appears
		Assert.That(await first_pos.InnerTextAsync(), Is.EqualTo("1"), "First cell should show the expected text after click.");

		var first_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Red Bull Racing" });

		// Assert that the first cell was clicked, perhaps by checking if a detail pane or new content appears
		Assert.That(await first_team.InnerTextAsync(), Is.EqualTo("Red Bull Racing"), "First cell should show the expected text after click.");

		// Test for clicking on cell with name "860"
		var first_points = Page.GetByRole(AriaRole.Cell, new() { Name = "860" });
		await first_points.ClickAsync();
		Assert.That(await first_points.InnerTextAsync(), Is.EqualTo("860"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "2"
		var second_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "2", Exact = true });
		await second_pos.ClickAsync();
		Assert.That(await second_pos.InnerTextAsync(), Is.EqualTo("2"), "Cell should show the expected text after click.");

		// Test for clicking on "Mercedes-AMG Petronas"
		var second_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Mercedes-AMG Petronas" });
		await second_team.ClickAsync();
		Assert.That(await second_team.InnerTextAsync(), Is.EqualTo("Mercedes-AMG Petronas"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "409"
		var second_points = Page.GetByRole(AriaRole.Cell, new() { Name = "409" });
		await second_points.ClickAsync();
		Assert.That(await second_points.InnerTextAsync(), Is.EqualTo("409"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "3"
		var third_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "3", Exact = true });
		await third_pos.ClickAsync();
		Assert.That(await third_pos.InnerTextAsync(), Is.EqualTo("3"), "Cell should show the expected text after click.");

		// Test for clicking on "Scuderia Ferrari"
		var third_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Scuderia Ferrari" });
		await third_team.ClickAsync();
		Assert.That(await third_team.InnerTextAsync(), Is.EqualTo("Scuderia Ferrari"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "406"
		var third_points = Page.GetByRole(AriaRole.Cell, new() { Name = "406" });
		await third_points.ClickAsync();
		Assert.That(await third_points.InnerTextAsync(), Is.EqualTo("406"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "4"
		var fourth_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "4", Exact = true });
		await fourth_pos.ClickAsync();
		Assert.That(await fourth_pos.InnerTextAsync(), Is.EqualTo("4"), "Cell should show the expected text after click.");

		// Test for clicking on "McLaren Racing"
		var fourth_team = Page.GetByRole(AriaRole.Cell, new() { Name = "McLaren Racing" });
		await fourth_team.ClickAsync();
		Assert.That(await fourth_team.InnerTextAsync(), Is.EqualTo("McLaren Racing"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "302"
		var fourth_points = Page.GetByRole(AriaRole.Cell, new() { Name = "302" });
		await fourth_points.ClickAsync();
		Assert.That(await fourth_points.InnerTextAsync(), Is.EqualTo("302"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "5"
		var fifth_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "5", Exact = true });
		await fifth_pos.ClickAsync();
		Assert.That(await fifth_pos.InnerTextAsync(), Is.EqualTo("5"), "Cell should show the expected text after click.");

		// Test for clicking on "Aston Martin F1 Team"
		var fifth_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Aston Martin F1 Team" });
		await fifth_team.ClickAsync();
		Assert.That(await fifth_team.InnerTextAsync(), Is.EqualTo("Aston Martin F1 Team"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "280"
		var fifth_points = Page.GetByRole(AriaRole.Cell, new() { Name = "280" });
		await fifth_points.ClickAsync();
		Assert.That(await fifth_points.InnerTextAsync(), Is.EqualTo("280"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "6"
		var sixth_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "6", Exact = true });
		await sixth_pos.ClickAsync();
		Assert.That(await sixth_pos.InnerTextAsync(), Is.EqualTo("6"), "Cell should show the expected text after click.");

		// Test for clicking on "Alpine F1 Team"
		var sixth_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Alpine F1 Team" });
		await sixth_team.ClickAsync();
		Assert.That(await sixth_team.InnerTextAsync(), Is.EqualTo("Alpine F1 Team"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "120"
		var sixth_points = Page.GetByRole(AriaRole.Cell, new() { Name = "120" });
		await sixth_points.ClickAsync();
		Assert.That(await sixth_points.InnerTextAsync(), Is.EqualTo("120"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "7"
		var seventh_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "7" });
		await seventh_pos.ClickAsync();
		Assert.That(await seventh_pos.InnerTextAsync(), Is.EqualTo("7"), "Cell should show the expected text after click.");

		// Test for clicking on "Williams F1 Team"
		var seventh_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Williams F1 Team" });
		await seventh_team.ClickAsync();
		Assert.That(await seventh_team.InnerTextAsync(), Is.EqualTo("Williams F1 Team"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "28"
		var seventh_points = Page.GetByRole(AriaRole.Cell, new() { Name = "28", Exact = true });
		await seventh_points.ClickAsync();
		Assert.That(await seventh_points.InnerTextAsync(), Is.EqualTo("28"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "8"
		var eigth_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "8", Exact = true });
		await eigth_pos.ClickAsync();
		Assert.That(await eigth_pos.InnerTextAsync(), Is.EqualTo("8"), "Cell should show the expected text after click.");

		// Test for clicking on "Scuderia AlphaTauri Honda"
		var eight_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Scuderia AlphaTauri Honda" });
		await eight_team.ClickAsync();
		Assert.That(await eight_team.InnerTextAsync(), Is.EqualTo("Scuderia AlphaTauri Honda"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "25"
		var eigth_points = Page.GetByRole(AriaRole.Cell, new() { Name = "25" });
		await eigth_points.ClickAsync();
		Assert.That(await eigth_points.InnerTextAsync(), Is.EqualTo("25"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "9"
		var ninth_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "9", Exact = true });
		await ninth_pos.ClickAsync();
		Assert.That(await ninth_pos.InnerTextAsync(), Is.EqualTo("9"), "Cell should show the expected text after click.");

		// Test for clicking on "Alfa Romeo"
		var ninth_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Alfa Romeo" });
		await ninth_team.ClickAsync();
		Assert.That(await ninth_team.InnerTextAsync(), Is.EqualTo("Alfa Romeo"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "16"
		var ninth_points = Page.GetByRole(AriaRole.Cell, new() { Name = "16" });
		await ninth_points.ClickAsync();
		Assert.That(await ninth_points.InnerTextAsync(), Is.EqualTo("16"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "10"
		var tenth_pos = Page.GetByRole(AriaRole.Cell, new() { Name = "10" });
		await tenth_pos.ClickAsync();
		Assert.That(await tenth_pos.InnerTextAsync(), Is.EqualTo("10"), "Cell should show the expected text after click.");

		// Test for clicking on "Haas F1 Team"
		var tenth_team = Page.GetByRole(AriaRole.Cell, new() { Name = "Haas F1 Team" });
		await tenth_team.ClickAsync();
		Assert.That(await tenth_team.InnerTextAsync(), Is.EqualTo("Haas F1 Team"), "Cell should show the expected text after click.");

		// Test for clicking on cell with name "12"
		var tenth_points = Page.GetByRole(AriaRole.Cell, new() { Name = "12", Exact = true });
		await tenth_points.ClickAsync();
		Assert.That(await tenth_points.InnerTextAsync(), Is.EqualTo("12"), "Cell should show the expected text after click.");
	}

	[Test]
	public async Task DriverSearchTest()

	{
		await Page.GotoAsync("https://maxwitalec01.github.io/CA3F1/");

		// Click on Driver Search page on the nav bar
		await Page.GetByRole(AriaRole.Link, new() { Name = "Driver Search" }).ClickAsync();

		// Click on the search bar
		await Page.GetByPlaceholder("Lewis").ClickAsync();

		// Type in "Lewis" into the search bar
		await Page.GetByPlaceholder("Lewis").FillAsync("Lewis");

		// Click on the search button
		await Page.GetByRole(AriaRole.Button, new() { Name = "Search" }).ClickAsync();

		// Assert that the name "Lewis Hamilton // Mercedes-" appears
		var lewisHamilton = Page.GetByRole(AriaRole.Heading, new() { Name = "Lewis Hamilton // Mercedes-AMG Petronas" });
		Assert.That(await lewisHamilton.InnerTextAsync(), Is.EqualTo("Lewis Hamilton // Mercedes-AMG Petronas"), "Lewis Hamilton's name should be correctly displayed.");

		// Assert that he has 197 podiums
		var podiums = Page.GetByText("Podiums 197");
		Assert.That(await podiums.InnerTextAsync(), Is.EqualTo("Podiums\n197"), "Podium count should be correctly displayed.");

		// Assert that he has 4639.5 career points
		var careerPoints = Page.GetByText("Career Points 4639.5").First;
		Assert.That(await careerPoints.InnerTextAsync(), Is.EqualTo("Career Points\n4639.5"), "Career points should be correctly displayed.");

		// Assert that he entered 332 Grand Prix
		var grandPrixEntered = Page.GetByText("Grand Prix Entered 332").First;
		Assert.That(await grandPrixEntered.InnerTextAsync(), Is.EqualTo("Grand Prix Entered\n332"), "Number of Grand Prix entered should be correctly displayed.");

		// Assert that he has 7 World Championships
		var worldChampionships = Page.GetByText("World Championships 7").First;
		Assert.That(await worldChampionships.InnerTextAsync(), Is.EqualTo("World Championships\n7"), "World Championships count should be correctly displayed.");

		await Page.GetByRole(AriaRole.Button, new() { Name = "More Information" }).ClickAsync();

		// Assert his driver number is 44
		await Page.GetByRole(AriaRole.Rowheader, new() { Name = "Driver Number" }).ClickAsync();
		var driverNumber = Page.GetByRole(AriaRole.Cell, new() { Name = "44" });
		Assert.That(await driverNumber.InnerTextAsync(), Is.EqualTo("44"), "Driver number should be correctly displayed.");

		// Assert his birthday is 1985-01-07
		await Page.GetByRole(AriaRole.Rowheader, new() { Name = "Birthday" }).ClickAsync();
		var birthday = Page.GetByRole(AriaRole.Cell, new() { Name = "1985-01-07" });
		Assert.That(await birthday.InnerTextAsync(), Is.EqualTo("1985-01-07"), "Birthday should be correctly displayed.");
	}


	[Test]
	public async Task TeamSearchTest()
	{
		await Page.GotoAsync("https://maxwitalec01.github.io/CA3F1/");

		// Click on Team Search link
		await Page.GetByRole(AriaRole.Link, new() { Name = "Team Search" }).ClickAsync();

		// Click on the search bar and type "Mercedes"
		await Page.GetByPlaceholder("Mercedes").ClickAsync();
		await Page.GetByPlaceholder("Mercedes").FillAsync("Mercedes");

		// Click the search button
		await Page.GetByRole(AriaRole.Button, new() { Name = "Search" }).ClickAsync();

		// Assert "World Championships 8"
		var worldChampionships = Page.GetByText("World Championships 8").First;
		Assert.That(await worldChampionships.InnerTextAsync(), Is.EqualTo("World Championships\n8"), "World Championships count should be correctly displayed.");

		// Assert "Director Toto Wolff"
		var directorTotoWolff = Page.GetByText("Director Toto Wolff").First;
		Assert.That(await directorTotoWolff.InnerTextAsync(), Is.EqualTo("Director\nToto Wolff"), "Director's name should be correctly displayed.");

		// Assert "Chassis W14"
		var chassisW14 = Page.GetByText("Chassis W14").First;
		Assert.That(await chassisW14.InnerTextAsync(), Is.EqualTo("Chassis\nW14"), "Chassis information should be correctly displayed.");

		// Assert "President Markus Schäfer"
		var presidentMarkusSchäfer = Page.GetByText("President Markus Schäfer").First;
		Assert.That(await presidentMarkusSchäfer.InnerTextAsync(), Is.EqualTo("President\nMarkus Schäfer"), "President's name should be correctly displayed.");

		// Click on "More Information" button
		await Page.GetByRole(AriaRole.Button, new() { Name = "More Information" }).ClickAsync();

		// Assert "Team Tyres" as "Pirelli"
		await Page.GetByRole(AriaRole.Rowheader, new() { Name = "Team Tyres" }).ClickAsync();
		var teamTyresPirelli = Page.GetByRole(AriaRole.Cell, new() { Name = "Pirelli" });
		Assert.That(await teamTyresPirelli.InnerTextAsync(), Is.EqualTo("Pirelli"), "Team tyres should be correctly displayed as Pirelli.");

		// Assert "President" as "Markus Schäfer"
		await Page.GetByRole(AriaRole.Rowheader, new() { Name = "President" }).ClickAsync();
		var presidentMarkus = Page.GetByRole(AriaRole.Cell, new() { Name = "Markus Schäfer" });
		Assert.That(await presidentMarkus.InnerTextAsync(), Is.EqualTo("Markus Schäfer"), "President's name should be correctly displayed.");

		// Assert "World Championships" count as "8"
		await Page.GetByRole(AriaRole.Row, new() { Name = "World Championships 8" }).GetByRole(AriaRole.Rowheader).ClickAsync();
		var worldChampionshipsCount = Page.GetByRole(AriaRole.Cell, new() { Name = "8" });
		Assert.That(await worldChampionshipsCount.InnerTextAsync(), Is.EqualTo("8"), "World Championships count should be correctly displayed.");
	}

}