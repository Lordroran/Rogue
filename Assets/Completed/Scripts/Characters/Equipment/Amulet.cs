﻿
using System.Collections.Generic;
using UnityEngine;

namespace Completed
{
    public abstract class Amulet : Item, ICallableObservable
    {
        //**************** Item ******************************
        public abstract Texture2D getIcon();

        public string getIconPath()
        {
            return RogueUtils.getEquipmentIconDir() + "/"
                + getItemType() + "/"
                + GetType().Name + ".png";
        }

        public abstract string getItemType();

        //************ ICallableObservable *******************

        public abstract int getRequiredActionPoints();

        private List<ICallableObserver> observer;

        public void addObserver(ICallableObserver observer)
        {
            this.observer.Add(observer);
        }

        public void removeObserver(ICallableObserver observer)
        {
            this.observer.Remove(observer);
        }

        //*****************************************************
    }
}
