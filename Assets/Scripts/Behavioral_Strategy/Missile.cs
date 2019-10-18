using UnityEngine;

namespace strategy
{
    abstract public class Missile: ScriptableObject
    {
        protected ISeekBehaviour seekBehaviour;

        public void ApplySeek()
        {
            seekBehaviour.Seek();
        }

        public void SetSeekBehavior(ISeekBehaviour seekType)
        {
            this.seekBehaviour = seekType;
        }
    }
}