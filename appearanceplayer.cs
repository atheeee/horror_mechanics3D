using UnityEngine;

public class PlayerAppearance : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public TrailRenderer trailRenderer;

    [Header("Цвета для скинов")]
    public Color defaultColor;
    public Color redColor;
    public Color greenColor;
    public Color blueColor;

    void Start()
    
    {
        ApplySkin(CurrencyManager.Instance.GetCurrentSkin());
    }

    public void ApplySkin(SkinType skin)
{
    Color chosenColor = defaultColor;

    switch (skin)
    {
        case SkinType.Red: chosenColor = redColor; break;
        case SkinType.Green: chosenColor = greenColor; break;
        case SkinType.Blue: chosenColor = blueColor; break;
    }

    // Убедимся, что альфа = 1
    chosenColor.a = 1f;

    spriteRenderer.color = chosenColor;

    // Также задаём альфа-канал для трейла вручную
    Color trailStart = chosenColor;
    Color trailEnd = chosenColor;
    trailStart.a = 1f;
    trailEnd.a = 1f;

    trailRenderer.startColor = trailStart;
    trailRenderer.endColor = trailEnd;
}
}