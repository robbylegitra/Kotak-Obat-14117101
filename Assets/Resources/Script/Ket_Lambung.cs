using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ket_Lambung : MonoBehaviour
{
    public GameObject suara;

    public void OpenSuara()
    {
        if(suara != null)
        {
            suara.SetActive(true);
        }
    }
}
