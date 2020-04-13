using System;
using System.Collections.Generic;
using System.Text;

namespace pic
{
    class PicObj
    {
        public string name;
        public string url;
        public string dinotype;
        public string dinosize;

        public  PicObj(string name, string url, string dinotype, string dinosize)
        {
            this.name = name;
            this.url = url;
            this.dinotype = dinotype;
            this.dinosize = dinosize;
        }

    }
    
}