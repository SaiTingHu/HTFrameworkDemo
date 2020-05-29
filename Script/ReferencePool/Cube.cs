namespace HT.Framework.Demo
{
    public class Cube : IReference
    {
        public void Reset()
        {
            Log.Info("一个 Cube 被回收！ HashCode：" + GetHashCode());
        }
    }
}