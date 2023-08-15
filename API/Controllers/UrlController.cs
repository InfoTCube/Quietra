using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers;

public class UrlController : BaseApiController
{
    private readonly ILogger<UrlController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public UrlController(ILogger<UrlController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    [HttpGet("{text}")]
    public async Task<ActionResult<string>> GetTarget(string text)
    {
        Url url = await _unitOfWork.UrlRepository.GetUrlByTextAsync(text);

        if(url is null) return BadRequest("This address does not exist.");

        return Ok(url.Target);
    }
}