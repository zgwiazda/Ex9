﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TripsController : ControllerBase
{
    private readonly ApbdContext _context;

    public TripsController(ApbdContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> GetTrips()
    {

        var context = new ApbdContext();
        var trips = await _context.Trips.ToListAsync();
        return Ok(trips);
    }
    
}