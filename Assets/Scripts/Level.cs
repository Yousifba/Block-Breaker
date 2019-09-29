using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{

    // Cached refrences
    SceneLoader sceneLoader;

    int remainingBlocks = 0;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        remainingBlocks++;
    }

    public void breakBlock()
    {
        remainingBlocks--;
        if(remainingBlocks == 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
