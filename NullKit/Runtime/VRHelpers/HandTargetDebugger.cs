using UnityEngine;

public class HandTargetDebugger : MonoBehaviour
{
    public Transform leftHand;
    public Transform rightHand;

    void OnDrawGizmos()
    {
        if (leftHand)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(leftHand.position, 0.05f);
        }

        if (rightHand)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(rightHand.position, 0.05f);
        }
    }
}
