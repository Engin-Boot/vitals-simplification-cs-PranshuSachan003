using System;
using System.Diagnostics;
class Checker
{
    public static void Main()
    {
        static bool RESPRATEisOk(float respRate)
    {
        if(respRate<30||respRate>95)
            return false;
        return true;   
    }
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        var check_bpm = BPMisOk(bpm);
        var check_spo2 = SPO2isOk(spo2);
        var check_respRate = RESPRATEisOk(respRate);
        if(check_bpm || check_spo2 || check_respRate)
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
