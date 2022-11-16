using Microsoft.AspNetCore.Mvc;
using externalServices;
using System.Collections.Generic;

namespace SessionOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExternalUserController : ControllerBase
{
    private UserService _userService;
    public ExternalUserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route("get-external-users")]
    public IActionResult GetExternalUsers() 
    {
        List<externalServices.User> usersResult = _userService.GetExternalUsersAsync().Result;
        Console.WriteLine(usersResult[0].FirstName);
        return Ok(usersResult);
    }
}
