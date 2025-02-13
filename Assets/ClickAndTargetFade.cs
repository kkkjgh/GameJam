using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAndTargetFade : MonoBehaviour, IPointerDownHandler
{
    public bool once = false;
    public GameObject target;
    public bool fade;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!once)
        {
            if (fade)
            {
                target.GetComponent<FadeInOut>().FadeIn(); 
                once = true;
            }
            else
            {
                target.GetComponent<FadeInOut>().FadeOut();
                once = true;
            }
                
        }
        
    }
}
