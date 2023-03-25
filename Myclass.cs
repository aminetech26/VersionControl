using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project1{

    class Myclass{
        private string name; // field
        public string Name{ //this is what we call a proprety ..................
            get {return name;}
            set { name = value;} 
        }
            
        }
    class shorthand{
        // this is how we can declare an automatique proprety .........
        public string Anime 
            {get;set;}

      // we will use inheritance here bus is a child of vehicules

        


    }
}
