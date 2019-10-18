using UnityEngine;

namespace strategy
{
    public class SeekWithGPS : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Seeking target with GPS coordinates");
        }
    }
}