using UnityEngine;

namespace command
{
    public class Client: MonoBehaviour
    {
        private RemoteControlDevice m_RadioReceiver;
        private RemoteControlDevice m_TelevisionReceiver;
        private RemoteControlDevice[] m_Devices = new RemoteControlDevice[2];

        private void Start()
        {
            m_RadioReceiver = new RadioReceiver();
            m_TelevisionReceiver = new TelevisionReceiver();

            m_Devices[0] = m_RadioReceiver;
            m_Devices[1] = m_TelevisionReceiver;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Command commandTV = new TurnOnCommand(m_Devices[0]);
                Command commandRadio = new TurnOnCommand(m_Devices[1]);

                Invoker invoker = new Invoker();

                invoker.SetCommand(commandTV);
                invoker.ExecuteCommand();

                invoker.SetCommand(commandRadio);
                invoker.ExecuteCommand();
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                Command commandKill = new KillSwitchCommand(m_Devices);
                Invoker invoker = new Invoker();
                invoker.SetCommand(commandKill);
                invoker.ExecuteCommand();
            }
        }
    }
}