# How To Make a Simple Joystick
## The One In Stand Assests from Unity3D
![joystick](https://i.imgsafe.org/a26ae3b.png)
This prefab is with the move button and jump button.  And there is other 4 prefabs in the package too.
![4 prefabs](https://i.imgsafe.org/3a8a2a1.png)

### How To Get It?
	Assets > Import Package > CrossPlatformInput

### How To Use It?
1. Add the prefab to the scene;
2. Get the axis like the original Input Manager.

**i.e.**

	using UnityStandardAssets.CrossPlatformInput;
    ...
    //just like using Input Manager
    x = CrossPlatformInputManager.GetAxis("Horizontal");
    y = CrossPlatformInputManager.GetAxis("Vertical");
    ...
    CrossPlatformInputManager.GetButtonDown("Jump");


**P.S.**
- The cross platform input is from the unity3d standard asses, make sure that you have already install it.
- More About It, Please Read CrossPlatformInputGuidelines in the package folder.

## [Simple Joystick (Move Rotate Fire)](https://www.assetstore.unity3d.com/#!/content/59691)
This is a different joystick, which support movement rotation and fire/jump input. 
![simple](https://lh3.googleusercontent.com/fU1DUGyP_QRbPKgu8qmuAM4737jHDWCg7CPE5qu-8eHE7nVvsuiEj2WrxXBjLv_efIc=h900)

And it will release on assest store days later.

### How To
1. Download And Import The Package
2. Drag and drop the `ControlCanvas` to the scene
3. Add `EventSystem` to the scene too
4. It is done (There is a sample scene in the package, you can double click to open it.)

#### Download And Import The Package
[Simple Joystick on Assest Store]((https://www.assetstore.unity3d.com/#!/content/59691), the assest package will be released days later.

#### Drag and drop
![drag drop](https://i.imgsafe.org/40a618e.png)

#### Add EventSystem
![event](https://i.imgsafe.org/9149fa4.png)
And it is ok to keep the default parameters.

#### Use the 3 static classes to get Axis and Fire
- JoystickMove.instance. (H and V)
- JoystickRotate.instance. (H and V)
- JoystickFire.instance.Fire

##### Example
	void Update () {
		transform.Translate(new Vector3(JoystickMove.instance.H,0f,JoystickMove.instance.V)*speed*Time.deltaTime);


		transform.LookAt(transform.position+new Vector3(JoystickRotate.instance.H,0f,JoystickRotate.instance.V));

		if(JoystickFire.instance.Fire){
			Debug.Log("fire");
		}
	}// this is in the sample scene `CubeControl`
