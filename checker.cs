using System;
using System.Diagnostics;
class Checker
{
    public static void Main()
    {
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        var check_bpm = (bpm < 70 || bpm > 150);
        var check_spo2 = (spo2 < 90);
        var check_respRate = (respRate < 30 || respRate > 95);
        if( check_bpm || check_spo2 || check_respRate)
        return false;
        return true;
        }
    }
    static int Main() {
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
