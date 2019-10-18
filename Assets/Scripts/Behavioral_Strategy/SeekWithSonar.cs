using UnityEngine;

namespace strategy
{
    public class SeekWithSonar : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Seeking with sonar.");
        }
    }
}