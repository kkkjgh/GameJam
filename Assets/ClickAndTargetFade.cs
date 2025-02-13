using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAndTargetFade : MonoBehaviour, IPointerDownHandler
{
    public bool isChatEnd;
    public bool once = false;
    public GameObject target;
    public TypeEffect line;
    public bool fade;

    private void Start()
    {
        line = GameObject.Find("StoryLine").GetComponent<TypeEffect>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (line.typeEnd)
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
}
