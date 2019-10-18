using UnityEngine;

namespace strategy
{
    public class SeekWithHeat : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Seeking target with heat signature");
        }
    }
}