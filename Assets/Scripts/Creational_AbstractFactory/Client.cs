using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace abstractfactory
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner m_SpawnerNPC;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                m_SpawnerNPC.SpawnHumans();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                m_SpawnerNPC.SpawnAnimals();
            }
        }
    }
}
