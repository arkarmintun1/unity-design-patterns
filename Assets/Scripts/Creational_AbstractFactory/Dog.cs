using UnityEngine;

namespace abstractfactory
{
    public class Dog : IAnimal
    {
        public void Voice()
        {
            Debug.Log("Dog: Woof");
        }
    }
}