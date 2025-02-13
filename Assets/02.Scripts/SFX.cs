using UnityEngine;

public class SFX : MonoBehaviour
{
    public SoundManager.SFX soundEffect;  //  효과음 종류 (Inspector에서 설정 가능)

    public void PlayEffect()
    {
        SoundManager.Instance.playSFX(soundEffect);  //  선택한 효과음 재생
    }
}
