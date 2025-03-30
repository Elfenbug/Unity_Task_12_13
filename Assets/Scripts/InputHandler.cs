using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private static string Horizontal = "Horizontal";
    private static string Vertical = "Vertical";

    public Vector3 MoveDirection { get; private set; }
    public bool IsJumpRequested { get; private set; }

    private void Update()
    {
        MoveDirection = new Vector3(Input.GetAxisRaw(Horizontal), 0f, Input.GetAxisRaw(Vertical)).normalized;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsJumpRequested = true;
        }
    }

    public void ResetJump()
    {
        IsJumpRequested = false;
    }
}
