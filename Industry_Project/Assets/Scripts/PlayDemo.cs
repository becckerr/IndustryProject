using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayDemo : MonoBehaviour
{
    void playdemo()
    {
        SceneManager.LoadScene("Scene02");

        Debug.Log("Playing");
    }
}
