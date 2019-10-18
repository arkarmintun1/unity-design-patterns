using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace abstractfactory
{
    public class FactoryProducer : MonoBehaviour
    {
        public static AbstractFactory GetFactory(FactoryType factoryType)
        {
            switch(factoryType)
            {
                case FactoryType.Human:
                    AbstractFactory humanFactory = new HumanFactory();
                    return humanFactory;
                case FactoryType.Animal:
                    AbstractFactory animalFactory = new AnimalFactory();
                    return animalFactory;
            }
            return null;
        }
    }
}

