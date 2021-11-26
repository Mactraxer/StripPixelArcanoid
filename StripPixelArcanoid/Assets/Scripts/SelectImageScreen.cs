using UnityEngine;
using UnityEngine.UI;

public class SelectImageScreen : MonoBehaviour
{
    [SerializeField]
    private Sprite[] images;

    [SerializeField]
    private GameObject scrollView;
    [SerializeField]
    private GameObject imagePrefab;

    [SerializeField]
    private GameEvent selectEvent;

    // Start is called before the first frame update
    void Start()
    {
        LoadImages();
        LayoutScrollView();
    }
    private void LayoutScrollView()
    {
        CreateImageGameObjects();
    }

    private void CreateImageGameObjects()
    {
        foreach (var image in images)
        {
            var imageGameObject = Instantiate(imagePrefab);

            var imageComponent = imageGameObject.GetComponent<Image>();
            imageComponent.sprite = image;
            imageComponent.preserveAspect = true;

            imageGameObject.transform.SetParent(scrollView.transform);
            imageGameObject.transform.localScale = Vector2.one;

            var buttonComponent = imageGameObject.GetComponent<Button>();
            buttonComponent.onClick.AddListener(SelectImage);
        }
    }


    private void SelectImage()
    {

    }
   
    private void LoadImages()
    {
        //TODO

    }
}
