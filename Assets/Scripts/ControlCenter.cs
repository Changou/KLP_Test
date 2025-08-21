using UnityEngine;

public class ControlCenter : MonoBehaviour
{
    [SerializeField] DataBase _data;
    [SerializeField] ProductSetting _pSetting;
    [SerializeField] GiftOpenAnimation _goAim;

    public void GiftOpen()
    {
        int productNumber = Random.Range(0, _data._items.Length);
        _pSetting.Setting(
            _data._items[productNumber]._img,
            _data._items[productNumber]._rating,
            _data._items[productNumber]._brand,
            _data._items[productNumber]._name,
            _data._items[productNumber]._price);

        _goAim.GiftOpen();
    }

    
}
