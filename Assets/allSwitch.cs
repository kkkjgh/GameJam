using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allSwitch : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();
    public bool flag;
    private void Update()
    {
        if (flag)
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                if(gameObjects[i].GetComponent<StartFadeOut>() != null)
                    gameObjects[i].GetComponent<StartFadeOut>().isTrigger = true;
                else if (gameObjects[i].GetComponent<StartFadeOutObj>() != null)
                    gameObjects[i].GetComponent<StartFadeOutObj>().isTrigger = true;
            }
            flag = false;
        }
    }
}
