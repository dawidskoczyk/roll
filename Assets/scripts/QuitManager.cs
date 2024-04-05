using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager : MonoBehaviour
{
    public void quitGame()
    {
        Debug.Log("wyjœcie");
        Application.Quit();
    }
}
