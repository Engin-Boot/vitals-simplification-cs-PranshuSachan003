using System;
using System.Diagnostics;
class SPO2
{
 static bool SPO2isOk(float spo2)
    {
        if(spo2<90)
            return false;
         return true;   
    }
}
