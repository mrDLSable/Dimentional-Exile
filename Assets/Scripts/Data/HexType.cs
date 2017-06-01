﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{

    public class HexType
    {

        public HexType(string name)
        {
            this.Name = name;
            Actions = new List<HexAction>();
            SetMaterial("default");
        }

        public static HexType Void;
        public static HexType Cell;
        public static HexType Expansion;

        public string Name;
        public Material Material;

        public List<HexAction> Actions;

        public HexUpgrade Upgrade;

        public static void Init()
        {
            Void = new HexType("Void").SetMaterial("Void");

            Cell = new HexType("Cell").SetMaterial("Cell");
            Cell.AddAction(HexAction.CreateRuneBasicBlank);
            Cell.AddAction(HexAction.CreateTwoRuneBasicBlank);
            Cell.AddAction(HexAction.CreateRuneBasicSpace);
            Cell.AddAction(HexAction.CreateRuneBasicStability);
            Cell.AddAction(HexAction.CreateClusterBasicExpansion);

            Expansion = new HexType("Expansion");
            Expansion.SetMaterial("Expansion");
            Void.SetUpgrade(new HexUpgrade(HexType.Expansion).SetInput(new Item(ItemData.ClusterBasicExpansion).SetAmount(1)));
        }

        public HexType SetMaterial(string matName)
        {
            Material = Resources.Load<Material>("Materials/Hexes/" + matName);
            return this;
        }

        public HexType AddAction(HexAction action)
        {
            Actions.Add(action);
            return this;
        }

        public HexType SetUpgrade(HexUpgrade upgrade)
        {
            this.Upgrade = upgrade;
            return this;
        }
    }
}