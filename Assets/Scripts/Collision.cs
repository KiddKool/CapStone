
using UnityEngine;

public class Collision : MonoBehaviour
{
    public playermovement motion;
     void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
       if (collisionInfo.collider.tag == "Obstacle")
        {
            motion.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
