using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace VragenTool
{
    class ApplicationHandler
    {
        private static ApplicationHandler instance;
        private ApplicationHandler() {} 
        public static ApplicationHandler Instance
        {
            get
            {
                if (instance == null)
                    instance = new ApplicationHandler();
                return instance;
            }
        }

        protected Dictionary<int, Vraag> CurrentVragen;
        protected Dictionary<int, Vraag> VragenOver;
        protected Vraag CurrentVraag;
        protected int NextIndex;

        public void setFiles(List<string> filenames)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vraag>));
            List<Vraag> liAll = new List<Vraag>();

            foreach (string filename in filenames)
            {
                FileStream fs = new FileStream(Path.Combine(@"c:\users\henk\Documents\vragen\", filename), FileMode.Open);
                List<Vraag> liVragen = (List<Vraag>)serializer.Deserialize(fs);
                fs.Close();
                liAll.AddRange(liVragen);
            }

            liAll = shuffleVragen(liAll);

            int i = 0;
            CurrentVragen = new Dictionary<int, Vraag>();
            foreach (Vraag v in liAll)
            {
                CurrentVragen.Add(i, v);
                i++;
            }
            VragenOver = new Dictionary<int, Vraag>();
            foreach (KeyValuePair<int, Vraag> entry in CurrentVragen)
            {
                VragenOver.Add( entry.Key, entry.Value );
            }
            NextIndex = 0;
        }

        public List<Vraag> shuffleVragen(List<Vraag> Vragen)
        {
            Random rng = new Random();
            int n = Vragen.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = Vragen[k];
                Vragen[k] = Vragen[n];
                Vragen[n] = value;
            }
            return Vragen;
        }

        public List<string> getFileNames()
        {
            List<string> liFiles = new List<string>();
            string[] files = Directory.GetFiles(@"c:\users\henk\Documents\vragen\", "*.xml");
            foreach (string f in files)
            {
                FileInfo fi = new FileInfo(f);
                liFiles.Add(fi.Name);
            }
            return liFiles;
        }

        public int getTotalQuestions()
        {
            return CurrentVragen.Count;
        }

        public Vraag getNextQuestion()
        {
            Vraag toReturn = VragenOver[NextIndex];
            VragenOver.Remove(NextIndex);
            NextIndex++;            
            return toReturn;
        }

        public bool isFinished()
        {
            return !VragenOver.ContainsKey(NextIndex);
        }
    }
}
