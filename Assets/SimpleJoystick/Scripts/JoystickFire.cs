using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace GeekGame.Input{

	public class JoystickFire : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
	{

		public static JoystickFire instance=null;

		private bool _fire=false;
		public bool Fire{
			get{return _fire;}
		}


		void Awake(){

			if(instance!=null){
				Destroy(this.gameObject);
			}else{
				instance=this;
			}

		}



		public void OnPointerDown(PointerEventData data){

			_fire=true;
		}

		public void OnPointerUp(PointerEventData data){

			_fire=false;
		}
	}
}