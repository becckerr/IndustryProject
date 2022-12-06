using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoCellsToAct : MonoBehaviour
{
    public GameObject Powercell1;
    public GameObject Powercell2;

    public GameObject Obj;

    public AudioSource open;
    public AudioSource close;

    void Update()
    {
        if ((Powercell1.activeSelf) && (Powercell2.activeSelf))
        {
            Obj.SetActive(false);

            open.Play();
        }
        else if ((!Powercell1.activeSelf) || (!Powercell2.activeSelf))
        {
            Obj.SetActive(true);

            close.Play();
        }
    }
}
