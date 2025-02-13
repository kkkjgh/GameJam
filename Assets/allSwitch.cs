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
                gameObjects[i].GetComponent<StartFadeOut>().isTrigger = true;
            }
        }
    }
}
