using UnityEngine;

public class SingltoneWithoutMonoBehaviour
{
    public static SingltoneWithoutMonoBehaviour instance
    {
        get 
        { 
            if(_instance == null) 
            {
                _instance = new SingltoneWithoutMonoBehaviour();
            }   
            return _instance;
        }
    }

    private static SingltoneWithoutMonoBehaviour _instance;

    public void Debuger()
    {
        Debug.Log("Singltone");
    }
}
