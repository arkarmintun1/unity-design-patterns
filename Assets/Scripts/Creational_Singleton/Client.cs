using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace singleton
{
    public class Client : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                GameManager.Instance.InitializeGame();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                InventoryManager.Instance.AddItem(001);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                InventoryManager.Instance.RemoveItem(023);
            }
        }
    }
}
