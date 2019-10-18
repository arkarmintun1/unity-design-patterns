using UnityEngine;

namespace strategy
{
    public class SideWinder: Missile
    {
        void Awake()
        {
            this.seekBehaviour = new SeekWithHeat();
        }
    }
}