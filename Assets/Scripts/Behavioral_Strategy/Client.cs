using UnityEngine;

namespace strategy
{
    public class Client: MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                // Applying default seeking behaviour to missles.
                Missile sideWinder = ScriptableObject.CreateInstance<SideWinder>();
                sideWinder.ApplySeek();

                Missile tomahawk = ScriptableObject.CreateInstance<Tomahawk>();
                tomahawk.ApplySeek();

                Missile torpedo = ScriptableObject.CreateInstance<Torpedo>();
                torpedo.ApplySeek();

                // Applying custom seeking behaviour to a SideWinder
                Missile sideWinderWithSonar = ScriptableObject.CreateInstance<SideWinder>();
                ISeekBehaviour sonar = new SeekWithSonar();
                sideWinderWithSonar.SetSeekBehavior(sonar);
                sideWinderWithSonar.ApplySeek();
            }
        }
    }
}