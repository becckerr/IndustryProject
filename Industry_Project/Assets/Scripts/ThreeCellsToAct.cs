using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeCellsToAct : MonoBehaviour
{
    public GameObject Powercell1;
    public GameObject Powercell2;
    public GameObject Powercell3;

    public GameObject Obj;

    void Update()
    {
        if ((Powercell1.activeSelf) && (Powercell2.activeSelf) && (Powercell3.activeSelf))
        {
            Obj.SetActive(false);
        }
        else if ((!Powercell1.activeSelf) || (!Powercell2.activeSelf) || (Powercell3.activeSelf))
        {
            Obj.SetActive(true);
        }
    }
}
