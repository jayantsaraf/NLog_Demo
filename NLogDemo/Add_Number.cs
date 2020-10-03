using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLogDemo
{
    public class Add_Number
    {
        NLog nLog = new NLog();
        public int Sum(int FirstNumber, int SecondNumber)
        {
            int result = FirstNumber + SecondNumber;
            if (FirstNumber==0 || SecondNumber==0)
            {
                nLog.LogDebug("Debug successful : Sum()");
                nLog.LogError("Input numbers can not be zero");
                nLog.LogWarn("First and Second number shouldnot be equal to 0");
                nLog.LogInfo("Sum method passed, Result" + result); 
            }
            return result;
        }
    }
}
