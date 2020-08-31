using System;
using System.Diagnostics;
class Checker
{
     static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    public static void Main() {
        ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        ExpectFalse(vitalsAreOk(50, 80, 20));
        ExpectFalse(vitalsAreOk(50, 80, 100));
        ExpectFalse(vitalsAreOk(160, 80, 20));
        ExpectFalse(vitalsAreOk(160, 80, 100));
        ExpectFalse(vitalsAreOk(160, 91, 92));
        ExpectFalse(vitalsAreOk(100, 80, 92));
        ExpectFalse(vitalsAreOk(100, 91, 20));
        ExpectFalse(vitalsAreOk(100, 91, 100));
        ExpectFalse(vitalsAreOk(70, 90, 30));
        ExpectFalse(vitalsAreOk(70, 90, 95));
        ExpectFalse(vitalsAreOk(150, 90, 30));
        ExpectFalse(vitalsAreOk(150, 90, 95));
        Console.WriteLine("All ok");
        return 0;
          }
    }
}
