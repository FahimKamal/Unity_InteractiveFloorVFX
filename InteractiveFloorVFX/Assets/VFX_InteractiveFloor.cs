using UnityEngine;
using UnityEngine.VFX;

[ExecuteInEditMode]
public class VFX_InteractiveFloor : MonoBehaviour
{
    public VisualEffect curVisualEffect;

    public Transform PlayerTransform;
    // Start is called before the first frame update
    void Start()
    {
        curVisualEffect = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        curVisualEffect.SetVector3("PlayerPosition", PlayerTransform.position);
    }

    [ContextMenu("Test Function")]
    public void TestFunction()
    {
        
    }
}
