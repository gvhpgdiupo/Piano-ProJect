using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppPiano
{
    class Contact
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Contact(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public Contact() 
        { 

        }

        public override string ToString()
        {
            return Name + " " + Path;
        }
    }
}