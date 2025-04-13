using UnityEditor;
using UnityEngine;

public static class CreateTestArena
{
    [MenuItem("NullKit/VR Tools/Create Test Arena")]
    public static void CreateArena()
    {
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "TestGround";
        ground.transform.localScale = new Vector3(10, 1, 10);
        ground.AddComponent<Rigidbody>().isKinematic = true;

        for (int i = 0; i < 4; i++)
        {
            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall.name = "TestWall_" + i;
            wall.transform.localScale = new Vector3(1, 5, 20);
            wall.transform.position = Quaternion.Euler(0, 90 * i, 0) * new Vector3(0, 2.5f, 10);
            wall.AddComponent<Rigidbody>().isKinematic = true;
        }

        Debug.Log("[NullKit] Test arena created.");
    }
}
