﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class NPCSpawner : MonoBehaviour
    {
        public NPCFactory m_Factory;

        private INPC m_Farmer;
        private INPC m_Beggar;
        private INPC m_Shopowner;

        public void SpawnVillagers()
        {
            m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
            m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
            m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);

            m_Beggar.Speak();
            m_Farmer.Speak();
            m_Shopowner.Speak();
        }
    }
}

