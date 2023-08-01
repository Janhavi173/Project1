using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class CubeGizmo : MonoBehaviour
{
    public Color gizmoColor = Color.green;
    public float cubeSize = 1.0f;
    public float axisLength = 1.2f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = gizmoColor;

        Vector3[] cubeCorners = CalculateCubeCorners();

        // Draw the lines between the corners to form the cube
        DrawLine(cubeCorners[0], cubeCorners[1]);
        DrawLine(cubeCorners[1], cubeCorners[3]);
        DrawLine(cubeCorners[3], cubeCorners[2]);
        DrawLine(cubeCorners[2], cubeCorners[0]);

        DrawLine(cubeCorners[4], cubeCorners[5]);
        DrawLine(cubeCorners[5], cubeCorners[7]);
        DrawLine(cubeCorners[7], cubeCorners[6]);
        DrawLine(cubeCorners[6], cubeCorners[4]);

        DrawLine(cubeCorners[0], cubeCorners[4]);
        DrawLine(cubeCorners[1], cubeCorners[5]);
        DrawLine(cubeCorners[2], cubeCorners[6]);
        DrawLine(cubeCorners[3], cubeCorners[7]);
    }

    private Vector3[] CalculateCubeCorners()
    {
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

        return cubeCorners;
    }

    private void DrawLine(Vector3 start, Vector3 end)
    {
        Gizmos.DrawLine(start, end);
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

