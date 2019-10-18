using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class Client : MonoBehaviour
    {
        public Drone m_Drone;
        public Sniper m_Sniper;
        public EnemySpawner m_Spawner;

        private Enemy m_Spawn;
        private int m_IncrementorDrone = 0;
        private int m_IncrementorSniper = 0;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                m_Spawn = m_Spawner.SpawnEnemy(m_Drone);

                m_Spawn.name = "Drone_Clone_" + ++m_IncrementorDrone;
                m_Spawn.transform.Translate(Vector3.forward * m_IncrementorDrone);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);

                m_Spawn.name = "Sniper_Clone_" + ++m_IncrementorSniper;
                m_Spawn.transform.Translate(Vector3.forward * ++m_IncrementorSniper);
            }
        }
    }
}
