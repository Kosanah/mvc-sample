using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index() => View(new HomeViewModel("Hello from MVC", DateTime.UtcNow));
}
public record HomeViewModel(string Title, DateTime GeneratedAt);
