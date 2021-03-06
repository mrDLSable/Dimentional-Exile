﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{

    /// <summary>
    /// The data of the items
    /// </summary>
    public class ItemData
    {

        /// <summary>
        /// Creates an ItemData object and adds it to the Dictionary.
        /// </summary>
        /// <param name="name">The name of the ItemData.</param>
        public ItemData(string name)
        {
            this.Name = name;
            SetImage("default");
        }

        public static ItemData RuneBasicBlank;
        public static ItemData RuneBasicSpace;
        public static ItemData RuneBasicStability;
        public static ItemData RuneBasicOre;

        public static ItemData ClusterBasicExpansion;
        public static ItemData ClusterBasicWorkshop;

        public string Name;  // The name of the itemdata
        public Sprite Texture;  // The sprite of the itemdata
        public int StackLimit = 99;  // The maximum number of items in an Item object

        /// <summary>
        /// Creates all the itemdatas in the game
        /// </summary>
        public static void CreateItemDatas()
        {
            RuneBasicBlank = new ItemData("Basic Blank Rune").SetImage("Basic Blank Rune").SetStackLimit(500);
            RuneBasicSpace = new ItemData("Basic Space Rune").SetImage("Basic Space Rune").SetStackLimit(500);
            RuneBasicStability = new ItemData("Basic Stability Rune").SetImage("Basic Stability Rune").SetStackLimit(500);
            RuneBasicOre = new ItemData("Basic Ore Rune").SetImage("Basic Ore Rune").SetStackLimit(500);

            ClusterBasicExpansion = new ItemData("Basic Expansion Cluster");
            ClusterBasicExpansion.SetImage("Basic Expansion Cluster");
            ClusterBasicExpansion.SetStackLimit(10);

            ClusterBasicWorkshop = new ItemData("Basic WOrkshop Cluster");
            ClusterBasicWorkshop.SetImage("Basic Workshop Cluster");
            ClusterBasicWorkshop.SetStackLimit(10);
        }

        /// <summary>
        /// Set the sprite of the item
        /// </summary>
        /// <param name="imageName">The sprite to use</param>
        /// <returns>The ItemData object</returns>
        public ItemData SetImage(string imageName)
        {
            Texture = Resources.Load<Sprite>("Images/" + imageName);
            return this;
        }

        /// <summary>
        /// Sets the Stack Limit
        /// </summary>
        /// <param name="stackLimit">The Stack Limit</param>
        /// <returns>The ItemData object.</returns>
        public ItemData SetStackLimit(int stackLimit)
        {
            this.StackLimit = stackLimit;
            return this;
        }

    }
}