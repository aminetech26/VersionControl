
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
     //c# classes and objects
    class Cars
    {
      public string color  = "red"; // we created a class with attributes color "red"
      /*static void Main(string[] args){
        //this is how we can create an object
        // to create an object : Classname Myobj = new Classname();
         Cars Myobj =new Cars();
         Console.WriteLine(Myobj.color);
         // we can creat multiple objects of one class
         Cars myobj1=new Cars();
         Cars myobj2=new Cars();
         myobj1.color = "white";
         Console.WriteLine(myobj1.color);
         Console.WriteLine(myobj2.color);


      }*/


    }
    class Car{
      public string color ; // this is a field
      public int maxspeed;  // this is also a field
      public string modele;
      // by default all class members are private .........................
      public void Fullspeed(){   // this is what we call a methode 
        Console.WriteLine("the car is as fast as it can !!");
      }
      // and field , methods considered as class members ..........

      // we can initials our fields with this constructor 
      public Car(){
        color = "white";
        maxspeed = 300;
        //modele = "sport"; // these are the initial values of any object in this class 
      }
      // we can pass parametres also to our constructors so we can use it to intialise it in the declaration
      public Car(string modelname){
        modele = modelname;
      }
    }
    // C# inheritence ...........
      // vehicules class is the base class parents which contain the brand and can contain (cars,camion,bus,planes...)
    class Vehicules{
      public string vehiculetype;
      public string brand;
      public void vol(){
        Console.WriteLine("im something that can make u in another place faster !!");
      }
    }
      // this is the deriverd class and it's a child of vehicules 
      class Bus : Vehicules {
           public string model;
           public string color;
           public int maxspeed;
      }
      //If you don't want other classes to inherit from a class, use the sealed keyword
        sealed class vehicl{
          public string maxplaces;
        }

     /* class bycicle : vehicl {  // this is the error ..........
        int size ;
      }
      */
      

    }

