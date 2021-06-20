using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    class RateHistoryUpdater
    {
        private string file = "Loan_Prediction_Desktop_Application.Resources.history.txt";
        public RateHistoryUpdater()
        {

        }

        public string[] checkHistory()
        {
            try
            {
                string line;
                Assembly asm = Assembly.GetExecutingAssembly();
                StreamReader fc = new StreamReader(asm.GetManifestResourceStream(file));
                int numOfLines = 0;
                while (fc.ReadLine() != null)
                {
                     numOfLines++;
                }
                fc.Close();
                if (numOfLines == 0)
                {
                    return new string[1] {""};
                }
                StreamReader fout = new StreamReader(asm.GetManifestResourceStream(file));
                string[] data = new string[numOfLines];
                int count = 0;
                line = fout.ReadLine();
                data[count] = line;
                while (line != null)
                {
                line = fout.ReadLine();
                if (line != null)
                {
                    count++;
                    data[count] = line;
                }
                    
                }
                fout.Close();
                return data;
            }catch(Exception e)
            {
                return new string[1] {e.Message};
            }

        }

        public bool updateHistory(string[] data)
        {
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                StreamWriter fin = new StreamWriter(asm.GetManifestResourceStream(file));
                foreach (string line in data)
                {
                    fin.WriteLine(line);
                }
                return true;
            }catch(Exception)
            {
                return false;
            }

        }
    }
}
