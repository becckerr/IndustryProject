using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCells : MonoBehaviour
{
    GameManager gm;

    public GameObject Powercell1;
    public GameObject Powercell2;
    public GameObject Powercell3;
    public GameObject Powercell4;
    public GameObject Powercell5;
    public GameObject Powercell6;
    public GameObject Powercell7;
    public GameObject Powercell8;
    public GameObject Powercell9;

    void Start()
    {
        gm = GameManager.instance;
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 10))
            {
                if (hit.transform.tag == "powercell")
                {
                    if (GameManager.PCCount < 1)
                    {
                        GameManager.PCCount += 1;
                    }
                    else
                    {

                    }

                    Powercell1.SetActive(false);
                }
            }
        }
    }
}
