using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoButton : MonoBehaviour
{
    public int sceneNum;
    public void Goto()
    {
        Debug.Log("����123132323" + sceneNum);
        LoopSystem.Instance.GoToScene(sceneNum);
    }
}
