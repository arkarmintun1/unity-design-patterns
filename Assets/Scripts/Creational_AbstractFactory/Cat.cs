using UnityEngine;

namespace abstractfactory
{
    public class Cat : IAnimal
    {
        public void Voice()
        {
            Debug.Log("Cat: Meow!");
        }
    }
}