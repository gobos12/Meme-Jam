using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    [SerializeField] private float translateSpeed;
    [SerializeField] private float rotationSpeed;

    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate(){
        HandleTranslation();
        HandleRotation();
    }

    private void HandleTranslation(){
        var targetPosition = target.TransformPoint(offset);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, translateSpeed * Time.deltaTime);
    }

    private void HandleRotation(){
        var direction = target.position - transform.position;
        var targetRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = SmoothDampQuaternion(transform.rotation, targetRotation, ref velocity, rotationSpeed * Time.deltaTime);
    }

    public static Quaternion SmoothDampQuaternion(Quaternion current, Quaternion target, ref Vector3 currentVelocity, float smoothTime){
        Vector3 c = current.eulerAngles;
        Vector3 t = target.eulerAngles;
        return Quaternion.Euler(
            Mathf.SmoothDampAngle(c.x, t.x, ref currentVelocity.x, smoothTime),
            Mathf.SmoothDampAngle(c.y, t.y, ref currentVelocity.y, smoothTime),
            Mathf.SmoothDampAngle(c.z, t.z, ref currentVelocity.z, smoothTime)
        );
    }
}
