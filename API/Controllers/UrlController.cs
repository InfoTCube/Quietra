using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers;

public class UrlController : BaseApiController
{
    private readonly ILogger<UrlController> _logger;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public UrlController(ILogger<UrlController> logger, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    [HttpGet("{text}")]
    public async Task<ActionResult<string>> GetTarget(string text)
    {
        Url url = await _unitOfWork.UrlRepository.GetUrlByTextAsync(text);

        if(url is null) return BadRequest("This address does not exist.");

        return Ok(url.Target);
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<UrlDto>> CreateUrl(CreateUrlDto createUrlDto)
    {
        Url url = new Url
        {
            Text = await _unitOfWork.UrlRepository.GenerateUniqueText(createUrlDto.Target),
            Target = createUrlDto.Target
        };
        string username = User.GetUsername();
        url.Author = await _unitOfWork.UserRepository.GetUserByUsernameAsync(username);
        
        await _unitOfWork.UrlRepository.AddUrlAsync(url);
        await _unitOfWork.Complete();

        return _mapper.Map<UrlDto>(url);
    }
}