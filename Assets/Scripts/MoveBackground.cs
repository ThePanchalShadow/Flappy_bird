using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] Material BackMat;
    [SerializeField] float timeMultiplier;

    Vector2 texOffset;
    float offsetValue;

    void Update()
    {
        offsetValue += Time.deltaTime * timeMultiplier;
        texOffset.x = offsetValue;

        BackMat.SetTextureOffset("_MainTex", texOffset);
    }
}
