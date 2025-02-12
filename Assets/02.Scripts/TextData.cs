using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "TextData", menuName = "Scriptable Object/TextData", order = int.MaxValue)]
public class TextData : ScriptableObject
{
    [SerializeField]
    public Image img;
    [SerializeField]
    public List<string>text = new List<string>();
    
}
