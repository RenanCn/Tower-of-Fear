using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    public void loadLevel(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}