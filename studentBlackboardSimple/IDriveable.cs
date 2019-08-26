namespace studentBlackboardSimple
{
    public interface IDriveable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();
    }
}