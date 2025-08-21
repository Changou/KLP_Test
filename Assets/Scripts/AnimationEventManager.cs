using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class AnimationEventManager : MonoBehaviour
{
    private static AnimationEventManager _inst;
    public static AnimationEventManager Inst => _inst;

    [SerializeField] Animator _explotion;
    [SerializeField] GameObject _product;
    [SerializeField] GameObject _gift;
    [SerializeField] GameObject _productInfo;
    [SerializeField] RatingEffectOn _ratingEffect;
    [SerializeField] GameObject _openBtn;
    [SerializeField] GameObject _reBtn;
    [SerializeField] InfoAllOff _infoControl;

    private void Awake()
    {
        _inst = this; 
    }

    public void OnAnimation(string obj)
    {
        switch (obj)
        {
            case "Gift":
                NextEffect();
                break;
            case "ExpAnimator":
                ProductEnable();
                break;
            case "Img":
                OnInfo();
                break;
        }
    }

    public void NextEffect()
    {
        _explotion.SetTrigger("Explotion");
    }
    public void ProductEnable()
    {
            _product.SetActive(true);
            _gift.SetActive(false);
    }
    public void OnInfo()
    {
        _productInfo.SetActive(true);
        _ratingEffect.OnEffect();
        _reBtn.SetActive(true);
    }

    public void ReBtnAnimationStart()
    {
        _infoControl.InfoOff();
        _ratingEffect.OffEffect();
    }

    public void PutInGift()
    {
        _gift.SetActive(true);
        _gift.GetComponent<Animator>().SetTrigger("End");
        _product.GetComponent<Animator>().SetTrigger("Start");
    }
    public void ResetUI()
    {
        _product.SetActive(false);
        _openBtn.SetActive(true);
        _infoControl.gameObject.SetActive(false);
    }
}
