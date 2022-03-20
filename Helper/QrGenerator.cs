using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
public static class QrGenerator{
    public static byte[] imagetoarray(System.Drawing.Image image){
        MemoryStream ms=new MemoryStream();
        image.Save(ms,ImageFormat.Png);
        return ms.ToArray();
}
}