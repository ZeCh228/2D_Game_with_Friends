using UnityEngine;

public interface IBarbaraLiskovMAG
{
    public void Cast();
    public void Damage();
}

public class Invoker : IBarbaraLiskovMAG
{
    public void Cast()
    {
        Debug.Log("SunStrike");
    }

    public void Damage()
    {
        throw new System.NotImplementedException();
    }

    public void FireBall()
    {
        Debug.Log("FireBall");
    }
}

public class OgreMag : IBarbaraLiskovMAG
{
    public void Cast()
    {
      Debug.Log("stan");
    }

    public void Damage()
    {
        throw new System.NotImplementedException();
    }
}