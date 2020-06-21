
using UnityEngine;

public class collisioon : MonoBehaviour
{
    public movement move;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obstacle")
        {
            move.enabled = false;
        }
    }


}
