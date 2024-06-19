using UnityEngine;
/*���� ���, ��� ����� ���� �� ���� ��������������� ���������� ���������*/

public class Singltone : MonoBehaviour
{
    public static Singltone Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        else 
        {
            Destroy(this);
        }     
    }


    public void Debuger() 
    {
        Debug.Log("Singltone");
    }
}


