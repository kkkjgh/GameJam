using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public bool flag;
    public void next()
    {
        if (flag)
        {
            LoopSystem.Instance.GoToNextScene();
        }
    }
}
