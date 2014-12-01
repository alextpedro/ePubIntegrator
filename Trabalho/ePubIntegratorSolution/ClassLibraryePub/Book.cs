using eBdb.EpubReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryePub
{
    public class Book
    {
        private Epub _epub;

        public Book(Epub epub)
        {
            _epub = epub;
        }

        public String Title
        {
            get { return ListToString(_epub.Title); }
            set { Title = value; }
        }

        public String Contributer
        {
            get { return ListToString(_epub.Contributer); }
            set { Contributer = value; }
        }

        public String Coverage
        {
            get { return ListToString(_epub.Coverage); }
            set { Coverage = value; }
        }

        private String ListToString(List<string> list)
        {
            if (list.Count != 0)
            {
                String convert = "";
                Boolean isFirst = true;
                foreach (String str in list)
                {
                    if (isFirst)
                    {
                        convert = str;
                        isFirst = false;
                    }
                    else convert = convert + ", " + str;
                }
                return convert;
            } return "unknown";
        }
    }
}
