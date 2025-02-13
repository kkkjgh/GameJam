using UnityEngine;
using System.Collections;

public class ClickSFX : MonoBehaviour
{
    public SoundManager.SFX soundEffect;  // ȿ���� ���� (Inspector���� ���� ����)
    public DisableObject disableObject;  // ��Ȱ��ȭ�� ������Ʈ�� �����ϴ� DisableObject ����

    // �� �Լ��� ������Ʈ�� Ŭ���� �� ����˴ϴ�.
    public void PlaySFXAndDisableObject()
    {
        // ���� ȿ������ ����մϴ�.
        SoundManager.Instance.playSFX(soundEffect);
        Debug.Log("ȿ���� ���: " + soundEffect);

        // �Ҹ��� ���� �� ��Ȱ��ȭ ó��
        StartCoroutine(DisableAfterSound());
    }

    private IEnumerator DisableAfterSound()
    {
        // �Ҹ��� ���̿� ���� ���
        float soundDuration = SoundManager.Instance.GetSFXDuration(soundEffect);  // ȿ������ ����
        yield return new WaitForSeconds(soundDuration);

        // ������Ʈ ��Ȱ��ȭ
        if (disableObject != null)
        {
            disableObject.DisableTarget();  // ��Ȱ��ȭ �Լ� ȣ��
        }
    }
}
