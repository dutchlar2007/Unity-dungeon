using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform target;
    Vector3 var;
    void Start() {
        var.z = -1; 
        var.x = target.position.x;
        var.y = target.position.y;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //hello
        transform.position = var;
        var.x = target.position.x;
        var.y = target.position.y;
    }
}
 