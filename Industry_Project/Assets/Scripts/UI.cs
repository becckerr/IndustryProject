using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] CanvasGroup dangerindicator;
    [SerializeField] Sight sight;
    [SerializeField] float dangerAlpha;

    
    private void Update() 
    {
        dangerAlpha = sight.seen / 300;
        dangerindicator.alpha = dangerAlpha;
    }
}
