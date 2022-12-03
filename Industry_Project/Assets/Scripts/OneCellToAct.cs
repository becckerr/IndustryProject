using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneCellToAct : MonoBehaviour
{
    public GameObject Powercell;

    public GameObject Obj;

    void Update()
    {
        if (Powercell.activeSelf)
        {
            Obj.SetActive(false);
        }
        else if (!Powercell.activeSelf)
        {
            Obj.SetActive(true);
        }
    }
}
