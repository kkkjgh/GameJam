using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public void next()
    {
        LoopSystem.Instance.GoToNextScene();
    }
}
