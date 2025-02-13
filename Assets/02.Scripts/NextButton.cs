using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    private ButtonManager buttonManager; // ButtonManager�� ������ ����

    public bool flag;
    public void next()
    {
        buttonManager = FindObjectOfType<ButtonManager>();
        flag = buttonManager.flag;
        if (flag)
        {
            LoopSystem.Instance.GoToNextScene();
        }
    }
}

