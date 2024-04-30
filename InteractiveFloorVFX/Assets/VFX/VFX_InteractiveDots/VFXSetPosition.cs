using UnityEngine;
using UnityEngine.VFX;

[ExecuteInEditMode]
public class VFXSetPosition : MonoBehaviour
{
    public Transform playerPosition;

    public VisualEffect visualEffect;


    private void Update()
    {
        visualEffect.SetVector3("playerPos", playerPosition.position);
    }
}
