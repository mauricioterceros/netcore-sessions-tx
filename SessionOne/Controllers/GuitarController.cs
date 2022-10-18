using Microsoft.AspNetCore.Mvc;
using CoreLogic;

namespace SessionOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GuitarController : ControllerBase
{
    private GuitarManager guitarMgr;

    // new GuitarController(guitarMager)
    public GuitarController(GuitarManager guitarMgr)
    {
        this.guitarMgr = guitarMgr;
    }

    [HttpGet]
    [Route("get-all-guitar-types")]
    public IActionResult GetGuitars()
    {
        return Ok(this.guitarMgr.GetAllGuitars());
    }

    [HttpGet]
    [Route("get-all-guitar-brands")]
    public IActionResult GetBrands()
    {
        return Ok(this.guitarMgr.GetAllBrands());
    }

    [HttpPost]
    [Route("create-guitar")]
    public IActionResult CreateGuitar(string guitarName)
    {
        this.guitarMgr.AddNewGuitar(guitarName);

        return Ok(this.guitarMgr.GetAllGuitars());
    }
}
