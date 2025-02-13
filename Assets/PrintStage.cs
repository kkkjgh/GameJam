using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintStage : MonoBehaviour
{
    public Text stageText; 
    void Print()
    {
        stageText.text = LoopSystem.Instance.GetStage().ToString();
    }
}
