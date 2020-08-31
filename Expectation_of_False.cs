using System;
using System.Diagnostics;
class ExpectOfFalse
{
static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
 }   
