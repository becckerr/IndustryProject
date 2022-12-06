using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenu2 : MonoBehaviour
{
     public GameObject canvas;

    public GameObject veiw;
 
     void Update() {
         if ((Input.GetKeyDown("escape")) && (!canvas.activeSelf))
         {
             canvas.SetActive(true);

            Cursor.visible = true;

            veiw.GetComponent<MouseLook>().enabled = false;
        }
         else if ((Input.GetKeyDown("escape")) && (canvas.activeSelf))
        {
            canvas.SetActive(false);

            Cursor.visible = false;

            veiw.GetComponent<MouseLook>().enabled = true;
        }


     }

    public void togglemenu()
    {
        canvas.SetActive(false);

        Cursor.visible = false;

        veiw.GetComponent<MouseLook>().enabled = true;
    }
}
