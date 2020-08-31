using System;
using System.Diagnostics;
class ExpectOfTrue
{

 static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
 }   
