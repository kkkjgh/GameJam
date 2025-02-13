using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    private ButtonManager buttonManager; // ButtonManager를 참조할 변수

    public bool flag;
    public void next()
    {
        if (flag)
        {
            LoopSystem.Instance.GoToNextScene();
        }
    }
}

