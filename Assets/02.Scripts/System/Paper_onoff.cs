using UnityEngine;
using UnityEngine.UI;

public class Paper_onofft : MonoBehaviour
{
    public GameObject objectToActivate; // ��ư�� ������ �� Ȱ��ȭ�� ������Ʈ

    public void OnButtonClick()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true); // ������Ʈ Ȱ��ȭ
        }
    }
}
