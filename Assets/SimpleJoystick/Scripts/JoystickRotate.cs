using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


namespace GeekGame.Input{
	public class JoystickRotate : JoystickMove
	{

		public static JoystickRotate instance=null;



		void Awake(){

			if(instance!=null){
				Destroy(this.gameObject);
			}else{
				instance=this;
			}

		}



	}
}