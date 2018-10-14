using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(vgPlayerController))]
public class vgPlayerNavigationController : vgMonoBehaviour {
    protected virtual void Update() {
		this.UpdateActionUI();
		this.UpdatePosition();

		if (Input.GetKeyDown(KeyCode.Numlock)) {
			this.noclip = !this.noclip;
			if (this.noclip) {
				this.gravity = -1f;
				this.maxWalkSpeed = this.maxNoclipSpeed;
				this.maxJogSpeed = this.maxNoclipSpeed;
			} else {
				this.gravity = 9f;
				this.maxWalkSpeed = this.maxOriginalWalkSpeed;
				this.maxJogSpeed = this.maxOriginalJogSpeed;
			}
		}

		if (Input.GetKeyDown(KeyCode.PageUp)) {
			this.characterController.Move(Vector3.right * 1.5f);
		}
		if (Input.GetKeyDown(KeyCode.PageDown)) {
			this.characterController.Move(Vector3.left * 1.5f);
		}
		if (Input.GetKeyDown(KeyCode.Home)) {
			this.characterController.Move(Vector3.up * 1.5f);
		}
		if (Input.GetKeyDown(KeyCode.End)) {
			this.characterController.Move(Vector3.down * 1.5f);
		}
		if (Input.GetKeyDown(KeyCode.Insert)) {
			this.characterController.Move(Vector3.forward * 1.5f);
		}
		if (Input.GetKeyDown(KeyCode.Delete)) {
			this.characterController.Move(Vector3.back * 1.5f);
		}
	}

    private bool noclip = false;
	private float maxNoclipSpeed = 10f;
	private float maxOriginalWalkSpeed = 3f;
	private float maxOriginalJogSpeed = 6f;
}
