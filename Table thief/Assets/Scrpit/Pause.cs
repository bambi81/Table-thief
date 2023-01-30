using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pu;
    public void pua()
    {
        pu.SetActive(true);
    }
    public void pue()
    {
        pu.SetActive(false);
    }
    // Start is called before the first frame update

}
