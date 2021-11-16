
using Net.Codecrete.QrCodeGenerator;
namespace Market
{
    class Class1
    {
        public static void d()
        {
            var qr = QrCode.EncodeText("Hello, world!", QrCode.Ecc.Medium);
            using (var bitmap = qr.ToBitmap(4, 10))
            {
                bitmap.Save("qr-code.png");
            }
        }
    }
}
