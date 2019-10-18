namespace strategy
{
    public class Torpedo: Missile
    {
        void Awake()
        {
            this.seekBehaviour = new SeekWithSonar();
        }
    }
}