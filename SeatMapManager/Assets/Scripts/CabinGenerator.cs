using UnityEngine;
using UnityEngine.UI;

public class CabinGenerator : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Create canvas
        var canvasGameObject = new GameObject(
            "CabinCanvas",
            new[] { typeof(Canvas) });

        var canvas = canvasGameObject.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.WorldSpace;

        var canvasRectTransform = canvasGameObject.GetComponent<RectTransform>();
        canvasRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 25f);
        canvasRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50f);

        // create panel
        var panelGameObject = new GameObject(
            "CabinPanel",
            new[] { typeof(Canvas), typeof(Image) });

        var panelRectTransform = panelGameObject.GetComponent<RectTransform>();
        panelRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 25f);
        panelRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50f);

        var backgroundSprite = Resources.Load<Sprite>("Sprites/cabin_panel_background");
        var panelImage = panelGameObject.GetComponent<Image>();
        panelImage.sprite = backgroundSprite;

        // set parents
        panelGameObject.transform.SetParent(canvasGameObject.transform);
        canvasGameObject.transform.SetParent(this.transform);
        canvasRectTransform.localPosition = Vector3.zero;
        canvasRectTransform.localScale = new Vector3(0.2f, 0.2f, 1);

        ////this.gameObject.AddComponent<Canvas>();
        ////var canvas = this.GetComponent<Canvas>();
        ////canvas.renderMode = RenderMode.WorldSpace;
    }

    // Update is called once per frame
    void Update()
    {

    }
}