using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject toFollow;
    const int cameraZPosition = -10;
    void LateUpdate()
    {
        transform.position = toFollow.transform.position + new Vector3(0,0,cameraZPosition);
    }
}
