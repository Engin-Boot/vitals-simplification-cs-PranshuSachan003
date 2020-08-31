using System;
using System.Diagnostics;
class Checker
{
    public static void Main()
    {
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        if(bpm < 70 || bpm > 150)
            return false;
        else if(spo2 < 90)
            return false;
        else if (respRate < 30 || respRate > 95)
            return false;
        return true;
        }
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
  }
}
