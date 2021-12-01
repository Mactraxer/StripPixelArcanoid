using UnityEngine;

public class Router : MonoBehaviour
{
    [SerializeField]
    private ImageStageScreen stageScreen;


    public void ShowSelectStageScreen(GameObject from, Sprite image)
    {
        from.SetActive(false);
        stageScreen.SelectImage(image);
        stageScreen.gameObject.SetActive(true);
    }
}
