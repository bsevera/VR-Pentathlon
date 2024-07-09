using UnityEngine;

public class Mirror : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;    

    void OnPreCull()
    {
        _camera.ResetWorldToCameraMatrix();
        _camera.ResetProjectionMatrix();
        _camera.projectionMatrix = _camera.projectionMatrix * Matrix4x4.Scale(new Vector3(-1, 1, 1));
    }

    private void OnPreRender()
    {
        GL.invertCulling = true;  
    }

    private void OnPostRender()
    {
        GL.invertCulling = false;
    }
}
