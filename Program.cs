
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project{
class Program{
static void Main (string[] args){
    string name = "12";
    Console.WriteLine("you are {0} years old",name);
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("I'm {0}",age);
    // this is how we can write a comment..............
    float mygrade = 13.88F ;
    Console.WriteLine("my grade : {0}",mygrade);

    //these are our different types of data  ....

    int numero = 106  ;
    char caracter='A';
    string myname ="akhrib abderahmane";
    double mymoyenne = 13.80;
    float sfsd = 4.5F;
    bool IMkhbach=false;

     //this is how we can declare a constant ... ...............................................................................

      const double PI=3.14; //we can't declare a const without a declaration also we can't change its value
     
     // how to combine two strings and display them in the console....................................................
     string gf= "wissam" ;
     Console.WriteLine("hii my "+ gf);
     string firstname="akhrib";
     string lastname="abderahmane";
     string myfullname= firstname + lastname ; // we can concat between two strings with str = str1 + str2
     Console.WriteLine("my full name : {0}",myfullname);


     // this is how we can declare multiple variabls with the same type.............................................
      int x,y=2,z=3;
      x=y*z;
      Console.WriteLine(x);

      // we can use num*10^p with this num=10e3;
      double num1= 10e3D;

      // C# sharp casting type
      // wwe can assigne a larger type to a smaller type like int -> Long

      int num2=200;
      double num3=num2;
      Console.WriteLine(num2);
      Console.WriteLine(num3);

      // Explicit casting 
      int myint;
      double mydouble = 9.98D;
      myint = (int) mydouble;
      // mydouble = 9.98  
      // myint = 9

      //types of conversion It is also possible to convert data types explicitly by using built-in methods, 
      //such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long): 
      bool mybool=true;
      double mydouble2=99.1234;
      Console.WriteLine(Convert.ToInt32(mybool));// the output will be an integer "1"
      Console.WriteLine(Convert.ToString(mydouble2));

      // how to get inputs from the user 
      Console.WriteLine("write your user name");
      // we use readline to get data from the console
      string username=Console.ReadLine();
      Console.WriteLine("the username is {0}",username);
      // note : the readline return only string data type from the console (no int ,no bool ......)
      int myage=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("my age is "+ age);

      //operators.. + ... - ... * ... / ... % ... ++ ... --
      int sum= 10+20; // sum = 30
      int produit= 12*5; // produit =60
      double module= 13 % 5 ; // % defines module (baqii lqisma ) 13=2*5+3 so module=3.....
      int quotion= 13 / 2; // "/" dir lqismaaa quotion = 5 
      // assignement (affectation)
      int myvar;
      myvar=10;
      // we can add a number to myvar with this syntax 
      myvar+=5;  // you can find all the operations here https://www.w3schools.com/cs/cs_operators_assignment.php
      

      // comparaison 
      Console.WriteLine(sum > myvar) ;// it will return true bcz 30 > 15 
                                      // == if equal
                                      // == if not equal
                                      // <= or >= .......

      // logical operators and , or ......
      Console.WriteLine(3 > 4 && 1 > 0); // && .... is and logic
                                         // || .... is or logic
                                         // ! ..... in not logic
     
     // THE C# MATH class and its methods 
         // math.max returns the max between x,y,z.....
     Console.WriteLine(Math.Max(20,10)); // 20 
         // there is min also 
     Console.WriteLine(Math.Min(10,9)); // 9
         // the root square of a number also and the absolute value 
     Console.WriteLine(Math.Sqrt(25)); // 5
     Console.WriteLine(Math.Abs(-4.5)); // | -4.5 | = 4.5
         // there is also round which return the nearest integer number to a number (float or ...)
     Console.WriteLine(Math.Round(5.7)); // returns 5

     // the c# string features that can be helpful for us .....
               // string length 
        string txt="abderahmane";
        Console.WriteLine("my name contains {0}  caracteres",txt.Length); // the result will be 11
               // toupper and tolower which consist in convertint upercase or lowercase of a string 
        string txt2="hey BRO";
        Console.WriteLine(txt2.ToUpper());// the result is "HEY BRO"
        Console.WriteLine(txt2.ToLower());// the result is "hey bro"
               // string concatenation
        string subject1 = "maths";
        string subject2 = "informatique";
        string myfieldname=string.Concat(subject1,subject2);
        Console.WriteLine(" I STUDY {0} in the university",myfieldname);
               // string interpolation
        string myfstname="akhrib";
        string mylstname="abderahmane";
           // now we r gonna combine between these two string inside another string to get a full message
        string myflname=$"my full name : {myfstname} {mylstname}"; 
        Console.WriteLine(myflname); // output : my full name : akhrib abderahmane 
               // access to characters in a string ... we now that a string is an array
        string txt3="wissam";
        Console.WriteLine(txt3[0]); // the output : W
        Console.WriteLine(txt3[3]); // the output : m
               //you can also find the index of a char in your string
        Console.WriteLine(txt3.IndexOf("a")); // returns 4 (start sounting from 0) and return -1 (null) if not found
               // substring is used to derive a part of string from the position u give also to the end
        txt3="wissam";
        int charpos=txt3.IndexOf("a");
        string tobei=txt3.Substring(charpos); 
        Console.WriteLine(tobei); // output : am
               // backslash will be usefule here cz we can't write name = "i love "vikings" so much "
               // cz " is a special char as ` and '....
        string avoidsc="i love \" vikings \" so much "; // this is how we can solve this issue 
        // C# Booleans 
        int votingage=19;
        bool canvote;
        int personage = Convert.ToInt32(Console.ReadLine());
        canvote = personage >= votingage ;
        if ( personage >= votingage)
        {
            Console.WriteLine("this person can vote !!");
        }
                 // or u can use 
        if (canvote)
        {
            Console.WriteLine("this person can vote !!"); 
        }
        

        // c# if ... else 

        myage = Convert.ToInt32(Console.ReadLine());
        if (myage >= 18 ) {
              Console.Write(" I'm legal ");
        }
            // we can add else 
         if (myage >= 18 ) {
              Console.Write(" I can drive a car ");
        }else{
              Console.WriteLine("i can not drive a car");
        }
            // we can do that also 
       int time =Convert.ToInt32(Console.ReadLine());
       if (time < 12 )
       {
              Console.WriteLine(" good morning");
       }else if (time < 18 )
          Console.WriteLine("good afternoon");
          else
          {
              Console.WriteLine("good evening");
          }

              // the is a short hand we can replace if ... else with   var = condition ? instrucs"true"  : instrucs"false"
              txt = myage >= 18 ? " I can drive a car " : " I can not drive a car ";
              Console.WriteLine(txt);
       // C# switch statement (case of)
       int day=Convert.ToInt32(Console.ReadLine());
       switch (day)
       {
              case 1: 
               Console.WriteLine(" day : lundi");
               break;
               case 2: 
               Console.WriteLine(" day : mardi");
               break;
               case 3: 
               Console.WriteLine(" day : mercredi");
               break;
               case 4: 
               Console.WriteLine(" day : jeudi");
               break;
               case 5: 
               Console.WriteLine(" day : vendredi");
               break;
               case 6: 
               Console.WriteLine(" day : samdi");
               break;
               case 7: 
               Console.WriteLine(" day : dimanche");
               break;
               default:
                   Console.WriteLine(" day not found ");
              break;
              
       }
       // C# while loop Tant Que 
        int i=0;
        while(i<=10){
            i=i+1; // we calculate 0+1+2..+10 ;
        }
        Console.WriteLine(i);
            // there is also the do while loop (repeat jusqu'a) it will excute at least once before
        i=0;
        do{
            i=i+1;;
        }while(i<=10);

        // C# for loop it's exactly the same with C
        for(int compteur=0;compteur<10;compteur++)
        {
            Console.WriteLine(compteur);
        }

        // foreach loop loop the boucle for each element of our inputs (array for example)
        string[] cars={"BMW","Mercedes","Porsh","lamborgini","chevrolli","ford"};
        foreach(string namofeachelement in cars)
        {
            Console.WriteLine("this car is : {0}",namofeachelement);
        }

        // c# break and continue ......................
        for(int cpt=0;cpt<=10;cpt++){
            if(cpt == 4)
            {
                break;
            }
            Console.WriteLine(cpt); // we write cpt from 0 to  10 but it will end in 4 and get out of the loop
                                    // out put 0 1 2 3 
        }

          for(int cpt2=0;cpt2<=10;cpt2++){
            if(cpt2 == 4)
            {
                continue;
            }
            Console.WriteLine(cpt2); // this will skip all the instructions after "continue" and move to the next iteration
                                    // output : 0 1 2 3 5 6 7 8 9 10.
        }   


        // C# Arrays ......
           // this is how we can declare an array of any type ...
        string[] animes={"death note", "one piece", "Naruto", "shingeki no kiojin"};
        int[] mygrades={ 20 , 19 , 13 , 18 ,17 , 15 }; 
           // access to an array elemnts 
        Console.WriteLine("my fav anime {0}",animes[0]);
        Console.WriteLine("my heighest grade : ",mygrades[0]);
           // change the value of an elemnt
           animes[3]= " attack on titan";
           // array length this is how we can find the array length ........
           Console.WriteLine("there is {0} animes in my liste ",animes.Length); // output 4
           // Create an array of four elements, and add values later
           string[] movies = new string[4] ;
           // Create an array of four elements and add values right away
           string[] series = new string[3] {"la casa de papel","breaking bad","GOT"} ;
           // Create an array of no specific elements numbres and add values right away
            string[] subjects = new string[] {"maths","science","english"};
            // loop through an array
            for(int j=0; j< series.Length;j++){
                Console.WriteLine("my fav series" + series[j]);
            }

            // we can use foreach better
            foreach(string serie in series){
                Console.WriteLine("my fav serie "+ serie);
            }

          // we can sort also the arrays like this 
          int[] mypoints =new int[5]{ 11 , 14 , 29 , 20 , 12 };
          Array.Sort(mypoints); // 11 12 14 20 29 
        //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
        Console.WriteLine("the somme of my pints : {0}", mypoints.Sum()); // returns the sum of the array
        

        // multidimesional arrays 
           // how to declare
           int[,] matrice={/* first row */ {1,-8,4,0} ,/* first row */ {6,3,7,23} }; // the coma shows that it's 2D array [,,] 3D ARRAY
           // access to elements 
           Console.WriteLine("row 0 column 2 : {0}",matrice[0,2]);
           // we use getlength instead of length here in multiD arrays .......................
                // matrice.getlength(0) == number of rows
                // matrice.getlength(1) == number of columns
            for(int raw=0; raw<matrice.GetLength(0);raw++)
            {
                for(int col=0;col < matrice.GetLength(1);col++)
                {
                    Console.WriteLine(matrice[raw,col]);
                }
            }


       //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         

        // C# methods .........................................................................

        procedure(); 

   }

    static void procedure(){
           // this is how we declare a procedure inside the class program and we use it in thw main() void
           Console.WriteLine("i just get executed !!");
    }
  }
 }