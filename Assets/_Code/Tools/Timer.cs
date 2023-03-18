using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

namespace HelpTools
{
    public static class Timer
    {
        public async static Task Wait(float waitTime)
        {
            float endTime = Time.time + waitTime;
            while (Time.time < endTime)
            {
                await Task.Yield();
            }
        }
    }
}

