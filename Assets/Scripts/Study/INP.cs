using UnityEngine;

public class INP : MonoBehaviour
{
    private IBarbaraLiskovMAG CastSpell;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastSpell = new Invoker();
            CastSpell.Cast();
        }
        if (Input.GetMouseButtonDown(1))
        {
            CastSpell = new OgreMag();
            CastSpell.Cast();
        }
    }
}