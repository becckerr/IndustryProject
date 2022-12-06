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
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 10))
            {
                if ((hit.transform.tag == "Powercell1") || (hit.transform.tag == "Powercellholder1"))
                {
                    Debug.Log("hit");

                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell1.activeSelf)
                        {
                            GameManager.PCCount =+ 1;

                            Powercell1.SetActive(false);
                        }
                        else if (!Powercell1.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell1.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell1.SetActive(false);
                        }
                        else if (!Powercell1.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell1.SetActive(true);
                        }
                    }
                }

                if ((hit.transform.tag == "Powercell2") || (hit.transform.tag == "Powercellholder2"))
                {
                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell2.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell2.SetActive(false);
                        }
                        else if (!Powercell2.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell2.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell2.SetActive(false);
                        }
                        else if (!Powercell2.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell2.SetActive(true);
                        }
                    }
                }

                if ((hit.transform.tag == "Powercell3") || (hit.transform.tag == "Powercellholder3"))
                {
                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell3.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell3.SetActive(false);
                        }
                        else if (!Powercell3.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell3.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell3.SetActive(false);
                        }
                        else if (!Powercell3.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell3.SetActive(true);
                        }
                    }
                }

                if ((hit.transform.tag == "Powercell4") || (hit.transform.tag == "Powercellholder4"))
                {
                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell4.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell4.SetActive(false);
                        }
                        else if (!Powercell4.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell4.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell4.SetActive(false);
                        }
                        else if (!Powercell4.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell4.SetActive(true);
                        }
                    }
                }

                if ((hit.transform.tag == "Powercell5") || (hit.transform.tag == "Powercellholder5"))
                {
                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell5.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell5.SetActive(false);
                        }
                        else if (!Powercell5.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell5.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell5.SetActive(false);
                        }
                        else if (!Powercell5.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell5.SetActive(true);
                        }
                    }
                }

                if ((hit.transform.tag == "Powercell6") || (hit.transform.tag == "Powercellholder6"))
                {
                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell6.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell6.SetActive(false);
                        }
                        else if (!Powercell6.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell6.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell6.SetActive(false);
                        }
                        else if (!Powercell6.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell6.SetActive(true);
                        }
                    }
                }

                if ((hit.transform.tag == "Powercell7") || (hit.transform.tag == "Powercellholder7"))
                {
                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell7.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell7.SetActive(false);
                        }
                        else if (!Powercell7.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell7.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell7.SetActive(false);
                        }
                        else if (!Powercell7.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell7.SetActive(true);
                        }
                    }
                }

                if ((hit.transform.tag == "Powercell8") || (hit.transform.tag == "Powercellholder8"))
                {
                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell8.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell8.SetActive(false);
                        }
                        else if (!Powercell8.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell8.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell8.SetActive(false);
                        }
                        else if (!Powercell8.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell8.SetActive(true);
                        }
                    }
                }

                if ((hit.transform.tag == "Powercell9") || (hit.transform.tag == "Powercellholder9"))
                {
                    if (GameManager.PCCount < 1)
                    {
                        if (Powercell9.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell9.SetActive(false);
                        }
                        else if (!Powercell9.activeSelf)
                        {
                            Debug.Log("No Cells?");
                        }
                    }
                    else if (GameManager.PCCount >= 1)
                    {
                        if (Powercell9.activeSelf)
                        {
                            GameManager.PCCount = +1;

                            Powercell9.SetActive(false);
                        }
                        else if (!Powercell9.activeSelf)
                        {
                            GameManager.PCCount = -1;

                            Powercell9.SetActive(true);
                        }
                    }
                }
            }
        }
    }
}
