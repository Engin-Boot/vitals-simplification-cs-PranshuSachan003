using System;
using System.Diagnostics;
class RESPRATE
{
    static bool RESPRATEisOk(float respRate)
    {
        if(respRate<30||respRate>95)
            return false;
        return true;   
    }
}
