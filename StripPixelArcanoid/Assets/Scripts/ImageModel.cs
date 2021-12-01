using UnityEngine;

public class ImageModel : MonoBehaviour
{
    private Sprite sprite;

    public delegate void SelectImage(Sprite sprite);
    private SelectImage selecAction;

    public void AddSprite(Sprite sprite)
    {
        this.sprite = sprite;
    }

    public void Fire()
    {
        selecAction(sprite);
    }

    public void AddAcion(SelectImage action)
    {
        selecAction = action;
    }
}
