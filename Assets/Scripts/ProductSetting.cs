using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductSetting : MonoBehaviour
{
    public SpriteRenderer _sprite;
    public SpriteRenderer _rating_color;
    public Text _rating;
    public Text _brand;
    public Text _name;
    public Text _price;

    Dictionary<string, Color> _colorRating = new Dictionary<string, Color>()
    {
        {"S", new Color32(226,129,84,255) },
        {"A", new Color32(85,129,226,255) },
        {"B", new Color32(85,226,89,255)}
    };

    public void Setting(Sprite sprite, string rating, string brand, string name, int price) 
    {
        _sprite.sprite = sprite;

        if (_colorRating.TryGetValue(rating, out Color ratingColor))
            _rating_color.color = ratingColor;
        else
            _rating_color.color = Color.black;

        _rating.text = rating;
        _brand.text = brand;
        _name.text = name;
        _price.text = price.ToString("N0") + "¿ø";
    }
}
