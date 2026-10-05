using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Drawing;
using System.Drawing.Imaging;

namespace Common.Database;

public class ImageConverter : ValueConverter<System.Drawing.Image, byte[]>
{
    public ImageConverter() :
            base(img => ConvertToBytes(img),
        bytes => ConvertToImage(bytes))
    {
    }

    private static Image ConvertToImage(byte[] bytes)
    {
        using var ms = new MemoryStream(bytes);
        return Image.FromStream(ms);
    }

    private static byte[] ConvertToBytes(Image image)
    {
        using var ms = new MemoryStream();
        image.Save(ms, ImageFormat.Png);
        return ms.ToArray();
    }
}
