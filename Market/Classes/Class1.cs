using Net.Codecrete.QrCodeGenerator;
namespace Market
{
    class Class1
    {
        public static void d()
        {
            var qr = QrCode.EncodeText("Hello, world!", QrCode.Ecc.Medium);
            
        }
    }
}
