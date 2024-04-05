using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    private UnityEngine.SceneManagement.Scene scene;
    public void LvlUp()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

}
