using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProniaTask.Models;
using ProniaTask.ViewModels.HomeVm;

namespace ProniaTask.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        Slider slider = new Slider()
        {
            Id = 1,
            Name = "Gulnara Jamal",
            Description = "heyat",
            PhotoUrl = "img1.jpeg",
            HeaderWord="Baliq burcu"
        };

        Slider slider2 = new Slider()
        {
            Id = 2,
            Name="Fatima Jamal",
            Description = "dunya",
            PhotoUrl = "img2.jpeg",
            HeaderWord="Aslan burcu"
            
        };

        Slider slider3 = new Slider()
        {
            Id = 3,
            Name = "Nazrin Karimova",
            Description = "sagool",
            PhotoUrl ="img3.jpeg",
            HeaderWord = "Baliq burcu"

        };

        Slider slider4 = new Slider()
        {
            Id = 4,
            Name = "Fizza Badalova",
            Description ="salamm",
            PhotoUrl ="img1.jpeg",
            HeaderWord = "Aslan burcu"
        };

        List<Slider> sliders = new List<Slider>();
        sliders.Add(slider);
        sliders.Add(slider2);
        sliders.Add(slider3);
        sliders.Add(slider4);



        List<Client> clients = new List<Client>();
        clients.Add(new Client()
        {
            Name = "Basti",
            Work = "IT",
            Description = "Cutie",
            PhotoUrl = "img1.jpeg"

        });

        clients.Add(new Client()
        {
            Name = "Gulnare",
            Work = "Pedagog",
            Description = "Devil",
            PhotoUrl = "img2.jpeg"

        });

        clients.Add(new Client()
        {
            Name = "Rukush",
            Work = "Muhasib",
            Description = "Evil",
            PhotoUrl = "img3.jpeg"

        });

        Vm vm = new Vm()
        {
            Sliders=sliders,
            Clients=clients
            
        };






        return View(vm);


    }



}

