using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInCamera : MonoBehaviour
{
    [SerializeField] new protected Camera camera;

    // границы в плоскости XZ, т.к. камера стоит выше остальных объектов
    float x_left;
    float x_right;
    float z_top;
    float z_bot;

    Vector3 leftTop;
    Vector3 leftBot;
    Vector3 rightBot;
    Vector3 rightTop;

    private void FixedUpdate()
    {
        Vector3 cameraToObject = transform.position - camera.transform.position;
        // отрицание потому что игровые объекты в данном случае находятся ниже камеры по оси y
        //float distance = -Vector3.Project(cameraToObject, Camera.main.transform.forward).y;
        float distance1 = -cameraToObject.y;

        // вершины "среза" пирамиды видимости камеры на необходимом расстоянии от камеры
        //Vector3 leftBot = camera.ViewportToWorldPoint(new Vector3(0, 0, distance1));
        //Vector3 rightTop = camera.ViewportToWorldPoint(new Vector3(1, 1, distance2));

        leftTop  = camera.ViewportToWorldPoint(new Vector3(0, 1, distance1));
        leftBot  = camera.ViewportToWorldPoint(new Vector3(0, 0, distance1));
        rightBot = camera.ViewportToWorldPoint(new Vector3(1, 0, distance1));
        rightTop = camera.ViewportToWorldPoint(new Vector3(1, 1, distance1));

        // границы в плоскости XZ, т.к. камера стоит выше остальных объектов
        x_left = leftBot.x;
        x_right = rightTop.x;
        z_top = rightTop.z;
        z_bot = leftBot.z;

        // ограничиваем объект в плоскости XZ
        Vector3 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, x_left, x_right);
        clampedPos.z = Mathf.Clamp(clampedPos.z, z_bot, z_top);
        transform.position = clampedPos;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        /*
        Gizmos.DrawLine(
            new Vector3(x_left, transform.position.y, z_bot),
            new Vector3(x_right, transform.position.y, z_bot));

        Gizmos.DrawLine(
            new Vector3(x_left, transform.position.y, z_top),
            new Vector3(x_right, transform.position.y, z_top));

        Gizmos.DrawLine(
            new Vector3(x_left, transform.position.y, z_bot),
            new Vector3(x_left, transform.position.y, z_top));

        Gizmos.DrawLine(
            new Vector3(x_right, transform.position.y, z_bot),
            new Vector3(x_right, transform.position.y, z_top));
            */

        Gizmos.DrawLine(leftTop, leftBot);
        Gizmos.DrawLine(leftBot, rightBot);
        Gizmos.DrawLine(rightBot, rightTop);
        Gizmos.DrawLine(rightTop, leftTop);

        Gizmos.DrawLine(
            transform.position,
            camera.transform.position);
    }
}
