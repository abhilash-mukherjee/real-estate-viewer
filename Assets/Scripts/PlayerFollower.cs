using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] private Transform transformToFollow;

    private void LateUpdate()
    {
        transform.SetPositionAndRotation(transformToFollow.position, transformToFollow.rotation);
    }
}
