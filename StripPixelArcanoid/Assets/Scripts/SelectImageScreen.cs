using System.Collections.Generic;
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

    private Router router;
    private List<LevelModel> levels;

    // Start is called before the first frame update
    void Start()
    {
        SetupRouter();
        LoadImages();
        LayoutScrollView();
        LoadLevels();
    }

    private void LoadLevels()
    {
        //Todo
    }

    private void SetupRouter()
    {
        var router = GameObject.FindGameObjectWithTag("Router");

        if (router == null)
        {
            throw new System.NullReferenceException("Not found tag 'Router'");
        }

        var routerComponent = router.GetComponent<Router>();

        if (routerComponent == null)
        {
            throw new System.NullReferenceException("Missing component 'Router'");
        }

        this.router = routerComponent;
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

            var imageModel = imageGameObject.AddComponent<ImageModel>();
            imageModel.AddSprite(image);
            imageModel.AddAcion(SelectImage);

            var buttonComponent = imageGameObject.GetComponent<Button>();
            buttonComponent.onClick.AddListener(imageModel.Fire);

            
        }
    }


    private void SelectImage(Sprite image)
    {
        router.ShowSelectStageScreen(gameObject, image);
    }
   
    private void LoadImages()
    {
        //TODO

    }
}
