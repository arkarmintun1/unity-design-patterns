﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class EnemySpawner : MonoBehaviour
    {
        public iCopyable m_Copy;

        public Enemy SpawnEnemy(Enemy prototype)
        {
            m_Copy = prototype.Copy();
            return (Enemy)m_Copy;
        }
    }
}

