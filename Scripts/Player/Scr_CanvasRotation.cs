using Unity.Mathematics;
using UnityEngine;

public class Scr_CanvasRotation : MonoBehaviour
{
    public GameObject parent;
    public Canvas child;
    private quaternion parentRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        parentRotation = parent.transform.rotation;
        child.transform.localRotation = Quaternion.Inverse(parentRotation);
    }
}
