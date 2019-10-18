using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace singleton
{
    // <T> can be any type
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        // The instance is accessible only by the getter.
        private static T m_Instance;
        public static bool m_isQuitting;

        public static T Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    // Making sure that there's not other instances
                    m_Instance = FindObjectOfType<T>();

                    if (m_Instance == null)
                    {
                        GameObject obj = new GameObject();
                        obj.name = typeof(T).Name;
                        m_Instance = obj.AddComponent<T>();
                    }
                }
                return m_Instance;
            }
        }

        // Virtual Awake() that can be overwritten in a derived class.
        public virtual void Awake()
        {
            if (m_Instance == null)
            {
                // If null, this instance is now the Singleton instance
                m_Instance = this as T;

                // Making sure that Singleton instance will persist in memory across scene
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                // Destroy current instance
                Destroy(gameObject);
            }
        }
    }
}
