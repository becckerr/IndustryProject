using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceCellToDeactivate : MonoBehaviour
{
    public GameObject Powercell;

    public GameObject Obj;

    void Update()
    {
        if (Powercell.activeSelf)
        {
            Obj.SetActive(true);
        }
        if (!Powercell.activeSelf)
        {
            Obj.SetActive(false);
        }
    }
}
