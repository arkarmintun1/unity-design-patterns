using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class Enemy : MonoBehaviour, iCopyable
    {
        public iCopyable Copy()
        {
            return Instantiate(this);
        }
    }
}

