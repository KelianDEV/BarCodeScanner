using System;
using IronBarCode;

namespace BarCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var barcode = BarcodeWriter.CreateBarcode("First Barcode",BarcodeEncoding.Code128);
            
            barcode.SaveAsPng("Barcode.png");
            barcode.AddBarcodeValueTextBelowBarcode();


        }
    }
}
