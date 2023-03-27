using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCellManager : MonoBehaviour
{
    GameManager gm;

    public int PCCount;

    public GameObject Selected;
    public GameObject PC;

    void Start()
    {
        gm = GameManager.instance;
    }

    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            //cast a ray
            if (Physics.Raycast(ray, out hit))
            {
                //sets hit object as a gameobject
                Selected = hit.collider.gameObject;

                //compare the tags to see if they're interactable
                if (Selected.tag == "PowerCell")
                {
                    Selected.SetActive(false);

                    //change the amount of cells you have
                    PCCount += 1;
                }

                if (Selected.tag == "PCHolder")
                {
                    //make sure you have powercells to use
                    if (PCCount >= 1)
                    {
                        //check the children for a powwercell tag and turn that object on
                        foreach (Transform child in Selected.transform)
                        {
                            if (child.CompareTag("PowerCell"))
                            {
                                child.gameObject.SetActive(true);

                                //change the amount of cells you have
                                PCCount -= 1;
                            }
                        }
                    }
                    else
                    {
                        Debug.Log("No Cells?");
                    }
                }

            }
        }
            
    }
}