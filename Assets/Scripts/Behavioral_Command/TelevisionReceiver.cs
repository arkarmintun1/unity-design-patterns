using UnityEngine;

namespace command
{
    class TelevisionReceiver : RemoteControlDevice
    {
        public override void TurnOff()
        {
            Debug.Log("TV turned on");
        }

        public override void TurnOn()
        {
            Debug.Log("TV turned off");
        }
    }
}