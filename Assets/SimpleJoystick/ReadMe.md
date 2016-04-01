# Simple Joystick 

This is a simple joysitck from [GeekGame](https://geekgame.bai.uno/). And it is simple and easy to use.

## Key Features
- Movement
- Rotation
- Fire/Jump

##How To
1. Please see the demo scene firstly.
2. Drag the prefab `ControlCanvas` to the hierachy
3. Add `EventSystem`
4. Add `Using GeekGame.Input;` to your player control script
5. Use `JoystickMove / JoystickRotate` to get horizontal and vertical values from 2 joysticks (See `CubeControl` Script)
6. Use `JoystickFire` to get the fire(bool) value (See `CubeControl` Script)


## Contents
- The `JoystickMove` return 2 value, one is H(orizontal) axe, the other is V(ertical) axe.
- `JoystickRotate` return H and V too.
- `JoystickFire` give a bool value `Fire`.

## Config
You can easily use other sprite to replace the handle and the joystick ring.