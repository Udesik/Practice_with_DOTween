using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private Color _color;

    private string _textChange1 = "Dota 2 - ";
    private string _textChange2 = "The worst game in the world";
    private string _textChange3 = "The best game in the world";

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_textChange1, _duration));
        sequence.Append(_text.DOText(_textChange2, _duration).SetRelative());
        sequence.Append(_text.DOText(_textChange3, _duration, true, ScrambleMode.All));
        sequence.Insert(3, _text.DOColor(_color, _duration));
    }
}
