using UnityEngine;

public class ShineEffectOn : MonoBehaviour
{
    ParticleSystem _particle;
    Animator _anim;

    private void Awake()
    {
        _particle = GetComponent<ParticleSystem>();
        _anim = GetComponent<Animator>();
    }

    public void OnEffectBright()
    {
        _particle.Play();
    }
    public void OffEffect()
    {
        _anim.SetTrigger("Off");
    }
    public void ActiveOff()
    {
        AnimationEventManager.Inst.PutInGift();
        gameObject.SetActive(false);
    }
}
