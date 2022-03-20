using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

[ApiController]
[Route("[controller]")]
public class HesController : ControllerBase
{
    private IHesService _HesService;

    public HesController(IHesService HesService)
    {
        _HesService = HesService;
    }

    [HttpGet]
    public async Task<ServiceResponse<List<HesCode>>> GetAllHesCode(){
        return await _HesService.GetAllHesCodes();
    }
    [HttpPost]
    public async Task<ServiceResponse<string>> CreateHesCode(HesDTO hesDTO){
        return await _HesService.CreateHesCode(hesDTO);
    }
    
    [HttpGet("Qr")]
    public ActionResult GenerateQr(string test){
        
        QRCodeGenerator qRCodeGenerator=new QRCodeGenerator();
            QRCodeData qRCodeData=qRCodeGenerator.CreateQrCode(test,QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode=new QRCode(qRCodeData);
            Image qrcodeimage=qRCode.GetGraphic(20);
            var bytes=QrGenerator.imagetoarray(qrcodeimage);
            return File(bytes,"image/bmp");
    }
}