using UnityEngine;

public class GiftOpenAnimation : MonoBehaviour
{
    Animator _anim;


    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public void GiftOpen()
    {
        _anim.SetTrigger("Start");
    }

    public void Restart()
    {
        AnimationEventManager.Inst.ResetUI();
    }
}
