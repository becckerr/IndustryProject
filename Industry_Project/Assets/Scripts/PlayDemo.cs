using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayDemo : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("Scene002");

        Cursor.visible = false;

        Debug.Log("Playing");
    }
}