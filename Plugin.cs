using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace GorillaTagModTemplateProject
{

	[BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{
		GameObject mirror;
		GameObject mirrorBoard;
		GameObject mirrorStand;

		void Start()
		{
			Utilla.Events.GameInitialized += OnGameInitialized;
		}

		void OnGameInitialized(object sender, EventArgs e)
		{
			mirror = GameObject.Find("TreeRoom/TreeRoomInteractables/mirror (1)");
			mirrorBoard = GameObject.Find("TreeRoom/TreeRoomInteractables/mirror (1)/board");
			mirrorStand = GameObject.Find("TreeRoom/TreeRoomInteractables/mirror (1)/stand");

		}

		void Update()
		{
			mirror.SetActive(this.enabled);
			mirror.GetComponentInChildren<MeshCollider>().enabled = false;
			mirrorBoard.GetComponent<MeshCollider>().enabled = false;
			mirrorStand.GetComponent<MeshCollider>().enabled = false;
		}
	}
}
