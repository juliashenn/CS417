using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class Break : MonoBehaviour
{
    public InputActionReference action;
    public XROrigin rig;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (rig.Camera.transform.position.x < 7.5 && rig.Camera.transform.position.x > -7.5 
                && rig.Camera.transform.position.z < 7.5 && rig.Camera.transform.position.z > -7.5)
            {
                rig.MoveCameraToWorldLocation(new Vector3(35f, rig.Camera.transform.position.y, 0f));

            } else
            {
                rig.MoveCameraToWorldLocation(new Vector3(0f, rig.Camera.transform.position.y, 0f));

            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
