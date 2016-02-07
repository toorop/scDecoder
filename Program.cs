using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace scDecoder
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new scDecoder());
        }
    }

    static class scEncoder
    {

        private const string alpha1 = "cdefghijklmnopqrstuvwxyz";
        private const string alpha2 = "fghijklmnopqrstuvwxyz";

        static IEnumerable<string> GetChuncks(string str)
        {
            return Enumerable.Range(0, str.Length / 4).Select(i => str.Substring(i * 4, 4));
        }

        static public string Decode(string encoded)
        {
            string decoded="";
            int index1, index2, index3, index4;

            IEnumerable<string> chuncks = GetChuncks(encoded);

            foreach (string chunck in chuncks)
            {
                Debug.WriteLine(chunck);
                index1 = alpha1.IndexOf(chunck[1]) + 1;
                index2 = alpha2.IndexOf(chunck[0]);
                index3 = alpha1.IndexOf(chunck[2]) + 1;
                index4 = alpha2.IndexOf(chunck[3]);
                decoded += (char)(index1 * 17 + index2);
                decoded += (char)(index3 * 17 + index4);
            }
            return decoded;
        }
    }
}
