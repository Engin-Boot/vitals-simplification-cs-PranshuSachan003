using System;
using System.Diagnostics;
class Vital
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
}