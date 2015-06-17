﻿/*
 * Copyright 2014 Jason Graves (GodLikeMouse/Collaboradev)
 * http://www.collaboradev.com
 *
 * This file is part of Unity - Topology.
 *
 * Unity - Topology is free software: you can redistribute it 
 * and/or modify it under the terms of the GNU General Public 
 * License as published by the Free Software Foundation, either 
 * version 3 of the License, or (at your option) any later version.
 *
 * Unity - Topology is distributed in the hope that it will be useful, 
 * but WITHOUT ANY WARRANTY; without even the implied warranty of 
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU 
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License 
 * along with Unity - Topology. If not, see http://www.gnu.org/licenses/.
 */

using UnityEngine;
using System.Collections;

namespace Topology {

	public class Node : MonoBehaviour {

		public string id;
		public TextMesh nodeText;
		//public CameraControlZeroG selectionController;
		public bool selected
		{
			get{return _selected;}
			set
			{
				if (value) renderer.material.color=Color.green; 
				else renderer.material.color=Color.blue;//new Color(22,70,109,255);//Color.blue;
				_selected=value; 
			}
		
		}
		bool _selected;
		
		void Update () {
			//node text always facing camera
			nodeText.transform.LookAt (Camera.main.transform);
		}
		
		void OnMouseDown()
		{
			//print ("Node"+nodeText.text+" clickd!");
			//nodeText.text+=" clickd!";
			//this.gameObject.renderer.material.color=Color.green;
			Camera.main.gameObject.GetComponent<CameraControlZeroG>().NodeReturn(this);
			//selectionController.NodeReturn(this);
		}
	}

}