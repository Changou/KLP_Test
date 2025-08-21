using UnityEngine;

public class AnimationEventProxy : MonoBehaviour
{
    public void OnAnim()
    {
        AnimationEventManager.Inst.OnAnimation(gameObject.name);
    }
}
