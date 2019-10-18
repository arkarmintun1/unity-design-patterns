﻿using UnityEngine;

namespace abstractfactory
{
    public class Beggar : IHuman
    {
        public void Speak()
        {
            Debug.Log("Beggar: Do you have some change to spare?");
        }
    }
}