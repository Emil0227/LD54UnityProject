using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class quitButton : MonoBehaviour
{
    public void OnPointerClick()
    {
        Application.Quit();
    }
}
