using BgList.Models;
using Microsoft.AspNetCore.Mvc;

namespace BgList.Controllers;

[Microsoft.AspNetCore.Components.Route("[controller]")]
[ApiController]
public class SeedController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    private readonly ILogger<SeedController> _logger;

    public SeedController(ApplicationDbContext context, ILogger<SeedController> logger)
    {
        _context = context;
        _logger = logger;
    }
}