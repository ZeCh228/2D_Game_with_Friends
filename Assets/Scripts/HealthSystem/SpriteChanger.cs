using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField] Sprite _frogTombSprite;
    [SerializeField] Sprite _pinkmanTombSprite;
    [SerializeField] Animator _AnimFrog;
    [SerializeField] Animator _AnimPinkman;


    public void ChangeFrogSprite(SpriteRenderer FrogSpriteRenderer)
    {
        _AnimFrog.enabled = false;
        FrogSpriteRenderer.sprite = _frogTombSprite;
    }

    public void ChangePinkmanSprite(SpriteRenderer PinkmanSpriteRenderer)
    {
        _AnimPinkman.enabled = false;
        PinkmanSpriteRenderer.sprite = _pinkmanTombSprite;
    }
}
