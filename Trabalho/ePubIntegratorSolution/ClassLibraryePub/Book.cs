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
        private Boolean _Favorite;
        private Boolean _Bookmark;


        public Book(Epub epub)
        {
            _epub = epub;
            //Por default favorito e bookmarks estão OFF
            _Favorite = false;
            _Bookmark = false;
        }

        public String Title //Títulos
        {
            get { return ListToString(_epub.Title); }
            set { Title = value; }
        }
        public String Contributer //Contribuidores
        {
            get { return ListToString(_epub.Contributer); }
            set { Contributer = value; }
        }
        public String Creator //Criadores
        {
            get { return ListToString(_epub.Creator); }
            set { Creator = value; }
        }
        public String Date //Datas
        {
            get { return ListToString(_epub.Date); }
            set { Date = value; }
        }
        public String Description //Descrições
        {
            get { return ListToString(_epub.Description); }
            set { Description = value; }
        }
        public String Language //Linguas
        {
            get { return ListToString(_epub.Language); }
            set { Language = value; }
        }
        public String Publisher //Publicador
        {
            get { return ListToString(_epub.Publisher); }
            set { Publisher = value; }
        }
        public String Rights //Direitos
        {
            get { return ListToString(_epub.Rights); }
            set { Rights = value; }
        }
        public String Subject //Temáticas
        {
            get { return ListToString(_epub.Subject); }
            set { Subject = value; }
        }

        public Boolean Favorite //Favoritos
        {
            get { return _Favorite; }
            set { _Favorite = value; }
        }
        public Boolean Bookmark //Bookmarks (com TOC?, ainda n sei)
        {
            get { return _Bookmark; }
            set { _Bookmark = value; }
        }

        private String ListToString(List<String> list)
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
        private String ListToString(List<DateData> list)
        {
            if (list.Count != 0)
            {
                String convert = "";
                Boolean isFirst = true;
                foreach (DateData str in list)
                {
                    if (isFirst)
                    {
                        convert = str.ToString();
                        isFirst = false;
                    }
                    else convert = convert + ", " + str.ToString();
                }
                return convert;
            } return "unknown";
        }
    }
}
