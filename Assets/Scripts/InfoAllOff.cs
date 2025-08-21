using UnityEngine;

public class InfoAllOff : MonoBehaviour
{
    [SerializeField] Animator[] _anim;
    
    public void InfoOff()
    {
        for(int i = 0; i < _anim.Length; i++)
        {
            _anim[i].SetTrigger("End");
        }
    }
}
