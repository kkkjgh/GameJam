using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falseActive : MonoBehaviour
{
    public GameObject obj;
    public void FalseActive()
    {
        obj.SetActive(false);
    }
}
