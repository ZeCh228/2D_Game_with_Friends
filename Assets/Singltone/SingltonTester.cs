using UnityEngine;
using UnityEngine.SceneManagement;


//d
public class SingltonTester : MonoBehaviour
{
   
    // Update is called once per frame
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            Singltone.Instance.Debuger();
        }
        
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            SingltoneWithoutMonoBehaviour.instance.Debuger();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }
}
