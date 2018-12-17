using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Photo
    {
        public long Id { get; set; }
        public string title { get; set; }
        public string fileName { get; set; }
        private string _key;
        
        //Post had a key so I added this in. Controller uses it. 
        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }
    }
}
