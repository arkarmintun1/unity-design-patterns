namespace strategy
{
    public class Tomahawk: Missile
    {
        void Awake()
        {
            this.seekBehaviour = new SeekWithGPS();
        }
    }
}