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
                this.gravity = this.noclipGravity;
                this.walkSpeed = this.noclipSpeed;
                this.walkBackwardSpeed = this.noclipSpeed;
                this.strafeSpeed= this.noclipSpeed;
                this.jogSpeed = this.noclipSpeed;
                this.jogBackwardSpeed = this.noclipSpeed;
                this.jogStrafeSpeed = this.noclipSpeed;
            } else {
                this.gravity = this.defaultGravity;
                this.walkSpeed = this.defaultWalkSpeed;
                this.walkBackwardSpeed = this.defaultWalkBackwardSpeed;
                this.strafeSpeed = this.defaultStrafeSpeed;
                this.jogSpeed = this.defaultJogSpeed;
                this.jogBackwardSpeed = this.defaultJogBackwardSpeed;
                this.jogStrafeSpeed = this.defaultJogStrafeSpeed;
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

    private float noclipGravity = -1f;
    private float defaultGravity = 9f;

    private float defaultWalkSpeed = 3f;
    private float defaultWalkBackwardSpeed = 2f;
    private float defaultStrafeSpeed = 3f;
    private float defaultJogSpeed = 6f;
    private float defaultJogBackwardSpeed = 4f;
    private float defaultJogStrafeSpeed = 6f;

    private float noclipMovMultiplier = 3f;
}
