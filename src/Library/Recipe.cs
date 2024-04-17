//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public static ArrayList steps = new ArrayList();

        public static Product FinalProduct { get; set; }
        public static double TotalAll {get; set;}
        public static double TotalProduct {get; set;}
        public static double TotalEquipment {get; set;}


        public void AddStep(Step step)
        {
            Recipe.steps.Add(step);

        }

        public void RemoveStep(Step step)
        {
            Recipe.steps.Remove(step);
        }
        public static double GetProductionCost()
        {
            foreach (Step step in Recipe.steps)
            {
                TotalProduct += step.Quantity * step.Input.UnitCost;
                TotalEquipment += step.Time * step.Equipment.HourlyCost;
                TotalAll = TotalProduct + TotalEquipment;

            }
            return TotalAll;
        }
    }
}