using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoButton : MonoBehaviour
{
    public int sceneNum;
    public void Goto()
    {
        LoopSystem.Instance.GoToScene(sceneNum);
    }
}
