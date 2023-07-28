using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeGizmo : MonoBehaviour
{

    public float cubeSize = 1.0f;
    private float axisLength = 1.2f;

    private void OnDrawGizmosSelected()
    {
        // Draw the cube gizmo
        DrawCubeGizmo();
        DrawAxes();
    }


    private void DrawCubeGizmo()
    {
        Gizmos.color = Color.green;


        Vector3[] cubeCorners = new Vector3[8];
        float halfSize = cubeSize * 0.5f;

        cubeCorners[0] = transform.position + transform.up * halfSize + transform.right * halfSize + transform.forward * halfSize;
        cubeCorners[1] = transform.position + transform.up * halfSize + transform.right * halfSize - transform.forward * halfSize;
        cubeCorners[2] = transform.position + transform.up * halfSize - transform.right * halfSize + transform.forward * halfSize;
        cubeCorners[3] = transform.position + transform.up * halfSize - transform.right * halfSize - transform.forward * halfSize;
        cubeCorners[4] = transform.position - transform.up * halfSize + transform.right * halfSize + transform.forward * halfSize;
        cubeCorners[5] = transform.position - transform.up * halfSize + transform.right * halfSize - transform.forward * halfSize;
        cubeCorners[6] = transform.position - transform.up * halfSize - transform.right * halfSize + transform.forward * halfSize;
        cubeCorners[7] = transform.position - transform.up * halfSize - transform.right * halfSize - transform.forward * halfSize;

        // Draw the lines between the corners to form the cube
        Gizmos.DrawLine(cubeCorners[0], cubeCorners[1]);
        Gizmos.DrawLine(cubeCorners[1], cubeCorners[3]);
        Gizmos.DrawLine(cubeCorners[3], cubeCorners[2]);
        Gizmos.DrawLine(cubeCorners[2], cubeCorners[0]);

        Gizmos.DrawLine(cubeCorners[4], cubeCorners[5]);
        Gizmos.DrawLine(cubeCorners[5], cubeCorners[7]);
        Gizmos.DrawLine(cubeCorners[7], cubeCorners[6]);
        Gizmos.DrawLine(cubeCorners[6], cubeCorners[4]);

        Gizmos.DrawLine(cubeCorners[0], cubeCorners[4]);
        Gizmos.DrawLine(cubeCorners[1], cubeCorners[5]);
        Gizmos.DrawLine(cubeCorners[2], cubeCorners[6]);
        Gizmos.DrawLine(cubeCorners[3], cubeCorners[7]);
    }

    private void DrawAxes()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * axisLength);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.up * axisLength);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.forward * axisLength);
    }
}

