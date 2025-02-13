using UnityEngine;
using UnityEngine.UI;

public class Paper_onofft : MonoBehaviour
{
    public GameObject objectToActivate; // 버튼을 눌렀을 때 활성화할 오브젝트

    public void OnButtonClick()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true); // 오브젝트 활성화
        }
    }
}
