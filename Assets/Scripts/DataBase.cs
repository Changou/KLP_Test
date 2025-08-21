using UnityEngine;
using System;

[Serializable]
public class ItemData
{
    public Sprite _img;
    public string _brand;
    public string _name;
    public string _rating;
    public int _price;
}


public class DataBase : MonoBehaviour
{

    public ItemData[] _items;
   
}
