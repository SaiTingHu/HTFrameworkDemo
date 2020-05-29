namespace HT.Framework.Demo
{
    public class Sphere : IReference
    {
        public void Reset()
        {
            Log.Info("一个 Sphere 被回收！ HashCode：" + GetHashCode());
        }
    }
}