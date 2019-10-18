using UnityEngine;

namespace Factory
{
    public class Shopowner : INPC
    {
        public void Speak()
        {
            Debug.Log("Do you wish to purchase something?");
        }
    }
}
