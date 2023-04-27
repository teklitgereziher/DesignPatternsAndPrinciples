using SolidPrinciples.ISP.ApplyISP.Interfaces;

namespace SolidPrinciples.ISP.ApplyISP.Clients
{
    public class HPLaserJet : IPrint, IScan, IFax
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done.");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done.");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done.");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scanning Done.");
            return true;
        }
    }
}
