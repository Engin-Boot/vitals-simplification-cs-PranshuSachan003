using System;
using System.Diagnostics;
class ExpectTrue
{

 static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
 }   
