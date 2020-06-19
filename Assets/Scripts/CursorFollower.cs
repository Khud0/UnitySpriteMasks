using UnityEngine;

public class CursorFollower : MonoBehaviour
{
    private Camera cam;

    private void Start()
    {
        // Calling Camera.main in the Update function is inefficeint.
        // It's usually better to cache a reference to it.
        cam = Camera.main;
    }
    private void Update()
    {
        // Change cursor's position every frame.
        FollowCursor();   
    }

    private void FollowCursor()
    {
        // Convert position of your cursor to a point on the game's screen.
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        // Apply calculated position to the object this script is attached to.
        this.transform.position = mousePos;
    }
}
