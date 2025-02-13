using UnityEngine;
using System.Collections;

public class ClickSFX : MonoBehaviour
{
    public SoundManager.SFX soundEffect;  // 효과음 종류 (Inspector에서 설정 가능)
    public DisableObject disableObject;  // 비활성화할 오브젝트를 지정하는 DisableObject 참조

    // 이 함수는 오브젝트를 클릭할 때 실행됩니다.
    public void PlaySFXAndDisableObject()
    {
        // 먼저 효과음을 재생합니다.
        SoundManager.Instance.playSFX(soundEffect);
        Debug.Log("효과음 재생: " + soundEffect);

        // 소리가 끝난 후 비활성화 처리
        StartCoroutine(DisableAfterSound());
    }

    private IEnumerator DisableAfterSound()
    {
        // 소리의 길이에 맞춰 대기
        float soundDuration = SoundManager.Instance.GetSFXDuration(soundEffect);  // 효과음의 길이
        yield return new WaitForSeconds(soundDuration);

        // 오브젝트 비활성화
        if (disableObject != null)
        {
            disableObject.DisableTarget();  // 비활성화 함수 호출
        }
    }
}
