using System;
using System.Diagnostics;
    static bool bpmIsOk(float bpm)
    {
        if(bpm<70||bpm>150)
            return false;
        return true;
    }
    static bool spo2IsOk(float spo2)
    {
        if(spo2<90)
            return false;
        return true;
    }
    static bool respRateIsOk(float respRate)
    {
        if(respRate<30||respRate>95)
            return false;
        return true;
    }

class Checker
{
    public static void Main()
    {
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        if( bpmIsOk(bpm)|| spo2IsOk(spo2)||respRateIsOk(respRate) )
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
