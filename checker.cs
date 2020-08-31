using System;
using System.Diagnostics;
class Checker
{
    bool BpmIsOk(float bpm)
    {
        if(bpm < 70 || bpm > 150)
            return false;
        return true;
    }
    bool Spo2IsOk(float spo2)
    {
        if(spo2 < 90)
            return false;
        return true;
    }
    bool RespRateIsOk(float respRate)
    {
        if(respRate < 30 || respRate > 95)
            return false;
        return true;
    }
    public static void Main()
    {
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        if( BpmIsOk(bpm) || Spo2IsOk(spo2) || RespRateIsOk(respRate) )
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
