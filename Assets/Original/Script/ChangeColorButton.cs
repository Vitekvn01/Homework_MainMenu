using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorButton : MonoBehaviour
{
    [SerializeField] private Color _newColor;
    [SerializeField] private float _duration;

    private Color _originalColor;
    
    private Image _image;
    private Button _button;
    
    private Tween _colorTween;
    private void Awake()
    {
        _image = GetComponent<Image>();
        _originalColor = _image.color;
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeColor);
    }

    private void ChangeColor()
    {
        _image.color = _originalColor;
        _colorTween.Kill();
        _colorTween = _image.DOColor(_newColor, _duration).SetEase(Ease.InOutSine)
            .SetLoops(2, LoopType.Yoyo);
    }
}
