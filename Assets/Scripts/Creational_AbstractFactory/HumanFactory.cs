﻿namespace abstractfactory
{
    public class HumanFactory : AbstractFactory
    {
        public override IAnimal GetAnimal(AnimalType animalType)
        {
            return null;
        }

        public override IHuman GetHuman(HumanType humanType)
        {
            switch (humanType)
            {
                case HumanType.Beggar:
                    IHuman beggar = new Beggar();
                    return beggar;
                case HumanType.Farmer:
                    IHuman farmer = new Farmer();
                    return farmer;
                case HumanType.Shopowner:
                    IHuman shopowner = new Shopowner();
                    return shopowner;
            }
            return null;
        }
    }
}
