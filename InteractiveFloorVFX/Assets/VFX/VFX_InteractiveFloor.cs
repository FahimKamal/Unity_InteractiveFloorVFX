using UnityEngine;
using UnityEngine.VFX;

[ExecuteInEditMode]
public class VFX_InteractiveFloor : MonoBehaviour
{
    public VisualEffect curVisualEffect;

    public Transform PlayerTransform;
    public Transform selfTransform;
    // Start is called before the first frame update
    void Start()
    {
        curVisualEffect = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        curVisualEffect.SetVector3("PlayerPosition", PlayerTransform.position);
        curVisualEffect.SetVector3("SelfPosition", selfTransform.position);
        curVisualEffect.SetVector3("selfRotation", selfTransform.eulerAngles);
    }

    [ContextMenu("Test Function")]
    public void TestFunction()
    {
        Debug.Log("This function will be executed on demand");
    }
}
