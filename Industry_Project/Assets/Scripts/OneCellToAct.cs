using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneCellToAct : MonoBehaviour
{
    public GameObject Powercell;

    public GameObject Obj;

    public AudioSource open;
    public AudioSource close;

    void Update()
    {
        if (Powercell.activeSelf)
        {
            Obj.SetActive(false);

            open.Play();
        }
        if (!Powercell.activeSelf)
        {
            Obj.SetActive(true);

            close.Play();
        }
    }
}
