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
            } else {
                this.gravity = 9f;
            }
        }

        if (Input.GetKeyDown(KeyCode.PageUp)) {
            this.characterController.Move(Vector3.right * noclipMovMultiplier);
        }
        if (Input.GetKeyDown(KeyCode.PageDown)) {
            this.characterController.Move(Vector3.left * noclipMovMultiplier);
        }
        if (Input.GetKeyDown(KeyCode.Home)) {
            this.characterController.Move(Vector3.up * noclipMovMultiplier);
        }
        if (Input.GetKeyDown(KeyCode.End)) {
            this.characterController.Move(Vector3.down * noclipMovMultiplier);
        }
        if (Input.GetKeyDown(KeyCode.Insert)) {
            this.characterController.Move(Vector3.forward * noclipMovMultiplier);
        }
        if (Input.GetKeyDown(KeyCode.Delete)) {
            this.characterController.Move(Vector3.back * noclipMovMultiplier);
        }
    }

    private bool noclip = false;
    private float noclipMovMultiplier = 3f;
}
