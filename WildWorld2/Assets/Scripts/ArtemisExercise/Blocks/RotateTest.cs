using UnityEngine;

public class RotateTest : MonoBehaviour
{
    public Vector3 RotateStep = new Vector3(0, 180, 0);

    public float RotateSpeed = 5f;

    private Quaternion _targetRot = Quaternion.identity;

    private void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, _targetRot, RotateSpeed * Time.deltaTime);
    }

    public void OnMouseDown()
    {
        _targetRot *= Quaternion.Euler(RotateStep);
    }
}