namespace NewGuild.Combat
{
    public interface IHealth
    {
        public void SubtractHealth(int amount);

        public void AddHealth(int amount);
    }
}
