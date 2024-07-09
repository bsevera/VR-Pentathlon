using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionBasedOnCamera : MonoBehaviour
{
    [SerializeField]
    Camera _mainCamera;
    [SerializeField]
    GameObject _XROrigin;
    [SerializeField]
    float _XOffset;
    [SerializeField]
    float _YOffset;
    [SerializeField]
    float _ZOffset;


    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float cameraYValue = _mainCamera.transform.position.y;

        //this.gameObject.transform.position = _XROrigin.transform.position;

        this.gameObject.transform.position = new Vector3(_mainCamera.transform.position.x, _mainCamera.transform.position.y + _YOffset, this.gameObject.transform.position.z);
        //this.gameObject.transform.position = new Vector3(_mainCamera.transform.position.x + _XOffset, cameraYValue + _YOffset, _mainCamera.transform.position.z + _ZOffset);

        //this.gameObject.transform.position = new Vector3(_mainCamera.transform.position.x, cameraYValue + _YOffset, _mainCamera.transform.position.z + _ZOffset);
        //this.gameObject.transform.rotation = _XROrigin.transform.rotation;
        //this.gameObject.transform.localRotation = _XROrigin.transform.localRotation;

        //this.gameObject.transform.position = new Vector3(_XROrigin.transform.position.x + _XOffset, cameraYValue + _YOffset, _XROrigin.transform.position.z + _ZOffset);
    }

}
