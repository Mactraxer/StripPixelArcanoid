using UnityEngine;
using UnityEngine.UI;

public class ImageStageScreen : MonoBehaviour
{

    [SerializeField]
    private Image image;
    [SerializeField]
    private Transform scrollView;
    [SerializeField]
    private GameObject buttonPrefab;

    public int countStages;

    private void Start()
    {
        countStages = 5;
    }

    public void SelectImage(Sprite sprite)
    {
        SetupImage(sprite);
        SetupStageScroll();
    }

    private void SetupImage(Sprite sprite)
    {
        image.sprite = sprite;
    }

    private void SetupStageScroll()
    {
        for (int i = 0; i < countStages; i++)
        {
            var imageGameObject = Instantiate(buttonPrefab);

            var imageComponent = imageGameObject.GetComponent<Image>();
            
            imageComponent.preserveAspect = true;

            imageGameObject.transform.SetParent(scrollView.transform);
            imageGameObject.transform.localScale = Vector2.one;

            var buttonComponent = imageGameObject.GetComponent<Button>();
            
        }
    }

}
