using UnityEngine;
using TMPro;

public class FPSCount : MonoBehaviour
{
    public TextMesh FPSText;

    private float deltaTime = 0.0f;
    private float fpsSum = 0.0f;
    private int frameCount = 0;
    private float oneSecondTimer = 0.0f;
    private float averageFPS = 0.0f;

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;

        fpsSum += fps;
        frameCount++;
        oneSecondTimer += Time.unscaledDeltaTime;

        if (oneSecondTimer >= 1.0f)
        {
            averageFPS = fpsSum / frameCount;
            fpsSum = 0.0f;
            frameCount = 0;
            oneSecondTimer = 0.0f;
        }

        FPSText.text = $"FPS: {fps:F1}\nAvg FPS: {averageFPS:F1}";
    }
}
