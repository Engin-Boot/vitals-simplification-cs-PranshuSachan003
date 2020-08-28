using System;
using System.Diagnostics;
class TestCases
{
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
