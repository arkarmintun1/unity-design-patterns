using UnityEngine;

namespace abstractfactory
{
    public class Farmer : IHuman
    {
        public void Speak()
        {
            Debug.Log("Farmer: You reap what you sow!");
        }
    }
}