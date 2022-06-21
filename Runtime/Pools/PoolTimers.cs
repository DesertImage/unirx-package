using DesertImage.Timers;

namespace DesertImage.Pools
{
    public class PoolTimers : Pool<ITimer>
    {
        private int _timersCount;
        
        protected override ITimer CreateInstance()
        {
            var timer = new Timer(_timersCount);

            _timersCount++;
            
            return timer;
        }
    }
}