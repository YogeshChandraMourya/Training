using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EvokeWebApi.Models
{
    public class TimerClass:ITimer
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
