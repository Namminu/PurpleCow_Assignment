using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
	private InputSystem_Actions input;

	private void Awake()
	{
		input = new InputSystem_Actions();
	}

	private void OnEnable()
	{
		input.Enable();

		input.GamePlay.Press.started += OnPress;
		input.GamePlay.Press.canceled += OnRelease;
	}

	private void OnDisable()
	{
		input.Disable();
	}

	private void OnPress(InputAction.CallbackContext ctx)
	{
		Debug.Log("Press Start");
	}

	private void OnRelease(InputAction.CallbackContext ctx)
	{
		Debug.Log("Press End");
	}

	private void Update()
	{
		Vector2 pos =
			input.GamePlay.Position.ReadValue<Vector2>();

		Debug.Log(pos);
	}
}
