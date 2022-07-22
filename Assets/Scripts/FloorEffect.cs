using UnityEngine;

public class FloorEffect : MonoBehaviour
{

    public float mainTexSpeed;
    public float bumpMapSpeed;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float mainTexOffset = Time.time * mainTexSpeed;
        float bumpMapOffset = Time.time * bumpMapSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(mainTexOffset, mainTexOffset));
        rend.material.SetTextureOffset("_BumpMap", new Vector2(bumpMapOffset, bumpMapOffset));
    }
}
