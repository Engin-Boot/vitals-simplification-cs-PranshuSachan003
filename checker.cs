using System;
using System.Diagnostics;
    
class Checker
{
    static bool bpmIsOk(float bpm,float minBpm,float maxBpm)
    {
        if(bpm<minBpm||bpm>maxBpm)
            return false;
        return true;
    }
    static bool spo2IsOk(float spo2,float minSpo2)
    {
        if(spo2<minSpo2)
            return false;
        return true;
    }
    static bool respRateIsOk(float respRate,float minRespRate,float maxRespRate)
    {
        if(respRate<minRespRate||respRate>maxRespRate)
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
    static bool bpmAndSpo2AreOk(float bpm, float spo2)
    {
        if(bpmIsOk(bpm,70,150) && spo2IsOk(spo2,90))
            return true;
        return false;
    }
    public static void Main()
    {
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        if( bpmAndSpo2AreOk(bpm,spo2) && respRateIsOk(respRate,30,95) )
            return true;
        return false;
        }
  }
}
