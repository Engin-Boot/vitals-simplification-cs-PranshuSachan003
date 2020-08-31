using System;
using System.Diagnostics;
class BPM
{
  static bool BPMisOk(float bpm)
    {
        if(bpm<70||bpm>150)
            return false;
        return true;
    }
}
