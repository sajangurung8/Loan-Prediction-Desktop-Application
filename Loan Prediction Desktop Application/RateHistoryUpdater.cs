using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    // defination for RateHistoryUpdater to update history.txt to compare older rates
    class RateHistoryUpdater
    {
        // feild for file name
        private string file = "history.txt";
        
        //ctor
        public RateHistoryUpdater()
        {

        }

        // method returns data from the file, if no data or file not present returns exception message
        public string[] checkHistory()
        {
            try
            {
                string line;
                var systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string pathWithFile = Path.Combine(systemPath, file);
                StreamReader fc = new StreamReader(pathWithFile);
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
                StreamReader fout = new StreamReader(pathWithFile);
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

        // method to update file with new data
        public bool updateHistory(string[] data)
        {
            try
            {
                var systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string pathWithFile = Path.Combine(systemPath, file);
                StreamWriter fin = new StreamWriter(pathWithFile);
                foreach (string line in data)
                {
                    fin.WriteLine(line);
                    Console.WriteLine(line);
                }
                fin.Close();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
