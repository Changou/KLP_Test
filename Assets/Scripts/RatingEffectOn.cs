using UnityEngine;

public class RatingEffectOn : MonoBehaviour
{
    [SerializeField] GameObject[] _effect;
    [SerializeField] ProductSetting _product;

    public void OnEffect()
    {
        int n = 0;
        switch (_product._rating.text)
        {
            case "S":
                n = 0;
                break;
            case "A":
                n = 1;
                break;
            case "B":
                n = 2;
                break;
        }
        _effect[n].SetActive(true);
        _effect[n].GetComponent<ParticleSystem>().Play();
    }

    public void OffEffect()
    {
        for(int i = 0; i < _effect.Length; i++)
        {
            if (_effect[i].activeSelf)
            {
                _effect[i].GetComponent<ShineEffectOn>().OffEffect();
            }
        }
    }
}
