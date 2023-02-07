
namespace RestSharpApiAutomationProject2;
public class StarWarsAPITests
{
    StarWarsPage starWarsPage;
    public StarWarsAPITests()
    {
        starWarsPage = new StarWarsPage();
    }

    [Test,Order(1)]
    public void GetStarWarsFilmsBYActor()
    {
        starWarsPage.GetFilmsByActor();
    }

    [Test,Order(2)]
    public void DisplayFilmsByActorByResponseOfTest1()
    {
        starWarsPage.ListFilmsByActor();
    }

    [Test,Order(3)]
    public void DisplayStarShips()
    {
        starWarsPage.GetAllStarWarsStarships();
    }
}
