using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public void ChangeGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}