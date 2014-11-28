using eBdb.EpubReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryePub
{
    class Book
    {
        private Epub _epub;

        public Book(Epub epub)
        {
            _epub = epub;
        }

        //String Title
        //{
        //        get { return _epub.Title; }
        //        set { this = value; }
        //}

        private String ListToString(List<string> list)
        {
            if (list.Count == 0)
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
