using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers;

public class UrlController : BaseApiController
{
    private readonly ILogger<UrlController> _logger;

    public UrlController(ILogger<UrlController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{text}")]
    public async Task<ActionResult<string>> GetTarget(string text)
    {
        
        return "";
    }
}