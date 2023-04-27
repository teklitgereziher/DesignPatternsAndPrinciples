using SolidPrinciples.ISP.WithoutISP.Interface;

namespace SolidPrinciples.ISP.WithoutISP.Client
{
    public class HPLaserJet : IPrintTasks
    {
        public HPLaserJet() { }

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

        /// <summary>
        /// The class is forced to implement this method that do not use it.
        /// Segregation Interface principle should be applied to resolve this problem.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scanning Done.");
            return true;
        }
    }
}
