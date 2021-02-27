using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
   [SerializeField] int breakableBlock;

    //cached reference
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlock++;
    }

    public void BlockDestroyed()
    {
        breakableBlock--;

        if (breakableBlock <= 0)
        {
            sceneLoader.loadnextScene();
        }

       
    }

}
